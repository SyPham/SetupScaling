using Configuration.heplers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Configuration;
using System.Reflection;
using System.Data.SqlClient;
using Dapper;

namespace Configuration
{
    public partial class Register : Form
    {
        Form form1 = new Form1();
        Form _me = new Form();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "5QamCsWS8IRbwXZWymiuGJYvOfwQwZQVc7QzZ6Ml222",
            BasePath = "https://scalingmachine-c10ed-default-rtdb.asia-southeast1.firebasedatabase.app/",
        };
        IFirebaseClient _client;
        private string DriveSerialNumber = Common.GetDriveSerialNumber().ToGenerateLicenseKey();
         IDbConnection db = new SqlConnection("Server=.;Database=license;user id=sa;password=shc@1234");
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
            string query = "select * from Licenses where LicenseKey = @licenseKey";
            string licenseKey = textBox1.Text;
            if (string.IsNullOrEmpty(licenseKey)) {
                MessageBox.Show("Key is not Valid!", "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Warning);
                return;
            }
            var license = db.Query<dynamic>(query, new { licenseKey = licenseKey }).SingleOrDefault();
            if (license == null)
            {
                if (string.IsNullOrEmpty(licenseKey))
                {
                    MessageBox.Show("Not found key!", "Error",
                                                          MessageBoxButtons.OK,
                                                          MessageBoxIcon.Warning);
                    return;
                }
            }
          
            var param = new DynamicParameters();
            param.Add("LicenseKey", licenseKey);
            param.Add("HardwareId", DriveSerialNumber);
            string query2 = "update Licenses set HardwareId = @HardwareId where LicenseKey = @LicenseKey";
            db.Execute(query2, param);
            string query3 = "select * from Licenses where LicenseKey = @licenseKey";
            var license2 = db.Query<dynamic>(query3, new { licenseKey = licenseKey }).SingleOrDefault();

            if (license2.HardwareId == DriveSerialNumber && license.Status)
            {
                form1.Show();
                _me.Hide();
            }
            else
            {
                MessageBox.Show("Key is not Valid!", "Error",
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Warning);
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
                var configuration = ConfigurationManager.
OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                configuration.AppSettings.Settings["licenseKey"].Value = DriveSerialNumber;
                configuration.Save();
                ConfigurationManager.RefreshSection("appSettings");

                var id = DriveSerialNumber;
                var data = new
                {
                    Id = id,
                    UserName = id,
                    Password = DriveSerialNumber
                };
                SetResponse setResponse = _client.Set("Scalings", data);
                textBox1.Text = GetLicenseKey() + Common.TOKEN;

            }
            catch (Exception )
            {

                MessageBox.Show("Connection is not established", "Error",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
          
        }
        private void Register_Load(object sender, EventArgs e)
        {
            _me = (Form)sender;
            _client = new FireSharp.FirebaseClient(config);
            if (_client == null)
            {
                MessageBox.Show("Connection is not established", "Error",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Error);
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateLicense();
        }
    }
}
