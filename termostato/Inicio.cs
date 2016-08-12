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
    public partial class Inicio : Form
    {
        public static string usuario, admin;
        public Inicio()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            this.MdiChildren.OfType<Form>().ToList().ForEach(x => x.Close());
            log login = new log();
            login.ShowDialog();
            login.Close();
            usuarioToolStripMenuItem.Text = string.Format("Usuario: {0}", usuario);
            switch (admin)
            {
                case "n":
                    cRUDToolStripMenuItem.Visible = cRUDToolStripMenuItem.Enabled = toolStripSeparator1.Visible = false;
                    break;
                case "s":
                    cRUDToolStripMenuItem.Visible = cRUDToolStripMenuItem.Enabled = toolStripSeparator1.Visible = true;
                    usuarioToolStripMenuItem.Text = usuarioToolStripMenuItem + ", Administrador";
                    break;
            }
        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void termostatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBS bullshit = new frmBS();
            bullshit.MdiParent = this;
            bullshit.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void reportesDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report rpt = new report();
            rpt.MdiParent = this;
            rpt.Show();
        }
    }
}
