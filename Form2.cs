using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (!(this.textBox_website.Text.StartsWith(@"http://") || this.textBox_website.Text.StartsWith(@"https://")))
            {
                MessageBox.Show("Invalid URL!", "Warning",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                return;
            }
            this.UpdateSettings();
            this.Close();
        }
        public bool UpdateSettings()
        {
         
            try
            {
                string path = @"C:\service\signalrServer\appsettings.json";
                string json = File.ReadAllText(path);
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                var Origins = new string[] { this.textBox_website.Text };
                JArray jsonVal = JArray.FromObject(Origins) as JArray;
                jsonObj["AppSettings"]["Origins"] = jsonVal;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, output);
                return true;
            }
            catch
            {
                MessageBox.Show("Update failded! Please try again!", "Update settings",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
