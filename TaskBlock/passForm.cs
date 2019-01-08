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
    public partial class passForm : Form
    {
        public passForm()
        {
            InitializeComponent();
        }

        private void passForm_Load(object sender, EventArgs e)
        {
            tbox_pass.PasswordChar = '•';
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            var.passForm = null;
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            login();
        }

        private void passForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var.passForm = null;
        }

        private void passForm_KeyDown(object sender, KeyEventArgs e)
        {      
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                login();
        }

        public void login()
        {
            if (tbox_pass.Text.Equals("") && tbox_pass.Text.Equals(" ") && tbox_pass.Text.Equals("   "))
            {
                MessageBox.Show("Senha incorreta! Digite novamente.");
                tbox_pass.Text = "";
            }
            else
            {
                if (tbox_pass.Text.Equals(var.password))
                {
                    if (var.mainForm == null)
                        var.mainForm = new mainForm();
                    var.mainForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha incorreta! Digite novamente.");
                    tbox_pass.Text = "";
                }                    
            }
        }
    }
}
