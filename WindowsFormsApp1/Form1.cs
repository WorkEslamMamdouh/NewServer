using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using System.Windows.Forms;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Net.Http;
using RestSharp;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        delegate void UpdateTextBoxDelg(string text);
        UpdateTextBoxDelg myDelegate;
        private readonly HttpClient _client;
        public class Data_In_Html
        {
            public Config Config { get; set; }
            public Conns Conns { get; set; }
            public Http Http { get; set; }
            public Metrics Metrics { get; set; }
            public Root Root { get; set; }


        }
        public class Config
        {
            public string addr { get; set; }
            public bool inspect { get; set; }
        }

        public class Metrics
        {
            public Conns conns { get; set; }
            public Http http { get; set; }
        }

        public class Conns
        {
            public int count { get; set; }
            public double gauge { get; set; }
            public double rate1 { get; set; }
            public double rate5 { get; set; }
            public double rate15 { get; set; }
            public long p50 { get; set; }
            public double p90 { get; set; }  // Change data type to double
            public double p95 { get; set; }  // Change data type to double
            public long p99 { get; set; }
        }

        public class Http
        {
            public int count { get; set; }
            public double rate1 { get; set; }
            public double rate5 { get; set; }
            public double rate15 { get; set; }
            public long p50 { get; set; }
            public double p90 { get; set; }  // Change data type to double
            public double p95 { get; set; }  // Change data type to double
            public long p99 { get; set; }
        }

        public class Root
        {
            public string name { get; set; }
            public string ID { get; set; }
            public string uri { get; set; }
            public string public_url { get; set; }
            public string proto { get; set; }
            public Config config { get; set; }
            public Metrics metrics { get; set; }
        }

        public class WebConfig
        {
            public string NameFolder { get; set; }
            public string Name_Open_Website { get; set; }
            public bool StartApp { get; set; }
            public string Port { get; set; }
            public string Url_Api { get; set; }
            public string API_Icontrol { get; set; }
            public int Num_Row_Url { get; set; }
            public string Master_Key { get; set; }
            public string Token { get; set; }
            public bool Url_1 { get; set; }
            public bool Url_2 { get; set; }

            public bool Url_3 { get; set; }
            public bool Url_4 { get; set; }
            public bool Url_5 { get; set; }
            public bool Url_6 { get; set; }
            public bool Url_7 { get; set; }
            public bool Url_8 { get; set; }
            public bool Url_9 { get; set; }
            public bool Url_10 { get; set; }

        }

        public class UrlConfig
        {
            public string Url1 { get; set; }
            public string Url2 { get; set; }
            public string Url3 { get; set; }
            public string Url4 { get; set; }
            public string Url5 { get; set; }
            public string Url6 { get; set; }
            public string Url7 { get; set; }
            public string Url8 { get; set; }
            public string Url9 { get; set; }
            public string Url10 { get; set; }
        }

        public class Record
        {
            public string _id { get; set; }
            public string Url1 { get; set; }
            public string Url2 { get; set; }
            public string Url3 { get; set; }
            public string Url4 { get; set; }
            public string Url5 { get; set; }
            public string Url6 { get; set; }
            public string Url7 { get; set; }
            public string Url8 { get; set; }
            public string Url9 { get; set; }
            public string Url10 { get; set; }
        }

        public class I_Control
        {
            [JsonProperty("_id")]
            public string _id { get; set; }

            [JsonProperty("UUID_PC")]
            public string UUID_PC { get; set; }

            [JsonProperty("Url")]
            public string Url { get; set; }

            [JsonProperty("Remark")]
            public string Remark { get; set; }

            [JsonProperty("Status")]
            public string Status { get; set; }

            [JsonProperty("Block")]
            public string Block { get; set; }

            [JsonProperty("Custom")]
            public string Custom { get; set; }

            [JsonProperty("DateLastUpdate")]
            public string DateLastUpdate { get; set; }
        }



        public class DataJson
        {
            public Record record { get; set; }
        }
        public class BaseResponse
        {
            public bool IsSuccess { get; set; } = false;
            public string ErrorMessage { get; set; }
            public int StatusCode { get; set; }
            public object Response { get; set; }
        }


        public class I_ControlSystem
        {
            public List<I_Control> record { get; set; }
        }


        string urlServer = "";
        string Url_Ngrok = "";

        string Url_SiteWeb = "https://klzmtplewesognuog6bz8g.on.drv.tw/Site_Server/index1.html";

        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.UseSystemPasswordChar = false;
            myDelegate = new UpdateTextBoxDelg(UpdateTBox);
        }

        WebConfig config = new WebConfig();
        Record _AllDataJson = new Record();
        List<Record> _AllListdata = new List<Record>();

        string UUID = "";
        static bool IsInternetConnected()
        {
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = ping.Send("8.8.8.8", 1000); // Ping Google's DNS server
                    return reply.Status == IPStatus.Success;
                }
                catch
                {
                    return false; // Exception indicates no internet connection
                }
            }
        }

        public void GetWebConfig()
        {
            string jsonData = "";

            try
            {
                string filePath = Path.Combine(Application.StartupPath, "WebConfig.txt");

                if (File.Exists(filePath))
                {
                    string WebCon = File.ReadAllText(filePath);

                    config = JsonConvert.DeserializeObject<WebConfig>(WebCon);
                    // Your code using jsonData 
                    label1.Text = "Connection Port : " + config.Port + "";

                    text_Port.Text = config.Port;
                    Start_App.Checked = config.StartApp;
                    NameFolderNgrok.Text = config.NameFolder;
                    textNameOpenWeb.Text = config.Name_Open_Website;
                    textToken.Text = config.Token;
                    textAPI.Text = config.Url_Api;
                    textAPI_Icontrol.Text = config.API_Icontrol;
                    textNum_Row_Url.Text = config.Num_Row_Url.ToString();
                    textMaster_Key.Text = config.Master_Key;

                    radioButton1.Checked = config.Url_1;
                    radioButton2.Checked = config.Url_2;
                    radioButton3.Checked = config.Url_3;
                    radioButton4.Checked = config.Url_4;
                    radioButton5.Checked = config.Url_5;
                    radioButton6.Checked = config.Url_6;
                    radioButton7.Checked = config.Url_7;
                    radioButton8.Checked = config.Url_8;
                    radioButton9.Checked = config.Url_9;
                    radioButton10.Checked = config.Url_10;

                    string x = "";
                    x = config.Url_1 ? Url_SiteWeb = "https://klzmtplewesognuog6bz8g.on.drv.tw/Site_Server/index_" + config.Num_Row_Url + "_1.html" : "";
                    x = config.Url_2 ? Url_SiteWeb = "https://klzmtplewesognuog6bz8g.on.drv.tw/Site_Server/index_" + config.Num_Row_Url + "_2.html" : "";
                    x = config.Url_3 ? Url_SiteWeb = "https://klzmtplewesognuog6bz8g.on.drv.tw/Site_Server/index_" + config.Num_Row_Url + "_3.html" : "";
                    x = config.Url_4 ? Url_SiteWeb = "https://klzmtplewesognuog6bz8g.on.drv.tw/Site_Server/index_" + config.Num_Row_Url + "_4.html" : "";
                    x = config.Url_5 ? Url_SiteWeb = "https://klzmtplewesognuog6bz8g.on.drv.tw/Site_Server/index_" + config.Num_Row_Url + "_5.html" : "";
                    x = config.Url_6 ? Url_SiteWeb = "https://klzmtplewesognuog6bz8g.on.drv.tw/Site_Server/index_" + config.Num_Row_Url + "_6.html" : "";
                    x = config.Url_7 ? Url_SiteWeb = "https://klzmtplewesognuog6bz8g.on.drv.tw/Site_Server/index_" + config.Num_Row_Url + "_7.html" : "";
                    x = config.Url_8 ? Url_SiteWeb = "https://klzmtplewesognuog6bz8g.on.drv.tw/Site_Server/index_" + config.Num_Row_Url + "_8.html" : "";
                    x = config.Url_9 ? Url_SiteWeb = "https://klzmtplewesognuog6bz8g.on.drv.tw/Site_Server/index_" + config.Num_Row_Url + "_9.html" : "";
                    x = config.Url_10 ? Url_SiteWeb = "https://klzmtplewesognuog6bz8g.on.drv.tw/Site_Server/index_" + config.Num_Row_Url + "_10.html" : "";
                }
                else
                {
                    // Handle the case when the file doesn't exist
                }
            }
            catch (Exception)
            {
                config = new WebConfig();

            }



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UUID = GetSystemUUID();

            timer1.Interval = 60000; // 60000 milliseconds = 1 minute      
            RunApp();


        }

        public void Startprogram()
        {
            bool isConnected = IsInternetConnected();
            if (isConnected)
            {
                //MessageBox.Show("Connected");

                SetTimeoutAsync(1000, () =>
                {
                    if (config.NameFolder != null && config.NameFolder != "")
                    {
                        Online_Server_Host();
                    }
                });

            }
            else
            {
                TextBox1.Text = "no internet in computer network check the Internet...";
                //MessageBox.Show("no internet in computer network");

                timer1.Start();

            }
        }

        public bool CheckToken()
        {


            string inputString = UUID + "_619";
            byte[] inputBytes = Encoding.UTF8.GetBytes(inputString);
            string Token = Convert.ToBase64String(inputBytes);

            if (Token == config.Token)
            {
                return true;
            }
            return false;


        }

        public void RunApp()
        {
            GetWebConfig();

            if (config.StartApp)
            {
                if (!CheckToken())
                {
                    MessageBox.Show("Program Not Active Token Not Found");
                    TextBox1.Text = "Program Not Active Token Not Found";
                    return;
                }
                else
                {
                    Startprogram();

                }

            }
            else
            {
                panel1.Show();
                panel2.Show();
                textBox2.Focus();
                RichTextBox1.Text = "";
                TextBox1.Text = "Stop App";
                CheckProssSystem();
            }


        }

        private void Online_Server_Click(object sender, EventArgs e)
        {


            RunApp();

        }

        public void Online_Server_Host()
        {

            TextBox1.Text = "Logging Host...";
            RichTextBox1.Text = "";
            ActionNet(@"C:\" + config.NameFolder + @"\\ngrok.exe", "http " + config.Port + "");
            RichTextBox1.Focus();

            SetTimeoutAsync(3000, () =>
            {
                Get_Url_From_Server_In_Html();
            });


        }

        public string ActionNet(string file, string text)
        {
            Process Gstart = new Process();
            Gstart.StartInfo.FileName = file;
            Gstart.StartInfo.Arguments = text;
            Gstart.StartInfo.WorkingDirectory = @"C:\" + config.NameFolder + ""; // Set the working directory to "C:\NewNgrok"

            Gstart.StartInfo.RedirectStandardError = true;
            Gstart.StartInfo.RedirectStandardOutput = true;
            Gstart.StartInfo.UseShellExecute = false;

            Gstart.EnableRaisingEvents = true;

            Application.DoEvents();
            Gstart.StartInfo.CreateNoWindow = true;

            Gstart.ErrorDataReceived += Gstart_OutputData;
            Gstart.OutputDataReceived += Gstart_OutputData;

            Gstart.Start();
            Gstart.BeginErrorReadLine();
            Gstart.BeginOutputReadLine();

            return file;
        }

        public void UpdateTBox(string text)
        {
            RichTextBox1.AppendText(text + Environment.NewLine);
        }

        public void Gstart_OutputData(object sender, DataReceivedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(myDelegate, e.Data);
            }
            else
            {
                UpdateTBox(e.Data);
            }
        }

        public void Get_Url_From_Server_In_Html()
        {
            Process process = new Process();

            process.StartInfo.FileName = "Get_Url_From_Server_In_Html.bat";

            process.StartInfo.UseShellExecute = false;

            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            StreamReader reader = process.StandardOutput;

            string output = reader.ReadToEnd().ToString();

            process.WaitForExit();


            SetTimeoutAsync(3500, () =>
            {
                GetUrlFromHtml();
            });




        }

        public void GetUrlFromHtml()
        {
            Root Data_List = GetInHtmlData();
            if (Data_List == null)
            {
                TextBox1.Text = "There is Nothing";
                Url_Ngrok = "There is Nothing";
                timer1.Start();
            }
            else
            {
                TextBox1.Text = Data_List.public_url;
                Url_Ngrok = Data_List.public_url;
                timer1.Stop();
            }


            SetTimeoutAsync(2500, () =>
            {
                Get_All_DataJson();
            });
        }

        public Root GetInHtmlData()
        {


            string jsonData = "";

            try
            {
                string filePath = Path.Combine(Application.StartupPath, "Url_Server.html");

                if (File.Exists(filePath))
                {
                    jsonData = File.ReadAllText(filePath);

                    // Your code using jsonData
                }
                else
                {
                    // Handle the case when the file doesn't exist
                }
            }
            catch (Exception)
            {

                Root Data_ListNew = new Root();


                return Data_ListNew;
            }


            Root Data_List = JsonConvert.DeserializeObject<Root>(jsonData);


            return Data_List;

        }

        public async void Get_All_DataJson()
        {

            BaseResponse response = CallAPI("GetDataFrom", "SerUrl", null);

            if (response.IsSuccess)
            {
                _AllListdata = JsonConvert.DeserializeObject<List<Record>>(response.Response.ToString());
                _AllDataJson = _AllListdata[(config.Num_Row_Url - 1)];
                var urlConfigArray = _AllDataJson;
                if (_AllDataJson == null)
                {
                    urlServer = "";
                    Send_Url();
                }
                else
                {
                    try
                    {
                        string[] urls = new string[]
                        {
                                config.Url_1 ? urlConfigArray.Url1.Trim()  : "",
                                config.Url_2 ? urlConfigArray.Url2.Trim()  : "",
                                config.Url_3 ? urlConfigArray.Url3.Trim()  : "",
                                config.Url_4 ? urlConfigArray.Url4.Trim()  : "",
                                config.Url_5 ? urlConfigArray.Url5.Trim()  : "",
                                config.Url_6 ? urlConfigArray.Url6.Trim()  : "",
                                config.Url_7 ? urlConfigArray.Url7.Trim()  : "",
                                config.Url_8 ? urlConfigArray.Url8.Trim()  : "",
                                config.Url_9 ? urlConfigArray.Url9.Trim()  : "",
                                config.Url_10 ? urlConfigArray.Url10.Trim()  : ""
                        };

                        urlServer = urls.FirstOrDefault(url => !string.IsNullOrWhiteSpace(url));
                        if (urlServer == null)
                            urlServer = "";
                    }
                    catch
                    {
                        urlServer = "";
                    }

                    Send_Url();
                }

                SetTimeoutAsync(2500, () =>
                {
                    CheckProssSystem();

                });
            }
            else
            {
                // Handle the error here
                Console.WriteLine("Error: " + response.Response.ToString());
            }



        }

        public async void Send_Url()
        {
            if (Url_Ngrok.Trim() == "" || Url_Ngrok.Trim() == "There is Nothing")
            {
                return;
            }

            SetTimeoutAsync(2000, () =>
            {

                CreateBatchIcoApp();

            });

            if (urlServer.Trim() == Url_Ngrok.Trim())
            {
                return;
            }


            _AllDataJson.Url1 = config.Url_1 ? Url_Ngrok : _AllDataJson.Url1;
            _AllDataJson.Url2 = config.Url_2 ? Url_Ngrok : _AllDataJson.Url2;
            _AllDataJson.Url3 = config.Url_3 ? Url_Ngrok : _AllDataJson.Url3;
            _AllDataJson.Url4 = config.Url_4 ? Url_Ngrok : _AllDataJson.Url4;
            _AllDataJson.Url5 = config.Url_5 ? Url_Ngrok : _AllDataJson.Url5;
            _AllDataJson.Url6 = config.Url_6 ? Url_Ngrok : _AllDataJson.Url6;
            _AllDataJson.Url7 = config.Url_7 ? Url_Ngrok : _AllDataJson.Url7;
            _AllDataJson.Url8 = config.Url_8 ? Url_Ngrok : _AllDataJson.Url8;
            _AllDataJson.Url9 = config.Url_9 ? Url_Ngrok : _AllDataJson.Url9;
            _AllDataJson.Url10 = config.Url_10 ? Url_Ngrok : _AllDataJson.Url10;

            List<Record> Listdata = new List<Record>();
            if (_AllListdata != null)
            {
                Listdata = _AllListdata.Where(x => x._id != _AllDataJson._id).ToList();
            }

            Listdata.Add(_AllDataJson);

            string jsonContent = JsonConvert.SerializeObject(Listdata);

            BaseResponse response = CallAPI("SetDataFrom", "SerUrl", jsonContent);

            if (response.IsSuccess)
            {
                // Handle the error here
                timer1.Stop();
                Console.WriteLine("IsSuccess: " + response.Response.ToString());
            }
            else
            {
                // Handle the error here
                timer1.Start();
                Console.WriteLine("Error: " + response.Response.ToString());
            }


        }



        private void CreateBatchIcoApp()
        {
            // Specify the path for the batch file, including the file name and extension
            string batchFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), config.Name_Open_Website + ".bat");

            try
            {
                // Create a StreamWriter to write to the batch file
                using (StreamWriter sw = new StreamWriter(batchFilePath))
                {
                    // Write commands to the batch file 
                    sw.WriteLine("@echo off");
                    sw.WriteLine(@"START chrome " + Url_SiteWeb + "");
                    sw.WriteLine("exit");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static async Task SetTimeoutAsync(int millisecondsDelay, Action callback)
        {
            await Task.Delay(millisecondsDelay);
            callback?.Invoke();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            //ActionNet(@"C:\\Windows\\System32\\ipconfig", TextBox1.Text);
            //ActionNet(@"C:\\Windows\\System32\\cd C:\NewNgrok & ngrok http 88", TextBox1.Text);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private async void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Open_app_Click(object sender, EventArgs e)
        {

            string url = TextBox1.Text; // Replace with the desired URL
            try
            {
                if (config.StartApp)
                {
                    Process.Start(Url_SiteWeb);
                }
            }
            catch
            {

            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Startprogram();
            //MessageBox.Show("Start");
        }

        private void NameFile_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Save_Config_Click(object sender, EventArgs e)
        {
            config.Port = text_Port.Text;
            config.StartApp = Start_App.Checked;
            config.NameFolder = NameFolderNgrok.Text;
            config.Name_Open_Website = textNameOpenWeb.Text;
            config.Token = textToken.Text;
            config.Url_Api = textAPI.Text;
            config.API_Icontrol = textAPI_Icontrol.Text;
            config.Num_Row_Url = Convert.ToInt16(textNum_Row_Url.Text);
            config.Master_Key = textMaster_Key.Text;
            config.Url_1 = radioButton1.Checked;
            config.Url_2 = radioButton2.Checked;
            config.Url_3 = radioButton3.Checked;
            config.Url_4 = radioButton4.Checked;
            config.Url_5 = radioButton5.Checked;
            config.Url_6 = radioButton6.Checked;
            config.Url_7 = radioButton7.Checked;
            config.Url_8 = radioButton8.Checked;
            config.Url_9 = radioButton9.Checked;
            config.Url_10 = radioButton10.Checked;

            string data = JsonConvert.SerializeObject(config);

            string filePath = Path.Combine(Application.StartupPath, "WebConfig.txt");
            System.IO.File.WriteAllText(filePath, data);

            MessageBox.Show("Save Successful");
            panel1.Hide();
            GetWebConfig();
            End_Close();
            RunApp();
        }

        private void but_settings_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (panel1.Visible == true)
            {
                panel1.Hide();
                panel2.Hide();
            }
            else
            {
                panel1.Show();
                panel2.Show();
                textBox2.Focus();
            }
        }




        private void TokenUUID_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(UUID);

        }

        private void Open_ngrok_Click(object sender, EventArgs e)
        {
            Process.Start("https://dashboard.ngrok.com/login");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {


            if (textBox2.Text.Trim() == "619606")
            {
                panel2.Hide();
            }

        }

        private void END_Click(object sender, EventArgs e)
        {
            End_Close();
        }


        public void End_Close()
        {
            try
            {

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "taskkill",
                    Arguments = "/F /IM ngrok.exe",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // Create and start the process
                Process process = new Process { StartInfo = psi };
                process.Start();

                // Optionally, wait for the process to finish
                process.WaitForExit();

                // Optionally, read the process's output
                string output = process.StandardOutput.ReadToEnd();

                RichTextBox1.Text = "";
                TextBox1.Text = "Now it not work";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }



        public string GetSystemUUID()
        {
            string uuid = null;
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "wmic",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    Arguments = "csproduct get uuid"
                };

                using (Process process = new Process())
                {
                    process.StartInfo = processInfo;
                    process.Start();

                    // Read the standard output of the wmic command
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    if (string.IsNullOrEmpty(error))
                    {
                        // Extract the UUID from the output
                        int start = output.IndexOf("\n") + 1;
                        int end = output.LastIndexOf("\n");
                        if (start >= 0 && end > start)
                        {
                            uuid = output.Substring(start, end - start).Trim();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return uuid;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        public BaseResponse CallAPI(string action, string Name_txt, string jsonData)
        {

            string controller = decodedText(config.Master_Key);
            string APIUrl = decodedText(config.Url_Api);

            string CallUrl = APIUrl + controller + "/" + action;

            List<string> parameters = new List<string>();
            parameters.Add("Name_txt=" + Name_txt);

            if (jsonData != null)
            {
                parameters.Add("jsonData=" + jsonData);
            }


            CallUrl = CallUrl + GetDataparameters(parameters);


            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = client.GetStringAsync(CallUrl).Result;
                    BaseResponse response = JsonConvert.DeserializeObject<BaseResponse>(json);
                    return response;
                }
                catch
                {
                    BaseResponse _res = new BaseResponse();
                    return _res;
                }
            }

            BaseResponse res = new BaseResponse();
            return res;
        }

        public string GetDataparameters(List<string> parameters)
        {
            string param = "MapPath=" + config.API_Icontrol;
            parameters.Add(param);

            StringBuilder models = new StringBuilder();
            int falgfrist = 0;
            foreach (string item in parameters)
            {

                if (falgfrist == 0)
                {
                    models.Append("?" + item);
                }
                else
                {
                    models.Append("&" + item);
                }

                falgfrist = 1;
            }


            return models.ToString();
        }
        public string decodedText(string Text)
        {
            byte[] decodedBytes = Convert.FromBase64String(Text);
            string decodedString = Encoding.UTF8.GetString(decodedBytes);

            return decodedString.ToString();
        }


        public async void CheckProssSystem()
        {


            BaseResponse response = CallAPI("GetDataFrom", "I_System", null);


            if (response.IsSuccess)
            {
                string jsonResponse = response.Response.ToString();
                List<I_Control> _data = JsonConvert.DeserializeObject<List<I_Control>>(jsonResponse);
                if (_data != null)
                {
                    var _DataPc = _data.Where(x => x.UUID_PC == UUID).LastOrDefault();

                    if (_DataPc == null)
                    {
                        SetDataI_ControlSystem(_data);
                    }
                    else if (_DataPc.Block != null && _DataPc.Block != "false")
                    {
                        End_Close();
                    }
                    else
                    {
                        SetDataI_ControlSystem(_data);
                    }

                }
                else
                {
                    SetDataI_ControlSystem(_data);
                }


            }
            else
            {
                // Handle the error here
                Console.WriteLine("Error: " + response.Response.ToString());
            }



        }


        public async void SetDataI_ControlSystem(List<I_Control> _data)
        {
            List<I_Control> ListdataControl = new List<I_Control>();
            if (_data != null)
            {
                ListdataControl = _data.Where(x => x.UUID_PC != UUID).ToList();
            }

            I_Control dataControl = new I_Control();


            dataControl._id = Guid.NewGuid().ToString();
            dataControl.UUID_PC = UUID;
            dataControl.Url = TextBox1.Text;
            dataControl.Remark = GetNameSite() + " شغال علي  " + config.Name_Open_Website + " البرنامج ";
            dataControl.Status = config.StartApp == true ? "Start" : "Stop";
            dataControl.Custom = "Call " + config.Num_Row_Url + " Row For Get Url";
            dataControl.DateLastUpdate = DateTime.Now.ToString();
            dataControl.Block = "false";

            ListdataControl.Add(dataControl);
            string jsonContent = JsonConvert.SerializeObject(ListdataControl);

            BaseResponse response = CallAPI("SetDataFrom", "I_System", jsonContent);

            if (response.IsSuccess)
            {
                // Handle the error here
                Console.WriteLine("IsSuccess: " + response.Response.ToString());
            }
            else
            {
                // Handle the error here
                Console.WriteLine("Error: " + response.Response.ToString());
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CheckProssSystem();
        }
        public string GetNameSite()
        {
            if (radioButton1.Checked)
            {
                return radioButton1.Text;

            }
            else if (radioButton2.Checked)
            {
                return radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                return radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                return radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                return radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                return radioButton6.Text;
            }
            else if (radioButton7.Checked)
            {
                return radioButton7.Text;
            }
            else if (radioButton8.Checked)
            {
                return radioButton8.Text;
            }
            else if (radioButton9.Checked)
            {
                return radioButton9.Text;
            }
            else if (radioButton10.Checked)
            {
                return radioButton10.Text;
            }
            // Add similar conditions for other radio buttons as needed
            return "";
        }
    }
}
