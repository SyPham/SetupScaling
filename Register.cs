using Configuration.heplers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using System.Data.SqlClient;
using Dapper;

namespace Configuration
{
    public partial class Register : Form
    {
        Form _me = new Form();
        private string DriveSerialNumber = Common.GetDriveSerialNumber();
        IDbConnection db = new SqlConnection("Server=phanmemcan.vnsosoft.com\\MSSQLSERVER2017,1444;Database=vnsosoft_phanmemcan;user id=vnsosoft_phanmemcan;password=S_d8dh51");
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _me.Dispose();
            _me.Close();
        }
        string GetLicenseKey()
        {
            var licenseKey = ConfigurationManager.AppSettings["licenseKey"];
            return licenseKey;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Tìm license trong db
                string query = @"select * from Licenses where LicenseKey = @licenseKey";
                string licenseKey = textBox1.Text;
                if (string.IsNullOrEmpty(licenseKey))
                {
                    MessageBox.Show("Key is not Valid!", "Warning",
                                                          MessageBoxButtons.OK,
                                                          MessageBoxIcon.Warning);
                    return;
                }
                var license = db.Query<dynamic>(query, new { licenseKey = licenseKey }).SingleOrDefault();
                // Không có trong db thông báo k tìm thấy key
                if (license == null)
                {
                    if (string.IsNullOrEmpty(licenseKey))
                    {
                        MessageBox.Show("Not found key!", "Warning",
                                                              MessageBoxButtons.OK,
                                                              MessageBoxIcon.Warning);
                        return;
                    }
                }
                // Kiểm tra nếu hardwareId của máy này đã active 1 lần r thì thông báo đã sử dụng
                if (license.HardwareId == DriveSerialNumber && license.Status == true && license.Count == 1)
                {
                    MessageBox.Show("This key has already been used! \nPlease contact supplier via zalo 0865978241 or email sales3.mrthanh@gmail.com! ", "Warning",
                                                           MessageBoxButtons.OK,
                                                           MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật hardwareId vào db
                var pc = SystemInformation.ComputerName;
                var ip = Common.GetLocalIPAddress();
                var param = new DynamicParameters();
                param.Add("LicenseKey", licenseKey);
                param.Add("HardwareId", DriveSerialNumber);
                param.Add("PCName", pc);
                param.Add("LocalIP", ip);
                param.Add("ModifiedTime", DateTime.Now);
                param.Add("Count", 1);
                string query2 = @"update Licenses 
                set HardwareId = @HardwareId,
                Count = @Count,
                PCName = @PCName,
                LocalIP = @LocalIP,
                ModifiedTime = @ModifiedTime,
                Status = 1
                where LicenseKey = @LicenseKey";

                db.Execute(query2, param);



                // Tìm lại license key trong db
                string query3 = @"select * from Licenses where LicenseKey = @licenseKey";
                var license2 = db.Query<dynamic>(query3, new { licenseKey = licenseKey }).SingleOrDefault();
                // Kiểm tra hardwareId có trùng khớp với máy hiện tại và status = true chưa, nếu chưa thông báo key k hợp lệ
                if (license2.HardwareId == DriveSerialNumber && license2.Status == true && license2.Count == 1)
                {
                    UpdateLicense();
                    Form form1 = new Form1();
                    form1.Show();
                    _me.Hide();
                }
                else
                {
                    MessageBox.Show("Key is not Valid!", "Warning",
                                                       MessageBoxButtons.OK,
                                                       MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        void AddLicense()
        {
            // Open App.Config of executable
            System.Configuration.Configuration config =
             ConfigurationManager.OpenExeConfiguration
                        (ConfigurationUserLevel.None);

            // Add an Application Setting.
            config.AppSettings.Settings.Add("licenseKey",
                           DriveSerialNumber);

            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }
        void UpdateLicense()
        {
            try
            {
                var configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                configuration.AppSettings.Settings["licenseKey"].Value = DriveSerialNumber.ToGenerateLicenseKey();
                configuration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                return;
            }

        }
        private void Register_Load(object sender, EventArgs e)
        {
            _me = (Form)sender;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Can not use register function. Please contact administrator!", "Warning",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Warning);
        }
    }
}
