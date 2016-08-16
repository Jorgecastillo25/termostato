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
    public partial class report : Form
    {
        string fecha1, fecha2;
        Class.Connection conn;
        public report()
        {
            InitializeComponent();
            conn = new Class.Connection();
        }



        private void report_Load(object sender, EventArgs e)
        {
            fecha1 = fecha2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            dataGridView1.DataSource = conn.readTable("select * from logs order by fechaHora;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.readTable(string.Format("select * from logs "
                + "where fechaHora BETWEEN '{0}' and '{1}' order by fechaHora;", fecha1, fecha2));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fecha1 = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fecha2 = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
