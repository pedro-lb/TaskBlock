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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBlock
{
    public partial class configForm : Form
    {
        private bool showPass = false;

        public configForm()
        {
            InitializeComponent();
        }

        private void configForm_Load(object sender, EventArgs e)
        {
            tbox_pass.PasswordChar = '•';

            if (var.rk.GetValue("TaskBlock") == null)
            {
                cbox_startWithWin.Checked = false;
                var.executeWithWin = false;
            }                
            else
            {
                cbox_startWithWin.Checked = true;
                var.executeWithWin = true;
            }                
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var.password = tbox_pass.Text;

            if (var.executeWithWin)
                var.rk.SetValue("TaskBlock", Application.ExecutablePath.ToString());
            else
                var.rk.DeleteValue("TaskBlock", false);

            this.Close();
        }

        private void cbox_startWithWin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_startWithWin.Checked)
                var.executeWithWin = true;
            else
                var.executeWithWin = false;
        }

        private void cbox_iexplore_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_iexplore.Checked)
                var.block_iexplore = true;
            else
                var.block_iexplore = false;
        }

        private void cbox_firefox_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_firefox.Checked)
                var.block_firefox = true;
            else
                var.block_firefox = false;
        }

        private void cbox_chrome_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_chrome.Checked)
                var.block_chrome = true;
            else
                var.block_chrome = false;
        }

        private void cbox_safari_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_safari.Checked)
                var.block_safari = true;
            else
                var.block_safari = false;
        }

        private void cbox_opera_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_opera.Checked)
                var.block_opera = true;
            else
                var.block_opera = false;
        }

        private void cbox_skype_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_skype.Checked)
                var.block_skype = true;
            else
                var.block_skype = false;
        }

        private void cbox_baiduAntivirus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_baiduAntivirus.Checked)
                var.block_baiduAntivirus = true;
            else
                var.block_baiduAntivirus = false;
        }

        private void btn_showPass_Click(object sender, EventArgs e)
        {
            if (showPass)
            {
                showPass = false;
                tbox_pass.PasswordChar = '•';
            }
            else 
            {
                showPass = true;
                tbox_pass.PasswordChar = '\0';
            }
        }

        private void tbProcess_Click(object sender, EventArgs e)
        {
            if (tbProcess.Text.Equals("Nome do processo"))
                tbProcess.Text = "";
        }

        private void btn_adcProg_Click(object sender, EventArgs e)
        {
            if (!tbProcess.Text.Equals("Nome do processo") && !tbProcess.Text.Equals(""))
            {
                var.program = tbProcess.Text;
                MessageBox.Show("Programa adicionado com sucesso !", "TaskBlock | Adicionar Programa");
            }
        }
    }
}
