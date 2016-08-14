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
    public partial class frmUsuarios : Form
    {
        private Class.Connection conn;
        private string usuario, password, admin, funcion, usuarioU;
        public frmUsuarios()
        {
            InitializeComponent(); 
            conn = new Class.Connection();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgvLoad();
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked == true) { admin = "s"; }
            else { admin = "n"; }
        }

        private void chkPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPwd.Checked == true) { txtPassword.PasswordChar = '\0'; }
            else { txtPassword.PasswordChar = '*'; }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            funcion = "C";
            panel1.Enabled = true;
            usuario = txtUsuario.Text = "";
            password = txtPassword.Text = "";
            admin = "n";
            chkAdmin.Checked = false;
            chkPwd.Checked = false;
            btnNuevo.Enabled = btnModificar.Enabled = btnBorrar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            funcion = "U";
            panel1.Enabled = true;
            txtUsuario.Text = usuario;
            txtPassword.Text = password;
            switch (admin)
            {
                case "n":
                    chkAdmin.Checked = false;
                    break;
                case "s":
                    chkAdmin.Checked = true;
                    break;
            }
            chkPwd.Checked = false;
            btnNuevo.Enabled = btnModificar.Enabled = btnBorrar.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from usuarios where usuario='{0}';", usuario);
            conn.executeQuery(sql);
            dgvLoad();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsuarios.SelectedRows)
            {
                txtUsuario.Text = usuario = row.Cells[0].Value.ToString();
                txtPassword.Text = password = row.Cells[1].Value.ToString();
                admin = row.Cells[2].Value.ToString();
                switch (admin)
                {
                    case "n":
                        chkAdmin.Checked = false;
                        break;
                    case "s":
                        chkAdmin.Checked = true;
                        break;
                }
            }
        }

        private void dgvLoad()
        {
            dgvUsuarios.DataSource = conn.readTable("select * from usuarios;");
            panel1.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string sql = "";
            password = txtPassword.Text;
            switch (funcion)
            {
                case "C":
                    usuario = txtUsuario.Text;
                    sql = string.Format("insert into usuarios (usuario,password,admin) values ('{0}','{1}','{2}');", usuario, password, admin);
                    break;
                case "U":
                    usuarioU = txtUsuario.Text;
                    sql = string.Format("update usuarios set usuario='{0}',password='{1}',admin='{2}' where usuario='{3}';", usuarioU, password, admin, usuario);
                    usuario = usuarioU;
                    usuarioU = "";
                    break;
            }
            conn.executeQuery(sql);
            btnNuevo.Enabled = btnModificar.Enabled = btnBorrar.Enabled = true;
            dgvLoad();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            chkAdmin.Checked = false;
            chkPwd.Checked = false;
            btnNuevo.Enabled = btnModificar.Enabled = btnBorrar.Enabled = true;
            panel1.Enabled = false;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
