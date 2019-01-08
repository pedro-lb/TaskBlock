/*
   _____         _    ____  _            _    
 |_   _|_ _ ___| | _| __ )| | ___   ___| | __
   | |/ _` / __| |/ /  _ \| |/ _ \ / __| |/ /
   | | (_| \__ \   <| |_) | | (_) | (__|   < 
   |_|\__,_|___/_|\_\____/|_|\___/ \___|_|\_\
                                             
 Project started on 19/10/2014                        
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBlock
{
    public partial class mainForm : Form
    {
        processManagement process = new processManagement();
        private Form aboutForm;
        private Form configForm;
        public bool active;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            active = false;            
        }

        private void btn_ChangeStatus_Click(object sender, EventArgs e)
        {
            if (active)
            {
                active = false;
                lbl_status.ForeColor = Color.Red;
                lbl_status.Text = "Desativado";
                btn_ChangeStatus.Text = "Ativar";
                processTimer.Enabled = false;
                statusImgOFF.Visible = true;
                statusImgON.Visible = false;
            }
            else
            {
                active = true;
                lbl_status.ForeColor = Color.Green;
                lbl_status.Text = "Ativado";
                btn_ChangeStatus.Text = "Desativar";
                processTimer.Enabled = true;
                statusImgOFF.Visible = false;
                statusImgON.Visible = true;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            if (aboutForm == null)
                aboutForm = new aboutForm();
            aboutForm.ShowDialog();
        }

        public void minimizeToTray()
        {
            if (Visible)
            {
                MessageBox.Show("A senha é " + var.password + ". Use ela para maximizar o programa.", "TaskBlock | Minimizar");
                this.Hide();
                this.ShowInTaskbar = false;
                trayIcon.Visible = true;
                trayIcon.BalloonTipText = "TaskBlock está minimizado. Dê dois cliques no ícone para restaurar.";
                trayIcon.ShowBalloonTip(500);
            }
        }

        public void maximize()
        {
            this.Show();
            this.ShowInTaskbar = true;
            trayIcon.Visible = false;
        }

        public void askForPassword()
        {
            if (var.passForm == null)
                var.passForm = new passForm();
            var.passForm.ShowDialog();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            minimizeToTray();
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            askForPassword();
        }

        private void processTimer_Tick(object sender, EventArgs e)
        {
            process.KillProcesses();                
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            if (configForm == null)
                configForm = new configForm();
            configForm.ShowDialog();
        }

        public void startWithWindows()
        {

        }
    }

    class processManagement
    {
        public void KillProcesses()
        {                        
            try
            {
                //Baidu Antivirus
                if (var.block_baiduAntivirus)
                    foreach (Process proc in Process.GetProcessesByName("bavtray"))
                    {
                        proc.Kill();
                    }
                //Internet Explorer
                if (var.block_iexplore)
                    foreach (Process proc in Process.GetProcessesByName("iexplore"))
                    {
                        proc.Kill();
                    }
                //Mozilla Firefox
                if (var.block_firefox)
                    foreach (Process proc in Process.GetProcessesByName("firefox"))
                    {
                        proc.Kill();
                    }
                //Google Chrome
                if (var.block_chrome)
                    foreach (Process proc in Process.GetProcessesByName("chrome"))
                    {
                        proc.Kill();
                    }
                //Safari
                if (var.block_safari)
                    foreach (Process proc in Process.GetProcessesByName("safari"))
                    {
                        proc.Kill();
                    }
                //Opera
                if (var.block_opera)
                    foreach (Process proc in Process.GetProcessesByName("opera"))
                    {
                        proc.Kill();
                    }
                //Skype
                if (var.block_skype)
                    foreach (Process proc in Process.GetProcessesByName("skype"))
                    {
                        proc.Kill();
                    }
                //Custom
                foreach (Process proc in Process.GetProcessesByName(var.program))
                    proc.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
