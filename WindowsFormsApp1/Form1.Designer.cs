namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Online_Server = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Open_app = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.but_settings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.END = new System.Windows.Forms.Button();
            this.Start_App = new System.Windows.Forms.CheckBox();
            this.Open_ngrok = new System.Windows.Forms.Button();
            this.textMaster_Key = new System.Windows.Forms.TextBox();
            this.llaMaster_Key = new System.Windows.Forms.Label();
            this.textAPI = new System.Windows.Forms.TextBox();
            this.API_EX = new System.Windows.Forms.Label();
            this.TokenUUID = new System.Windows.Forms.Button();
            this.Save_Config = new System.Windows.Forms.Button();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textNameOpenWeb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textToken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Port = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.Label();
            this.NameFolderNgrok = new System.Windows.Forms.TextBox();
            this.NameFile = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textAPI_Icontrol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNum_Row_Url = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.RichTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.RichTextBox1.Location = new System.Drawing.Point(10, 132);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(472, 260);
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = "";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.Color.Black;
            this.TextBox1.Location = new System.Drawing.Point(10, 64);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(472, 56);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Online_Server
            // 
            this.Online_Server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Online_Server.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Online_Server.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Online_Server.Location = new System.Drawing.Point(10, 0);
            this.Online_Server.Name = "Online_Server";
            this.Online_Server.Size = new System.Drawing.Size(231, 58);
            this.Online_Server.TabIndex = 5;
            this.Online_Server.Text = "Online Server";
            this.Online_Server.UseVisualStyleBackColor = false;
            this.Online_Server.Click += new System.EventHandler(this.Online_Server_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Connection Port :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Open_app
            // 
            this.Open_app.BackColor = System.Drawing.Color.Teal;
            this.Open_app.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_app.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Open_app.Location = new System.Drawing.Point(241, 0);
            this.Open_app.Name = "Open_app";
            this.Open_app.Size = new System.Drawing.Size(126, 58);
            this.Open_app.TabIndex = 7;
            this.Open_app.Text = "Open App";
            this.Open_app.UseVisualStyleBackColor = false;
            this.Open_app.Click += new System.EventHandler(this.Open_app_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // but_settings
            // 
            this.but_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_settings.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_settings.Location = new System.Drawing.Point(370, 0);
            this.but_settings.Name = "but_settings";
            this.but_settings.Size = new System.Drawing.Size(115, 58);
            this.but_settings.TabIndex = 8;
            this.but_settings.Text = "Settings";
            this.but_settings.UseVisualStyleBackColor = false;
            this.but_settings.Click += new System.EventHandler(this.but_settings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textNum_Row_Url);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textAPI_Icontrol);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.END);
            this.panel1.Controls.Add(this.Start_App);
            this.panel1.Controls.Add(this.Open_ngrok);
            this.panel1.Controls.Add(this.textMaster_Key);
            this.panel1.Controls.Add(this.llaMaster_Key);
            this.panel1.Controls.Add(this.textAPI);
            this.panel1.Controls.Add(this.API_EX);
            this.panel1.Controls.Add(this.TokenUUID);
            this.panel1.Controls.Add(this.Save_Config);
            this.panel1.Controls.Add(this.radioButton10);
            this.panel1.Controls.Add(this.radioButton9);
            this.panel1.Controls.Add(this.radioButton8);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.textNameOpenWeb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textToken);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.text_Port);
            this.panel1.Controls.Add(this.Port);
            this.panel1.Controls.Add(this.NameFolderNgrok);
            this.panel1.Controls.Add(this.NameFile);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 449);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(-2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 446);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(175, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(136, 164);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 44);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.WordWrap = false;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // END
            // 
            this.END.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.END.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.END.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.END.Location = new System.Drawing.Point(385, 399);
            this.END.Name = "END";
            this.END.Size = new System.Drawing.Size(49, 39);
            this.END.TabIndex = 26;
            this.END.Text = "End";
            this.END.UseVisualStyleBackColor = false;
            this.END.Click += new System.EventHandler(this.END_Click);
            // 
            // Start_App
            // 
            this.Start_App.AutoSize = true;
            this.Start_App.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Start_App.ForeColor = System.Drawing.Color.Chartreuse;
            this.Start_App.Location = new System.Drawing.Point(11, 18);
            this.Start_App.Name = "Start_App";
            this.Start_App.Size = new System.Drawing.Size(125, 29);
            this.Start_App.TabIndex = 25;
            this.Start_App.Text = "Start App";
            this.Start_App.UseVisualStyleBackColor = true;
            // 
            // Open_ngrok
            // 
            this.Open_ngrok.BackColor = System.Drawing.Color.Navy;
            this.Open_ngrok.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_ngrok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Open_ngrok.Location = new System.Drawing.Point(11, 399);
            this.Open_ngrok.Name = "Open_ngrok";
            this.Open_ngrok.Size = new System.Drawing.Size(126, 36);
            this.Open_ngrok.TabIndex = 24;
            this.Open_ngrok.Text = "Open Ngrok";
            this.Open_ngrok.UseVisualStyleBackColor = false;
            this.Open_ngrok.Click += new System.EventHandler(this.Open_ngrok_Click);
            // 
            // textMaster_Key
            // 
            this.textMaster_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaster_Key.Location = new System.Drawing.Point(109, 194);
            this.textMaster_Key.Name = "textMaster_Key";
            this.textMaster_Key.Size = new System.Drawing.Size(366, 27);
            this.textMaster_Key.TabIndex = 23;
            // 
            // llaMaster_Key
            // 
            this.llaMaster_Key.AutoSize = true;
            this.llaMaster_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llaMaster_Key.Location = new System.Drawing.Point(1, 194);
            this.llaMaster_Key.Name = "llaMaster_Key";
            this.llaMaster_Key.Size = new System.Drawing.Size(56, 22);
            this.llaMaster_Key.TabIndex = 22;
            this.llaMaster_Key.Text = "Key :";
            // 
            // textAPI
            // 
            this.textAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAPI.Location = new System.Drawing.Point(109, 133);
            this.textAPI.Name = "textAPI";
            this.textAPI.Size = new System.Drawing.Size(366, 27);
            this.textAPI.TabIndex = 21;
            // 
            // API_EX
            // 
            this.API_EX.AutoSize = true;
            this.API_EX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.API_EX.Location = new System.Drawing.Point(-1, 136);
            this.API_EX.Name = "API_EX";
            this.API_EX.Size = new System.Drawing.Size(85, 22);
            this.API_EX.TabIndex = 20;
            this.API_EX.Text = "API Url :";
            // 
            // TokenUUID
            // 
            this.TokenUUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokenUUID.ForeColor = System.Drawing.Color.Red;
            this.TokenUUID.Location = new System.Drawing.Point(440, 399);
            this.TokenUUID.Name = "TokenUUID";
            this.TokenUUID.Size = new System.Drawing.Size(35, 39);
            this.TokenUUID.TabIndex = 19;
            this.TokenUUID.Text = "T";
            this.TokenUUID.UseVisualStyleBackColor = true;
            this.TokenUUID.Click += new System.EventHandler(this.TokenUUID_Click);
            // 
            // Save_Config
            // 
            this.Save_Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Save_Config.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Config.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_Config.Location = new System.Drawing.Point(152, 399);
            this.Save_Config.Name = "Save_Config";
            this.Save_Config.Size = new System.Drawing.Size(195, 49);
            this.Save_Config.TabIndex = 18;
            this.Save_Config.Text = "Save";
            this.Save_Config.UseVisualStyleBackColor = false;
            this.Save_Config.Click += new System.EventHandler(this.Save_Config_Click);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(196, 367);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(101, 29);
            this.radioButton10.TabIndex = 17;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Site 10";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(353, 342);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(89, 29);
            this.radioButton9.TabIndex = 16;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Site 9";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(196, 342);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(89, 29);
            this.radioButton8.TabIndex = 15;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Site 8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(59, 342);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(89, 29);
            this.radioButton7.TabIndex = 14;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Site 7";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(353, 316);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(89, 29);
            this.radioButton6.TabIndex = 13;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Site 6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(196, 316);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(89, 29);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Site 5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(59, 316);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(89, 29);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Site 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(353, 288);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 29);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Site 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(195, 288);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 29);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Site 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(59, 288);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 29);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Site 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textNameOpenWeb
            // 
            this.textNameOpenWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNameOpenWeb.Location = new System.Drawing.Point(246, 97);
            this.textNameOpenWeb.Name = "textNameOpenWeb";
            this.textNameOpenWeb.Size = new System.Drawing.Size(229, 27);
            this.textNameOpenWeb.TabIndex = 7;
            this.textNameOpenWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name Open Website :";
            // 
            // textToken
            // 
            this.textToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToken.Location = new System.Drawing.Point(109, 225);
            this.textToken.Name = "textToken";
            this.textToken.Size = new System.Drawing.Size(366, 27);
            this.textToken.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Token :";
            // 
            // text_Port
            // 
            this.text_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Port.Location = new System.Drawing.Point(246, 26);
            this.text_Port.Name = "text_Port";
            this.text_Port.Size = new System.Drawing.Size(115, 27);
            this.text_Port.TabIndex = 3;
            this.text_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(174, 27);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(59, 22);
            this.Port.TabIndex = 2;
            this.Port.Text = "Port :";
            // 
            // NameFolderNgrok
            // 
            this.NameFolderNgrok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFolderNgrok.Location = new System.Drawing.Point(246, 62);
            this.NameFolderNgrok.Name = "NameFolderNgrok";
            this.NameFolderNgrok.Size = new System.Drawing.Size(229, 27);
            this.NameFolderNgrok.TabIndex = 1;
            this.NameFolderNgrok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameFile
            // 
            this.NameFile.AutoSize = true;
            this.NameFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFile.Location = new System.Drawing.Point(2, 62);
            this.NameFile.Name = "NameFile";
            this.NameFile.Size = new System.Drawing.Size(189, 22);
            this.NameFile.TabIndex = 0;
            this.NameFile.Text = "NameFolder Ngrok :";
            this.NameFile.Click += new System.EventHandler(this.NameFile_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textAPI_Icontrol
            // 
            this.textAPI_Icontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAPI_Icontrol.Location = new System.Drawing.Point(109, 164);
            this.textAPI_Icontrol.Name = "textAPI_Icontrol";
            this.textAPI_Icontrol.Size = new System.Drawing.Size(366, 27);
            this.textAPI_Icontrol.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-4, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "MapPath :";
            // 
            // textNum_Row_Url
            // 
            this.textNum_Row_Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum_Row_Url.Location = new System.Drawing.Point(146, 255);
            this.textNum_Row_Url.Name = "textNum_Row_Url";
            this.textNum_Row_Url.Size = new System.Drawing.Size(61, 27);
            this.textNum_Row_Url.TabIndex = 30;
            this.textNum_Row_Url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Num Row Url :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(492, 446);
            this.Controls.Add(this.but_settings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Open_app);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Online_Server);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.RichTextBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Islam Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Online_Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Open_app;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button but_settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameFile;
        private System.Windows.Forms.TextBox textToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Port;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox NameFolderNgrok;
        private System.Windows.Forms.TextBox textNameOpenWeb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Save_Config;
        private System.Windows.Forms.Button TokenUUID;
        private System.Windows.Forms.TextBox textAPI;
        private System.Windows.Forms.Label API_EX;
        private System.Windows.Forms.TextBox textMaster_Key;
        private System.Windows.Forms.Label llaMaster_Key;
        private System.Windows.Forms.Button Open_ngrok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Start_App;
        private System.Windows.Forms.Button END;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textAPI_Icontrol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNum_Row_Url;
        private System.Windows.Forms.Label label6;
    }
}

