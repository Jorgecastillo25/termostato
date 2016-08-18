using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace termostato
{
    public partial class acercaDe : Form
    {
        private static acercaDe instancia = new acercaDe();
        private acercaDe()
        {
            InitializeComponent();
            #region OS
            if (IsWindows10()) { lblOS.Text += "Windows 10"; }
            else if (IsWindows81()) { lblOS.Text += "Windows 8.1"; }
            else if (IsWindows8()) { lblOS.Text += "Windows 8"; }
            else if (IsWindows7()) { lblOS.Text += "Windows 7"; }
            #endregion
        }

        public static acercaDe Instancia { get { return instancia; } }
        private void acercaDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
            this.MdiParent = null;
        }

        #region lel
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    lblFecha.Text = "Fecha y hora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        //}
        #endregion

        #region OS
        static bool IsWindows10()
        {
            var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            string productName = (string)reg.GetValue("ProductName");

            return productName.StartsWith("Windows 10");
        }
        static bool IsWindows8()
        {
            var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            string productName = (string)reg.GetValue("ProductName");
            if (productName.StartsWith("Windows 8.1") == false)
            {
                return productName.StartsWith("Windows 8");
            }
            else { return false; }
        }
        static bool IsWindows81()
        {
            var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            string productName = (string)reg.GetValue("ProductName");

            return productName.StartsWith("Windows 8.1");
        }
        static bool IsWindows7()
        {
            var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            string productName = (string)reg.GetValue("ProductName");

            return productName.StartsWith("Windows 7");
        }
        #endregion
    }
}
