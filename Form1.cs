using Configuration.heplers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Configuration
{
    public partial class Form1 : Form
    {
        private string root = String.Empty;
        string InputData30 = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.
        string InputData3 = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.
        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string
        private SerialPort SerialPort30kg;
        private SerialPort SerialPort3kg;
        Form _me = new Form();
        public Form1()
        {


            var envPath = Environment.CurrentDirectory;
            //root = ConfigurationManager.AppSettings["root"].ToString();

            SerialPort3kg = new SerialPort();
            SerialPort30kg = new SerialPort();
            InitializeComponent();

            // Khai báo hàm delegate bằng phương thức DataReceived của Object SerialPort;
            // Cái này khi có sự kiện nhận dữ liệu sẽ nhảy đến phương thức DataReceive
            // Nếu ko hiểu đoạn này bạn có thể tìm hiểu về Delegate, còn ko cứ COPY . Ko cần quan tâm
            SerialPort3kg.DataReceived += new SerialDataReceivedEventHandler(DataReceive3kg);
            SerialPort30kg.DataReceived += new SerialDataReceivedEventHandler(DataReceive30kg);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            comboBox_BaudRate3kg.Items.AddRange(BaudRate);
            comboBox_BaudRate.Items.AddRange(BaudRate);
            string[] Ports3 = { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15" };
            string[] Ports30 = { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15" };

            string[] allPorts3 = Ports3;
            string[] allPorts30 = Ports30;
            comboBox_COM3kg.Items.Clear();
            comboBox_COM30kg.Items.Clear();
            comboBox_COM3kg.DataSource = allPorts3; // Thêm vào listbox
            comboBox_COM30kg.DataSource = allPorts30; // Thêm vào listbox
            //DisplaySetting30kg(true);
            //DisplaySetting3kg(true);
        }

        private void DataReceive3kg(object obj, SerialDataReceivedEventArgs e)
        {
            InputData3 = SerialPort3kg.ReadExisting();
            if (InputData3 != String.Empty)
            {
                // txtIn.Text = InputData; // Ko dùng đc như thế này vì khác threads .
                SetText3kg(InputData3); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó.
            }

        }
        private void DataReceive30kg(object obj, SerialDataReceivedEventArgs e)
        {
            InputData30 = SerialPort30kg.ReadExisting();
            if (InputData30 != String.Empty)
            {
                // txtIn.Text = InputData; // Ko dùng đc như thế này vì khác threads .
                SetText30kg(InputData30); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó.
            }

        }
        // Hàm của em nó là ở đây. Đừng hỏi vì sao lại thế.
        private void SetText3kg(string text)
        {
            if (this.textBox_weighing3.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText3kg); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else this.textBox_weighing3.Text += text;
        }
        private void SetText30kg(string text)
        {
            if (this.textBox_weighing30.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText30kg); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else this.textBox_weighing30.Text += text;
        }
        public bool InstallDriverWeighingScale()
        {
            var rootPath = AppDomain.CurrentDomain.BaseDirectory;
            var path = "C:";
            var res = heplers.Common.ExecuteAsAdmin(@$"{path}\service\InstallDMRService.bat");

            if (res)
                MessageBox.Show("Install successfully!", "Install",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
            else
                MessageBox.Show("Install failded! Please try again!", "Install",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            return res;
        }
        // khoi dong lai service khi da update setting
        public bool InstallWeighingScale()
        {
            var rootPath = AppDomain.CurrentDomain.BaseDirectory;
            var path = "C:";
            var res = heplers.Common.ExecuteAsAdmin(@$"{path}\service\RestartDMRService.bat");
            if (res)
                MessageBox.Show("Restart successfully!", "Restart service",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
            else
                MessageBox.Show("Restart failded! Please try again!", "Restart service",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            return res;
        }
        private void button_driver_Click(object sender, EventArgs e)
        {
            InstallDriverWeighingScale();
        }

        private void button_service_Click(object sender, EventArgs e)
        {
            InstallWeighingScale();
        }
        private void MyForm_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized) this.Hide();
            //else this.Show();
        }

        // you could also restore the window with a
        // double click on the notify icon
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.Show();
            //this.WindowState = FormWindowState.Normal;
        }
        public bool UpdateWeighingScale30kg(string com)
        {
            var rootPath = AppDomain.CurrentDomain.BaseDirectory;
            var BaseDirectory = "C:";
            var path = @$"{BaseDirectory}\service\weighingScale30kg\appsettings.json";
            try
            {
                dynamic value = heplers.Common.ReadFile(path);
                var appsettings = value.AppSettings;
                appsettings["PortName"] = com;
                var update = heplers.Common.UpdateFile(value);
                var res = heplers.Common.WriteFile(path, update);
                if (res) { }
                //MessageBox.Show("Update successfully!", "Update settings",
                //                                MessageBoxButtons.OK,
                //                                MessageBoxIcon.Information);
                else
                    MessageBox.Show("Update failded! Please try again!", "Update settings",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                return res;
            }
            catch
            {
                MessageBox.Show("Update failded! Please try again!", "Update settings",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateWeighingScale3kg(string com)
        {
            var rootPath = AppDomain.CurrentDomain.BaseDirectory;
            var BaseDirectory = "C:";
            var path = @$"{BaseDirectory}\service\weighingScale3kg\appsettings.json";
            try
            {
                dynamic value = heplers.Common.ReadFile(path);
                var appsettings = value.AppSettings;
                appsettings["PortName"] = com;
                var update = heplers.Common.UpdateFile(value);
                var res = heplers.Common.WriteFile(path, update);
                if (res) { }
                //MessageBox.Show("Update successfully!", "Update settings",
                //                                MessageBoxButtons.OK,
                //                                MessageBoxIcon.Information);
                else
                    MessageBox.Show("Update failded! Please try again!", "Update settings",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                return res;
            }
            catch
            {
                MessageBox.Show("Update failded! Please try again!", "Update settings",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                return false;
            }
        }
        private void button_update30kg_Click(object sender, EventArgs e)
        {
            //var com = comboBox_COM30kg.SelectedItem.ToString();
            //UpdateWeighingScale30kg(com);
            //DisplaySetting30kg(false);
        }

        private void button_update3kg_Click(object sender, EventArgs e)
        {
            //var com = comboBox_COM3kg.SelectedItem.ToString();
            //UpdateWeighingScale3kg(com);
            //DisplaySetting3kg(false);

        }

        private void comboBox_weighing3kg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _me = (Form)sender;
            comboBox_BaudRate.SelectedIndex = 3;
            comboBox_BaudRate3kg.SelectedIndex = 3;

            comboBox_COM3kg.SelectedItem = "COM3"; // COM3
            comboBox_COM30kg.SelectedItem = "COM2"; // COM2
            new ToolTip().SetToolTip(this.button_addWebsite, "To add a website to communicate with the weighing scale");
            new ToolTip().SetToolTip(this.button_driver, "Install weighing scale service and weighing scale driver");
            new ToolTip().SetToolTip(this.button_About, "Zalo: 0865978241\nEmail: sales3.mrthanh@gmail.com");
            new ToolTip().SetToolTip(this.button_service, "If setting is ready, restart service");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!SerialPort30kg.IsOpen)
            {

                label_status30kg.Text = ("Disconnected");
                label_status30kg.ForeColor = Color.Red;
            }
            else if (SerialPort30kg.IsOpen)
            {

                label_status30kg.Text = ("Connected");
                label_status30kg.ForeColor = Color.Green;

            }


            if (!SerialPort3kg.IsOpen)
            {

                label_Status3kg.Text = ("Disconnected");
                label_Status3kg.ForeColor = Color.Red;
            }
            else if (SerialPort3kg.IsOpen)
            {

                label_Status3kg.Text = ("Connected");
                label_Status3kg.ForeColor = Color.Green;

            }
        }
        private void label_status30kg_Click(object sender, EventArgs e)
        {
        }

        private void label_Status3kg_Click(object sender, EventArgs e)
        {
        }

        private void button_Disconnect30kg_Click(object sender, EventArgs e)
        {
            SerialPort30kg.Close();
        }

        private void button_Disconnect3kg_Click(object sender, EventArgs e)
        {
            SerialPort3kg.Close();
        }

        private void button_Connect3kg_Click(object sender, EventArgs e)
        {
            if (comboBox_COM30kg.Text == comboBox_COM3kg.Text)
            {
                const string caption = "Warning";
                const string message = "Unable to select the same COM";
                var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Warning);
                return;
            }
            if (!SerialPort3kg.IsOpen)
            {
                SerialPort3kg.PortName = comboBox_COM3kg.Text;
                SerialPort3kg.BaudRate = Convert.ToInt32(comboBox_BaudRate3kg.Text);
                try
                {
                    SerialPort3kg.Open();
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    const string caption = "Warning";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Warning);
                }
            }

        }

        private void button_Connect30kg_Click(object sender, EventArgs e)
        {
            if (comboBox_COM30kg.Text == comboBox_COM3kg.Text)
            {
                const string caption = "Warning";
                const string message = "Unable to select the same COM";
                var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Warning);
                return;

            }
            if (!SerialPort30kg.IsOpen)
            {
                SerialPort30kg.PortName = comboBox_COM30kg.Text;
                SerialPort30kg.BaudRate = Convert.ToInt32(comboBox_BaudRate.Text);
                try
                {
                    SerialPort30kg.Open();
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    const string caption = "Warning";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Warning);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _me.Dispose();
            _me.Close();
            if (SerialPort30kg.IsOpen) SerialPort30kg.Close();
            if (SerialPort3kg.IsOpen) SerialPort3kg.Close();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SerialPort30kg.Dispose();
            SerialPort3kg.Dispose();
        }
        private void DisplaySetting30kg(bool isInitial = true)
        {
            var rootPath = AppDomain.CurrentDomain.BaseDirectory;
            var BaseDirectory = "C:";
            var path = @$"{BaseDirectory}\service\weighingScale30kg\appsettings.json";
            try
            {
                dynamic value = heplers.Common.ReadFile(path);
                var appsettings = value.AppSettings;
                var result = Newtonsoft.Json.JsonConvert.SerializeObject(appsettings, Newtonsoft.Json.Formatting.Indented);
                var portName = appsettings["PortName"];
                string message = "";
                if (this.SerialPort30kg.IsOpen)
                {
                    this.SerialPort30kg.Close();
                }
                if (isInitial == false)
                {
                    // this.textBox_weighing30.Text += "Successfully!";
                    // this.textBox_weighing30.Text += System.Environment.NewLine;

                    message = $"The port name has been changed to {portName}";
                    this.textBox_weighing30.Text += message;
                    this.textBox_weighing30.Text += System.Environment.NewLine;

                }
                else
                {
                    this.textBox_weighing30.Text = "";
                    message = $"The default port name is {portName}";
                    this.textBox_weighing30.Text += message;
                    this.textBox_weighing30.Text += System.Environment.NewLine;

                }
            }
            catch
            {
                MessageBox.Show("Not found the setting file!", "Display settings",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }
        private void DisplaySetting3kg(bool isInitial = true)
        {
            var rootPath = AppDomain.CurrentDomain.BaseDirectory;
            var BaseDirectory = "C:";
            var path = @$"{BaseDirectory}\service\weighingScale3kg\appsettings.json";
            try
            {
                dynamic value = heplers.Common.ReadFile(path);
                var appsettings = value.AppSettings;
                var result = Newtonsoft.Json.JsonConvert.SerializeObject(appsettings, Newtonsoft.Json.Formatting.Indented);
                var portName = appsettings["PortName"];
                string message = "";
                if (this.SerialPort3kg.IsOpen)
                {
                    this.SerialPort3kg.Close();
                }
                if (isInitial == false)
                {
                    //this.textBox_weighing3.Text += "Successfully!";
                    //this.textBox_weighing3.Text += System.Environment.NewLine;

                    message = $"The port name has been changed to {portName}";
                    this.textBox_weighing3.Text += message;
                    this.textBox_weighing3.Text += System.Environment.NewLine;

                }
                else
                {
                    this.textBox_weighing3.Text = "";
                    message = $"The default port name is {portName}";
                    this.textBox_weighing3.Text += message;
                    this.textBox_weighing3.Text += System.Environment.NewLine;

                }
            }
            catch
            {
                MessageBox.Show("Not found the setting file!", "Display settings",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }
        private void button_displaySetting30kg_Click(object sender, EventArgs e)
        {
            DisplaySetting30kg(false);
        }

        private void button_displaySetting3kg_Click(object sender, EventArgs e)
        {
            DisplaySetting3kg(false);
        }

        private void comboBox_COM3kg_SelectedIndexChanged(object sender, EventArgs e)
        {
            var com = comboBox_COM3kg.SelectedItem.ToString();
            UpdateWeighingScale3kg(com);
            DisplaySetting3kg(true);
        }
        private void comboBox_weighing30kg_SelectedIndexChanged(object sender, EventArgs e)
        {
            var com = comboBox_COM30kg.SelectedItem.ToString();
            UpdateWeighingScale30kg(com);
            DisplaySetting30kg(true);
        }
        private void button_About_Click(object sender, EventArgs e)
        {
            string content = "Zalo: 0865978241\nEmail: sales3.mrthanh@gmail.com";
            MessageBox.Show(content, "Infomation",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information);
        }

        private void button_addWebsite_Click(object sender, EventArgs e)
        {
            var prompt = new Form2();
            prompt.FormClosed += Form2_FormClosed;
            prompt.ShowDialog();

        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var BaseDirectory = "C:";
                var path = @$"{BaseDirectory}\service\signalrServer\appsettings.json";
                dynamic value = heplers.Common.ReadFile(path);
                var appsettings = value.AppSettings.Origins;
                var result = Newtonsoft.Json.JsonConvert.SerializeObject(appsettings, Newtonsoft.Json.Formatting.Indented);
                this.textBox_weighing30.Text = "";
                this.textBox_weighing30.Text += result;
                this.textBox_weighing30.Text += System.Environment.NewLine;
            }
            catch
            {
                MessageBox.Show("Not found the setting  file!", "Add website",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
          
        }
    }
}
