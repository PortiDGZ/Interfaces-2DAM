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
using MySql.Data.MySqlClient;

namespace insertalumno
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'interfacesDataSet1.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.interfacesDataSet1.alumnos);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=127.0.0.1;Database=interfaces; Uid=root;Pwd=root;";
            conexion.Open();

            string st = "INSERT INTO alumnos(id_alumno, alumno)VALUES('" + textBox1.Text + "'," + textBox2.Text + ")";

            MySqlCommand comando = new MySqlCommand(st, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
