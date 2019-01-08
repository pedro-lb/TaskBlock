namespace TaskBlock
{
    partial class splashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.splashImg = new System.Windows.Forms.PictureBox();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splashImg)).BeginInit();
            this.SuspendLayout();
            // 
            // splashTimer
            // 
            this.splashTimer.Enabled = true;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // splashImg
            // 
            this.splashImg.Image = ((System.Drawing.Image)(resources.GetObject("splashImg.Image")));
            this.splashImg.Location = new System.Drawing.Point(12, 12);
            this.splashImg.Name = "splashImg";
            this.splashImg.Size = new System.Drawing.Size(259, 253);
            this.splashImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.splashImg.TabIndex = 1;
            this.splashImg.TabStop = false;
            // 
            // prgBar
            // 
            this.prgBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgBar.Location = new System.Drawing.Point(0, 270);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(284, 25);
            this.prgBar.TabIndex = 2;
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(284, 295);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.splashImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.Load += new System.EventHandler(this.splashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splashImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer splashTimer;
        private System.Windows.Forms.PictureBox splashImg;
        private System.Windows.Forms.ProgressBar prgBar;
    }
}

