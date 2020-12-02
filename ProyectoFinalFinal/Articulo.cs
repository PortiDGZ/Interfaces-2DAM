using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinalFinal
{
    public partial class Articulo : Form
    {
        public Articulo()
        {
            InitializeComponent();
        }

        private void Articulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'art_presuDataSet.articulo' Puede moverla o quitarla según sea necesario.
            this.articuloTableAdapter.Fill(this.art_presuDataSet.articulo);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Port=3306;Database=art_presu;Uid=root;Pwd=root;";
            conexion.Open();

            
            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "INSERT INTO room(ID,Nombre, Precio, Familia) VALUES(?id,?precio,?articulo,?familia)";
            comando.Parameters.AddWithValue("?id", MySqlDbType.Int32).Value = Convert.ToInt32(textBox1.Text);
            comando.Parameters.AddWithValue("?precio", MySqlDbType.VarChar).Value = Convert.ToInt32(textBox2.Text);
            comando.Parameters.AddWithValue("?articulo", MySqlDbType.VarChar).Value = textBox3.Text;
            comando.Parameters.AddWithValue("?familia", MySqlDbType.VarChar).Value = textBox4.Text;

            comando.ExecuteNonQuery();
            conexion.Close();


        }
    }
}
