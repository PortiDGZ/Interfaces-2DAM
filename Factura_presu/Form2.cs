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

namespace Factura_presu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "datasource=127.0.0.1;port=3306;Uid=root;Pwd=root;Database=interfaces;";
            string cadena = "insert into articulos(ID,Nombre, Precio, Marca, P/N, Familia) values (" + textBox1.Text + "'," + textBox2
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}