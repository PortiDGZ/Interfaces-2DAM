using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenRec1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Database=recuperacion; Uid=root;Pwd=root;";
            conexion.Open();
            string query = "SELECT Nombre FROM marcas";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                comboBox1.Items.Add(lector.GetString(0));
            }
            conexion.Close();
        }

        public string precio;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int marca = comboBox1.SelectedIndex + 1;
            string nombremarca = comboBox1.GetItemText(comboBox1.SelectedItem);
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Database=recuperacion; Uid=root;Pwd=root;";
            conexion.Open();
            string query = $"SELECT Nombre FROM modelos WHERE {marca} = id_marca";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                comboBox2.Items.Add(lector.GetString(0));
            }
            conexion.Close();

            label2.Text = nombremarca + " tiene " + Convert.ToString(comboBox2.Items.Count) + " modelos";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mod_coche = "\'" + comboBox2.GetItemText(comboBox2.SelectedItem) + "\'";
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Database=recuperacion; Uid=root;Pwd=root;";
            conexion.Open();
            string query = $"SELECT PrecioBase FROM modelos WHERE Nombre = {mod_coche}";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                if(lector.IsDBNull(0)) {

                    IntroducirPrecio introducir = new IntroducirPrecio();

                    introducir.ShowDialog();
                    introducir.coche = comboBox2.GetItemText(comboBox2.SelectedItem);
                    label3.Text = lector.GetString(0);
                
                }
            }
            conexion.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
