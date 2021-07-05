using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Configuration.heplers
{
    public static class Common
    {
        public static string TOKEN = "SHCLABTEM123456789987654321";
        public static bool ExecuteAsAdmin(string fileName)
        {
            using (Process process = new Process())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.UseShellExecute = true;
                startInfo.Verb = "runas";

                startInfo.FileName = fileName;
                //startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
                process.StartInfo = startInfo;
                try
                {
                    process.Start();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    return false;
                }
            } 
           
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "";
        }
        public static dynamic ReadFile(string path)
        {
            string value =  System.IO.File.ReadAllText(path);
            dynamic valueObj = Newtonsoft.Json.JsonConvert.DeserializeObject(value);
            return valueObj;
        }
        public static async Task<dynamic> ReadFileAsync(string path)
        {
            string value = await System.IO.File.ReadAllTextAsync(path);
            dynamic valueObj = Newtonsoft.Json.JsonConvert.DeserializeObject(value);
            return valueObj;
        }
        public static string UpdateFile(dynamic value)
        {
            var result = Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.Indented);
            return result;
        }
        public static bool WriteFile(string path, string value)
        {
            try
            {
                 System.IO.File.WriteAllText(path, value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> WriteFileAsync(string path, string value)
        {
            try
            {
                await System.IO.File.WriteAllTextAsync(path, value);
                return true;
            }
            catch
            {
                return false;
            }
        }
     
        public static string ToGenerateLicenseKey(this string number)
        {
            var ASCIIENC = new ASCIIEncoding();
            string strreturn;
            strreturn = Constants.vbNullString;
            var bytesourcetxt = ASCIIENC.GetBytes(number);
            var SHA1Hash = new SHA1CryptoServiceProvider();
            byte[] bytehash = SHA1Hash.ComputeHash(bytesourcetxt);
            foreach (byte b in bytehash)
                strreturn += b.ToString("X2");

            //string result = Regex.Replace(strreturn, @".{5}(?!$)", "$0-");
            return strreturn;
        }
        public static string GetDriveSerialNumber()
        {
            ManagementObjectSearcher moSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            string value = string.Empty;
            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                HardDrive hd = new HardDrive();  // User Defined Class
                hd.Model = wmi_HD["Model"].ToString();  //Model Number
                hd.Type = wmi_HD["InterfaceType"].ToString();  //Interface Type
                value = wmi_HD["SerialNumber"].ToString(); //Serial Number
            }
            return value;
        }
    }
}
