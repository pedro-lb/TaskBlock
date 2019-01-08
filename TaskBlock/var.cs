/*
   _____         _    ____  _            _    
 |_   _|_ _ ___| | _| __ )| | ___   ___| | __
   | |/ _` / __| |/ /  _ \| |/ _ \ / __| |/ /
   | | (_| \__ \   <| |_) | | (_) | (__|   < 
   |_|\__,_|___/_|\_\____/|_|\___/ \___|_|\_\
                                             
 Project started on 19/10/2014                        
*/
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBlock
{
    class var
    {
        public static RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public static string password = "root";
        public static string program = "";

        public static Form mainForm;
        public static Form passForm;

        public static bool executeAsAdmin = true;
        public static bool executeWithWin = false;

        public static bool block_iexplore = false;
        public static bool block_firefox = false;
        public static bool block_chrome = false;
        public static bool block_safari = false;
        public static bool block_opera = false;
        public static bool block_skype = false;

        public static bool block_baiduAntivirus = false;       
    }
}
