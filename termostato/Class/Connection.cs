using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace termostato.Class
{
    class Connection
    {
        #region Variables // CONN CONFIG
        private string[] connSettings = { "termostato", "root", "localhost", "madrigalesgay21" };
        //private string[] connSettings = { "termostato", "root", "localhost", "1234" };
        public static MySqlConnection cn;
        #endregion

        #region Constructor, Open y Close
        #region Connection
        /// <summary>
        /// Asigna la conexión a utilizar
        /// </summary>
        public Connection()
        {
            cn = new MySqlConnection(string.Format("Server='{2}';Database='{0}';Uid='{1}';Pwd='{3}';", connSettings));
        }
        #endregion

        #region Open cn
        /// <summary>
        /// Abre la conexión
        /// </summary>
        public void open()
        {
            cn.Open();
        }
        #endregion

        #region Close cn
        /// <summary>
        /// Cierra la conexión
        /// </summary>
        public void close()
        {
            cn.Close();
        }
        #endregion
        #endregion

        #region executeQuery
        /// <summary>
        /// Ejecuta una operación SQL
        /// </summary>
        /// <param name="sql">String que contiene el comando a ejecutar</param>
        public async void executeQuery(string sql)
        {
            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                await cmd.ExecuteNonQueryAsync();
                close();
            }
            catch (Exception ex)
            {
                close();
                MessageBox.Show(ex.GetBaseException().ToString());
            }
        }
        #endregion

        #region DataTable readTable
        /// <summary>
        /// Se utiliza para sacar la informacion de una tabla completa desde la base de datos
        /// </summary>
        /// <param name="sql">String que contiene el comando a ejecutar. Se debe asignar cuales datos devolverá, 
        /// tambien debe asignarse la(s) tabla(s) de donde se van a sacar los datos.</param>
        /// <returns>Devuelve una tabla completa en formato DataTable desde la base de datos</returns>
        public DataTable readTable(string sql)
        {
            DataTable table = new DataTable();
            try
            {
                open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
                da.Fill(table);
                close();
                return table;
            }
            catch (Exception ex)
            {
                close();
                //MessageBox.Show("Error en la consulta SQL: \n\n" + ex);
                return table;
            }
        }
        #endregion

        #region DataRow readRow
        /// <summary>
        /// Devuelve un solo renglón completo desde la base de datos
        /// </summary>
        /// <param name="sql">String que contiene el comando a ejecutar. Se debe asignar los datos que se quieren sacar, 
        /// tambien deben asignarse la(s) tabla(s) de donde se sacaran los datos.</param>
        /// <returns>Devuelve un único renglón en formato DataRow desde la base de datos</returns>
        public DataRow readRow(string sql)
        {
            try
            {
                DataRow row;
                open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                close();
                row = (ds.Tables[0].Rows[0]);
                return row;
            }
            catch (Exception ex)
            {
                close();
                //MessageBox.Show("Error en la consulta SQL: \n\n" + ex);
                return null;
            }
        }
        #endregion

        #region DataRow IsRowEmpty
        public bool IsRowEmpty(DataRow dr)
        {
            if (dr == null)
            {
                return true;
            }
            else
            {
                foreach (var value in dr.ItemArray)
                {
                    if (value != null)
                    {
                        if (value.ToString().Trim() != "")
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
        #endregion
    }
}
