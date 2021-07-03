
namespace Configuration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_setting = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_service = new System.Windows.Forms.Button();
            this.button_driver = new System.Windows.Forms.Button();
            this.panel_weighingscale30kg = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.button_update30kg = new System.Windows.Forms.Button();
            this.button_Disconnect30kg = new System.Windows.Forms.Button();
            this.label_status30kg = new System.Windows.Forms.Label();
            this.button_Connect30kg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_weighing30 = new System.Windows.Forms.TextBox();
            this.comboBox_COM30kg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_weighingscale3kg = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button_update3kg = new System.Windows.Forms.Button();
            this.comboBox_BaudRate3kg = new System.Windows.Forms.ComboBox();
            this.textBox_weighing3 = new System.Windows.Forms.TextBox();
            this.button_Disconnect3kg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Status3kg = new System.Windows.Forms.Label();
            this.comboBox_COM3kg = new System.Windows.Forms.ComboBox();
            this.button_Connect3kg = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_setting.SuspendLayout();
            this.panel_weighingscale30kg.SuspendLayout();
            this.panel_weighingscale3kg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_setting
            // 
            this.panel_setting.Controls.Add(this.label1);
            this.panel_setting.Controls.Add(this.button_service);
            this.panel_setting.Controls.Add(this.button_driver);
            this.panel_setting.Location = new System.Drawing.Point(3, 1);
            this.panel_setting.Name = "panel_setting";
            this.panel_setting.Size = new System.Drawing.Size(197, 151);
            this.panel_setting.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Setup weighing scale";
            // 
            // button_service
            // 
            this.button_service.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_service.Location = new System.Drawing.Point(9, 99);
            this.button_service.Name = "button_service";
            this.button_service.Size = new System.Drawing.Size(181, 30);
            this.button_service.TabIndex = 1;
            this.button_service.Text = "Restart service";
            this.button_service.UseVisualStyleBackColor = true;
            this.button_service.Click += new System.EventHandler(this.button_service_Click);
            // 
            // button_driver
            // 
            this.button_driver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_driver.Location = new System.Drawing.Point(9, 53);
            this.button_driver.Name = "button_driver";
            this.button_driver.Size = new System.Drawing.Size(181, 29);
            this.button_driver.TabIndex = 0;
            this.button_driver.Text = "Install";
            this.button_driver.UseVisualStyleBackColor = true;
            this.button_driver.Click += new System.EventHandler(this.button_driver_Click);
            // 
            // panel_weighingscale30kg
            // 
            this.panel_weighingscale30kg.Controls.Add(this.label7);
            this.panel_weighingscale30kg.Controls.Add(this.comboBox_BaudRate);
            this.panel_weighingscale30kg.Controls.Add(this.button_update30kg);
            this.panel_weighingscale30kg.Controls.Add(this.button_Disconnect30kg);
            this.panel_weighingscale30kg.Controls.Add(this.label_status30kg);
            this.panel_weighingscale30kg.Controls.Add(this.button_Connect30kg);
            this.panel_weighingscale30kg.Controls.Add(this.label5);
            this.panel_weighingscale30kg.Controls.Add(this.label4);
            this.panel_weighingscale30kg.Controls.Add(this.textBox_weighing30);
            this.panel_weighingscale30kg.Controls.Add(this.comboBox_COM30kg);
            this.panel_weighingscale30kg.Controls.Add(this.label2);
            this.panel_weighingscale30kg.Location = new System.Drawing.Point(206, 1);
            this.panel_weighingscale30kg.Name = "panel_weighingscale30kg";
            this.panel_weighingscale30kg.Size = new System.Drawing.Size(418, 441);
            this.panel_weighingscale30kg.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(126, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Baud Rate:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Location = new System.Drawing.Point(220, 350);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(81, 29);
            this.comboBox_BaudRate.TabIndex = 10;
            // 
            // button_update30kg
            // 
            this.button_update30kg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update30kg.Location = new System.Drawing.Point(126, 388);
            this.button_update30kg.Name = "button_update30kg";
            this.button_update30kg.Size = new System.Drawing.Size(175, 30);
            this.button_update30kg.TabIndex = 3;
            this.button_update30kg.Text = "Update setting";
            this.button_update30kg.UseVisualStyleBackColor = true;
            this.button_update30kg.Click += new System.EventHandler(this.button_update30kg_Click);
            // 
            // button_Disconnect30kg
            // 
            this.button_Disconnect30kg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Disconnect30kg.Location = new System.Drawing.Point(309, 348);
            this.button_Disconnect30kg.Name = "button_Disconnect30kg";
            this.button_Disconnect30kg.Size = new System.Drawing.Size(99, 30);
            this.button_Disconnect30kg.TabIndex = 9;
            this.button_Disconnect30kg.Text = "Disconnect";
            this.button_Disconnect30kg.UseVisualStyleBackColor = true;
            this.button_Disconnect30kg.Click += new System.EventHandler(this.button_Disconnect30kg_Click);
            // 
            // label_status30kg
            // 
            this.label_status30kg.AutoSize = true;
            this.label_status30kg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_status30kg.ForeColor = System.Drawing.Color.Red;
            this.label_status30kg.Location = new System.Drawing.Point(13, 355);
            this.label_status30kg.Name = "label_status30kg";
            this.label_status30kg.Size = new System.Drawing.Size(107, 20);
            this.label_status30kg.TabIndex = 8;
            this.label_status30kg.Text = "Disconnected";
            this.label_status30kg.Click += new System.EventHandler(this.label_status30kg_Click);
            // 
            // button_Connect30kg
            // 
            this.button_Connect30kg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Connect30kg.Location = new System.Drawing.Point(307, 309);
            this.button_Connect30kg.Name = "button_Connect30kg";
            this.button_Connect30kg.Size = new System.Drawing.Size(101, 30);
            this.button_Connect30kg.TabIndex = 6;
            this.button_Connect30kg.Text = "Connect";
            this.button_Connect30kg.UseVisualStyleBackColor = true;
            this.button_Connect30kg.Click += new System.EventHandler(this.button_Connect30kg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(126, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "COM: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status: ";
            // 
            // textBox_weighing30
            // 
            this.textBox_weighing30.ForeColor = System.Drawing.Color.Green;
            this.textBox_weighing30.Location = new System.Drawing.Point(13, 38);
            this.textBox_weighing30.Multiline = true;
            this.textBox_weighing30.Name = "textBox_weighing30";
            this.textBox_weighing30.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_weighing30.Size = new System.Drawing.Size(397, 268);
            this.textBox_weighing30.TabIndex = 5;
            // 
            // comboBox_COM30kg
            // 
            this.comboBox_COM30kg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_COM30kg.FormattingEnabled = true;
            this.comboBox_COM30kg.Location = new System.Drawing.Point(220, 311);
            this.comboBox_COM30kg.Name = "comboBox_COM30kg";
            this.comboBox_COM30kg.Size = new System.Drawing.Size(81, 29);
            this.comboBox_COM30kg.TabIndex = 4;
            this.comboBox_COM30kg.SelectedIndexChanged += new System.EventHandler(this.comboBox_weighing30kg_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(177, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weighing scale 30kg";
            // 
            // panel_weighingscale3kg
            // 
            this.panel_weighingscale3kg.Controls.Add(this.label8);
            this.panel_weighingscale3kg.Controls.Add(this.button_update3kg);
            this.panel_weighingscale3kg.Controls.Add(this.comboBox_BaudRate3kg);
            this.panel_weighingscale3kg.Controls.Add(this.textBox_weighing3);
            this.panel_weighingscale3kg.Controls.Add(this.button_Disconnect3kg);
            this.panel_weighingscale3kg.Controls.Add(this.label3);
            this.panel_weighingscale3kg.Controls.Add(this.label_Status3kg);
            this.panel_weighingscale3kg.Controls.Add(this.comboBox_COM3kg);
            this.panel_weighingscale3kg.Controls.Add(this.button_Connect3kg);
            this.panel_weighingscale3kg.Controls.Add(this.label11);
            this.panel_weighingscale3kg.Controls.Add(this.label10);
            this.panel_weighingscale3kg.Location = new System.Drawing.Point(630, 1);
            this.panel_weighingscale3kg.Name = "panel_weighingscale3kg";
            this.panel_weighingscale3kg.Size = new System.Drawing.Size(418, 441);
            this.panel_weighingscale3kg.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(128, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Baud Rate:";
            // 
            // button_update3kg
            // 
            this.button_update3kg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update3kg.Location = new System.Drawing.Point(128, 388);
            this.button_update3kg.Name = "button_update3kg";
            this.button_update3kg.Size = new System.Drawing.Size(175, 30);
            this.button_update3kg.TabIndex = 5;
            this.button_update3kg.Text = "Update setting";
            this.button_update3kg.UseVisualStyleBackColor = true;
            this.button_update3kg.Click += new System.EventHandler(this.button_update3kg_Click);
            // 
            // comboBox_BaudRate3kg
            // 
            this.comboBox_BaudRate3kg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_BaudRate3kg.FormattingEnabled = true;
            this.comboBox_BaudRate3kg.Location = new System.Drawing.Point(222, 353);
            this.comboBox_BaudRate3kg.Name = "comboBox_BaudRate3kg";
            this.comboBox_BaudRate3kg.Size = new System.Drawing.Size(81, 29);
            this.comboBox_BaudRate3kg.TabIndex = 18;
            // 
            // textBox_weighing3
            // 
            this.textBox_weighing3.ForeColor = System.Drawing.Color.Green;
            this.textBox_weighing3.Location = new System.Drawing.Point(15, 38);
            this.textBox_weighing3.Multiline = true;
            this.textBox_weighing3.Name = "textBox_weighing3";
            this.textBox_weighing3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_weighing3.Size = new System.Drawing.Size(391, 268);
            this.textBox_weighing3.TabIndex = 6;
            // 
            // button_Disconnect3kg
            // 
            this.button_Disconnect3kg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Disconnect3kg.Location = new System.Drawing.Point(311, 351);
            this.button_Disconnect3kg.Name = "button_Disconnect3kg";
            this.button_Disconnect3kg.Size = new System.Drawing.Size(98, 30);
            this.button_Disconnect3kg.TabIndex = 17;
            this.button_Disconnect3kg.Text = "Disconnect";
            this.button_Disconnect3kg.UseVisualStyleBackColor = true;
            this.button_Disconnect3kg.Click += new System.EventHandler(this.button_Disconnect3kg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Weighing scale 3kg";
            // 
            // label_Status3kg
            // 
            this.label_Status3kg.AutoSize = true;
            this.label_Status3kg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Status3kg.ForeColor = System.Drawing.Color.Red;
            this.label_Status3kg.Location = new System.Drawing.Point(15, 358);
            this.label_Status3kg.Name = "label_Status3kg";
            this.label_Status3kg.Size = new System.Drawing.Size(107, 20);
            this.label_Status3kg.TabIndex = 16;
            this.label_Status3kg.Text = "Disconnected";
            this.label_Status3kg.Click += new System.EventHandler(this.label_Status3kg_Click);
            // 
            // comboBox_COM3kg
            // 
            this.comboBox_COM3kg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_COM3kg.FormattingEnabled = true;
            this.comboBox_COM3kg.Location = new System.Drawing.Point(222, 314);
            this.comboBox_COM3kg.Name = "comboBox_COM3kg";
            this.comboBox_COM3kg.Size = new System.Drawing.Size(81, 29);
            this.comboBox_COM3kg.TabIndex = 12;
            // 
            // button_Connect3kg
            // 
            this.button_Connect3kg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Connect3kg.Location = new System.Drawing.Point(309, 312);
            this.button_Connect3kg.Name = "button_Connect3kg";
            this.button_Connect3kg.Size = new System.Drawing.Size(101, 30);
            this.button_Connect3kg.TabIndex = 13;
            this.button_Connect3kg.Text = "Connect";
            this.button_Connect3kg.UseVisualStyleBackColor = true;
            this.button_Connect3kg.Click += new System.EventHandler(this.button_Connect3kg_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(15, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Status: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(128, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "COM: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 444);
            this.Controls.Add(this.panel_weighingscale3kg);
            this.Controls.Add(this.panel_weighingscale30kg);
            this.Controls.Add(this.panel_setting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_setting.ResumeLayout(false);
            this.panel_setting.PerformLayout();
            this.panel_weighingscale30kg.ResumeLayout(false);
            this.panel_weighingscale30kg.PerformLayout();
            this.panel_weighingscale3kg.ResumeLayout(false);
            this.panel_weighingscale3kg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_setting;
        private System.Windows.Forms.Button button_service;
        private System.Windows.Forms.Button button_driver;
        private System.Windows.Forms.Panel panel_weighingscale30kg;
        private System.Windows.Forms.Panel panel_weighingscale3kg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_update30kg;
        private System.Windows.Forms.ComboBox comboBox_COM30kg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_update3kg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_weighing30;
        private System.Windows.Forms.TextBox textBox_weighing3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Button button_Disconnect30kg;
        private System.Windows.Forms.Label label_status30kg;
        private System.Windows.Forms.Button button_Connect30kg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_BaudRate3kg;
        private System.Windows.Forms.Button button_Disconnect3kg;
        private System.Windows.Forms.Label label_Status3kg;
        private System.Windows.Forms.ComboBox comboBox_COM3kg;
        private System.Windows.Forms.Button button_Connect3kg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
    }
}

