using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenRec1A
{
    public partial class IntroducirPrecio : Form
    {
        public IntroducirPrecio()
        {
            InitializeComponent();
           
        }
        public string coche;

        private void button1_Click(object sender, EventArgs e)
        {
            float precio = Convert.ToInt32(maskedTextBox1.Text);
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Database=recuperacion; Uid=root;Pwd=root;";
            conexion.Open();
            string query = $"UPDATE modelos SET PrecioBase = {precio} WHERE Nombre = \'{coche}\'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            this.Close();
        }
    }
}
