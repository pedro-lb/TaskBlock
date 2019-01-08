namespace TaskBlock
{
    partial class configForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configForm));
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btn_showPass = new System.Windows.Forms.Button();
            this.tbox_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.cbox_admin = new System.Windows.Forms.CheckBox();
            this.cbox_startWithWin = new System.Windows.Forms.CheckBox();
            this.btn_adcProg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox_firefox = new System.Windows.Forms.CheckBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.cbox_safari = new System.Windows.Forms.CheckBox();
            this.cbox_baiduAntivirus = new System.Windows.Forms.CheckBox();
            this.cbox_skype = new System.Windows.Forms.CheckBox();
            this.cbox_opera = new System.Windows.Forms.CheckBox();
            this.cbox_chrome = new System.Windows.Forms.CheckBox();
            this.cbox_iexplore = new System.Windows.Forms.CheckBox();
            this.tbProcess = new System.Windows.Forms.TextBox();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.btn_showPass);
            this.gb2.Controls.Add(this.tbox_pass);
            this.gb2.Controls.Add(this.label1);
            this.gb2.Location = new System.Drawing.Point(16, 15);
            this.gb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb2.Name = "gb2";
            this.gb2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb2.Size = new System.Drawing.Size(896, 55);
            this.gb2.TabIndex = 2;
            this.gb2.TabStop = false;
            this.gb2.Text = "Senha";
            // 
            // btn_showPass
            // 
            this.btn_showPass.Location = new System.Drawing.Point(793, 19);
            this.btn_showPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_showPass.Name = "btn_showPass";
            this.btn_showPass.Size = new System.Drawing.Size(91, 25);
            this.btn_showPass.TabIndex = 2;
            this.btn_showPass.Text = "Mostrar";
            this.btn_showPass.UseVisualStyleBackColor = true;
            this.btn_showPass.Click += new System.EventHandler(this.btn_showPass_Click);
            // 
            // tbox_pass
            // 
            this.tbox_pass.Location = new System.Drawing.Point(137, 20);
            this.tbox_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbox_pass.Name = "tbox_pass";
            this.tbox_pass.Size = new System.Drawing.Size(648, 22);
            this.tbox_pass.TabIndex = 1;
            this.tbox_pass.Text = "root";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha atual:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(16, 428);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(896, 31);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(16, 464);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(896, 31);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Fechar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.cbox_admin);
            this.gb3.Controls.Add(this.cbox_startWithWin);
            this.gb3.Location = new System.Drawing.Point(16, 366);
            this.gb3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb3.Name = "gb3";
            this.gb3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb3.Size = new System.Drawing.Size(896, 55);
            this.gb3.TabIndex = 1;
            this.gb3.TabStop = false;
            this.gb3.Text = "Outros";
            // 
            // cbox_admin
            // 
            this.cbox_admin.AutoSize = true;
            this.cbox_admin.Checked = true;
            this.cbox_admin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbox_admin.Enabled = false;
            this.cbox_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_admin.Location = new System.Drawing.Point(455, 23);
            this.cbox_admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_admin.Name = "cbox_admin";
            this.cbox_admin.Size = new System.Drawing.Size(311, 24);
            this.cbox_admin.TabIndex = 1;
            this.cbox_admin.Text = "Sempre executar como administrador";
            this.cbox_admin.UseVisualStyleBackColor = true;
            // 
            // cbox_startWithWin
            // 
            this.cbox_startWithWin.AutoSize = true;
            this.cbox_startWithWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_startWithWin.Location = new System.Drawing.Point(12, 23);
            this.cbox_startWithWin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_startWithWin.Name = "cbox_startWithWin";
            this.cbox_startWithWin.Size = new System.Drawing.Size(297, 24);
            this.cbox_startWithWin.TabIndex = 0;
            this.cbox_startWithWin.Text = "Iniciar o TaskBlock com o Windows";
            this.cbox_startWithWin.UseVisualStyleBackColor = true;
            this.cbox_startWithWin.CheckedChanged += new System.EventHandler(this.cbox_startWithWin_CheckedChanged);
            // 
            // btn_adcProg
            // 
            this.btn_adcProg.Location = new System.Drawing.Point(717, 245);
            this.btn_adcProg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_adcProg.Name = "btn_adcProg";
            this.btn_adcProg.Size = new System.Drawing.Size(171, 28);
            this.btn_adcProg.TabIndex = 0;
            this.btn_adcProg.Text = "Adicionar Novo";
            this.btn_adcProg.UseVisualStyleBackColor = true;
            this.btn_adcProg.Click += new System.EventHandler(this.btn_adcProg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(8, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(880, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "_________________________________________________________________________________" +
    "____________________________";
            // 
            // cbox_firefox
            // 
            this.cbox_firefox.AutoSize = true;
            this.cbox_firefox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_firefox.Location = new System.Drawing.Point(455, 23);
            this.cbox_firefox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_firefox.Name = "cbox_firefox";
            this.cbox_firefox.Size = new System.Drawing.Size(140, 24);
            this.cbox_firefox.TabIndex = 2;
            this.cbox_firefox.Text = "Mozilla Firefox";
            this.cbox_firefox.UseVisualStyleBackColor = true;
            this.cbox_firefox.CheckedChanged += new System.EventHandler(this.cbox_firefox_CheckedChanged);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.tbProcess);
            this.gb1.Controls.Add(this.cbox_safari);
            this.gb1.Controls.Add(this.cbox_baiduAntivirus);
            this.gb1.Controls.Add(this.cbox_skype);
            this.gb1.Controls.Add(this.cbox_opera);
            this.gb1.Controls.Add(this.cbox_chrome);
            this.gb1.Controls.Add(this.cbox_iexplore);
            this.gb1.Controls.Add(this.cbox_firefox);
            this.gb1.Controls.Add(this.label7);
            this.gb1.Controls.Add(this.btn_adcProg);
            this.gb1.Location = new System.Drawing.Point(16, 78);
            this.gb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb1.Size = new System.Drawing.Size(896, 281);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "Programas a serem eliminados";
            // 
            // cbox_safari
            // 
            this.cbox_safari.AutoSize = true;
            this.cbox_safari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_safari.Location = new System.Drawing.Point(455, 55);
            this.cbox_safari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_safari.Name = "cbox_safari";
            this.cbox_safari.Size = new System.Drawing.Size(75, 24);
            this.cbox_safari.TabIndex = 2;
            this.cbox_safari.Text = "Safari";
            this.cbox_safari.UseVisualStyleBackColor = true;
            this.cbox_safari.CheckedChanged += new System.EventHandler(this.cbox_safari_CheckedChanged);
            // 
            // cbox_baiduAntivirus
            // 
            this.cbox_baiduAntivirus.AutoSize = true;
            this.cbox_baiduAntivirus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_baiduAntivirus.Location = new System.Drawing.Point(12, 119);
            this.cbox_baiduAntivirus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_baiduAntivirus.Name = "cbox_baiduAntivirus";
            this.cbox_baiduAntivirus.Size = new System.Drawing.Size(144, 24);
            this.cbox_baiduAntivirus.TabIndex = 2;
            this.cbox_baiduAntivirus.Text = "Baidu Antivirus";
            this.cbox_baiduAntivirus.UseVisualStyleBackColor = true;
            this.cbox_baiduAntivirus.CheckedChanged += new System.EventHandler(this.cbox_baiduAntivirus_CheckedChanged);
            // 
            // cbox_skype
            // 
            this.cbox_skype.AutoSize = true;
            this.cbox_skype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_skype.Location = new System.Drawing.Point(455, 87);
            this.cbox_skype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_skype.Name = "cbox_skype";
            this.cbox_skype.Size = new System.Drawing.Size(76, 24);
            this.cbox_skype.TabIndex = 2;
            this.cbox_skype.Text = "Skype";
            this.cbox_skype.UseVisualStyleBackColor = true;
            this.cbox_skype.CheckedChanged += new System.EventHandler(this.cbox_skype_CheckedChanged);
            // 
            // cbox_opera
            // 
            this.cbox_opera.AutoSize = true;
            this.cbox_opera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_opera.Location = new System.Drawing.Point(12, 87);
            this.cbox_opera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_opera.Name = "cbox_opera";
            this.cbox_opera.Size = new System.Drawing.Size(77, 24);
            this.cbox_opera.TabIndex = 2;
            this.cbox_opera.Text = "Opera";
            this.cbox_opera.UseVisualStyleBackColor = true;
            this.cbox_opera.CheckedChanged += new System.EventHandler(this.cbox_opera_CheckedChanged);
            // 
            // cbox_chrome
            // 
            this.cbox_chrome.AutoSize = true;
            this.cbox_chrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_chrome.Location = new System.Drawing.Point(12, 55);
            this.cbox_chrome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_chrome.Name = "cbox_chrome";
            this.cbox_chrome.Size = new System.Drawing.Size(148, 24);
            this.cbox_chrome.TabIndex = 2;
            this.cbox_chrome.Text = "Google Chrome";
            this.cbox_chrome.UseVisualStyleBackColor = true;
            this.cbox_chrome.CheckedChanged += new System.EventHandler(this.cbox_chrome_CheckedChanged);
            // 
            // cbox_iexplore
            // 
            this.cbox_iexplore.AutoSize = true;
            this.cbox_iexplore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_iexplore.Location = new System.Drawing.Point(12, 23);
            this.cbox_iexplore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_iexplore.Name = "cbox_iexplore";
            this.cbox_iexplore.Size = new System.Drawing.Size(154, 24);
            this.cbox_iexplore.TabIndex = 2;
            this.cbox_iexplore.Text = "Internet Explorer";
            this.cbox_iexplore.UseVisualStyleBackColor = true;
            this.cbox_iexplore.CheckedChanged += new System.EventHandler(this.cbox_iexplore_CheckedChanged);
            // 
            // tbProcess
            // 
            this.tbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProcess.Location = new System.Drawing.Point(12, 248);
            this.tbProcess.Name = "tbProcess";
            this.tbProcess.Size = new System.Drawing.Size(698, 24);
            this.tbProcess.TabIndex = 10;
            this.tbProcess.Text = "Nome do processo";
            this.tbProcess.Click += new System.EventHandler(this.tbProcess_Click);
            // 
            // configForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 506);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "configForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskBlock || Configurações";
            this.Load += new System.EventHandler(this.configForm_Load);
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox tbox_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_showPass;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.CheckBox cbox_admin;
        private System.Windows.Forms.CheckBox cbox_startWithWin;
        private System.Windows.Forms.Button btn_adcProg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbox_firefox;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.CheckBox cbox_safari;
        private System.Windows.Forms.CheckBox cbox_baiduAntivirus;
        private System.Windows.Forms.CheckBox cbox_skype;
        private System.Windows.Forms.CheckBox cbox_opera;
        private System.Windows.Forms.CheckBox cbox_chrome;
        private System.Windows.Forms.CheckBox cbox_iexplore;
        private System.Windows.Forms.TextBox tbProcess;
    }
}