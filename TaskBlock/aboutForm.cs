﻿/*
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
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void aboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
