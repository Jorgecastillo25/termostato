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
    public partial class frmBS : Form
    {
        private Class.Connection conn;
        private string bs, usuario;
        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }
        public frmBS()
        {
            InitializeComponent();
            conn = new Class.Connection();
        }

        private void frmBS_Load(object sender, EventArgs e)
        {
            DataRow row = conn.readRow("select grados from logs order by log desc limit 1;");
            if (conn.IsRowEmpty(row)) { label1.Text = "00°"; }
            else { label1.Text = string.Format("{0}°", row[0].ToString()); }
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0}°", numBS.Value.ToString());
            string sql = string.Format("insert into logs (usuario,grados,fechaHora) values ('{0}','{1}','{2}');", usuario, bs, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            conn.executeQuery(sql);
        }

        private void numBS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnBS_Click(sender, e);
            }
        }

        private void numBS_ValueChanged(object sender, EventArgs e)
        {
            bs = numBS.Value.ToString();
        }
    }
}
