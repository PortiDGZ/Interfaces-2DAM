using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public MySqlConnection conexion { get; private set; }

        private DataTable comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                using (var da = new SqlDataAdapter())
                {
                    using (var cmd = cn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT CategoryID, CategoryName FROM Categories";
                        da.SelectCommand = cmd;
                        var dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }

        }
    }
}
