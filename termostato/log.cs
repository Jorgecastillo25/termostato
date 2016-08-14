using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace termostato
{
    public partial class log : Form
    {
        private Class.Connection conn;
        private string usuario, password;
        private int lel;
        public log()
        {
            InitializeComponent();
            conn = new Class.Connection();
        }

        private void log_Load(object sender, EventArgs e)
        {
            lel = 0;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text.Trim();
            password = txtPassword.Text.Trim();
            DataRow row = conn.readRow(string.Format("select admin from usuarios where usuario='{0}' and password='{1}';", usuario, password));
            if (conn.IsRowEmpty(row))
            {
                lel = 0;
                MessageBox.Show("Nombre de usuario o contraseña no válidos.");
            }
            else
            {
                Inicio.usuario = this.usuario;
                Inicio.admin = row[0].ToString(); // n = nel, s = simon
                lel = 1;
                MessageBox.Show(string.Format("Bienvenido usuario: {0}.", usuario));
                this.Close();
            }
        }

        private void chkPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPwd.Checked == true) { txtPassword.PasswordChar = '\0'; }
            else { txtPassword.PasswordChar = '*'; }
        }

        private void general_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnLogIn_Click(sender, e);
            }
        }

        private void log_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                switch (lel)
                {
                    case 0:
                        Application.Exit();
                        break;
                    default:
                        lel++;
                        break;
                }
            }
            catch (Exception ex) { }
        }
    }
}
