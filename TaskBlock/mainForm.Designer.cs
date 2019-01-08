namespace TaskBlock
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.statusImgON = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_Config = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_ChangeStatus = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.processTimer = new System.Windows.Forms.Timer(this.components);
            this.statusImgOFF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusImgON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusImgOFF)).BeginInit();
            this.SuspendLayout();
            // 
            // statusImgON
            // 
            this.statusImgON.Image = ((System.Drawing.Image)(resources.GetObject("statusImgON.Image")));
            this.statusImgON.Location = new System.Drawing.Point(12, 12);
            this.statusImgON.Name = "statusImgON";
            this.statusImgON.Size = new System.Drawing.Size(260, 253);
            this.statusImgON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusImgON.TabIndex = 2;
            this.statusImgON.TabStop = false;
            this.statusImgON.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 268);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(48, 16);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Status:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(66, 268);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(88, 16);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Desativado";
            // 
            // btn_Config
            // 
            this.btn_Config.Location = new System.Drawing.Point(15, 322);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(127, 25);
            this.btn_Config.TabIndex = 5;
            this.btn_Config.Text = "Configurações";
            this.btn_Config.UseVisualStyleBackColor = true;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // btn_About
            // 
            this.btn_About.Location = new System.Drawing.Point(15, 353);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(127, 25);
            this.btn_About.TabIndex = 6;
            this.btn_About.Text = "Sobre";
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Location = new System.Drawing.Point(145, 322);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(127, 25);
            this.btn_Minimize.TabIndex = 5;
            this.btn_Minimize.Text = "Minimizar";
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(145, 353);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(127, 25);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Fechar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_ChangeStatus
            // 
            this.btn_ChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeStatus.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangeStatus.Location = new System.Drawing.Point(15, 291);
            this.btn_ChangeStatus.Name = "btn_ChangeStatus";
            this.btn_ChangeStatus.Size = new System.Drawing.Size(257, 25);
            this.btn_ChangeStatus.TabIndex = 7;
            this.btn_ChangeStatus.Text = "Ativar";
            this.btn_ChangeStatus.UseVisualStyleBackColor = true;
            this.btn_ChangeStatus.Click += new System.EventHandler(this.btn_ChangeStatus_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.BalloonTipTitle = "TaskBlock";
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "TaskBlock";
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // processTimer
            // 
            this.processTimer.Interval = 50;
            this.processTimer.Tick += new System.EventHandler(this.processTimer_Tick);
            // 
            // statusImgOFF
            // 
            this.statusImgOFF.Image = ((System.Drawing.Image)(resources.GetObject("statusImgOFF.Image")));
            this.statusImgOFF.Location = new System.Drawing.Point(12, 12);
            this.statusImgOFF.Name = "statusImgOFF";
            this.statusImgOFF.Size = new System.Drawing.Size(260, 253);
            this.statusImgOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusImgOFF.TabIndex = 2;
            this.statusImgOFF.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 384);
            this.Controls.Add(this.btn_ChangeStatus);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.statusImgOFF);
            this.Controls.Add(this.statusImgON);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskBlock || Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusImgON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusImgOFF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox statusImgON;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_Config;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_ChangeStatus;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Timer processTimer;
        private System.Windows.Forms.PictureBox statusImgOFF;
    }
}