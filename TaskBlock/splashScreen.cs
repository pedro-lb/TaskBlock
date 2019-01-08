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
    public partial class splashScreen : Form
    {
        private int splashI = 0;

        public splashScreen()
        {
            InitializeComponent();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            this.BackColor = Color.IndianRed;
            this.TransparencyKey = Color.IndianRed;
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashI += 5;

            if (prgBar.Value < 100)
            {
                prgBar.Value += 5;
            }
            
            if (splashI == 140)
            {
                if (var.mainForm == null)
                    var.mainForm  = new mainForm();                
                var.mainForm.Show();
                this.Close();
            }        
        }
    }
}
