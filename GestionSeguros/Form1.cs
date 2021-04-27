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

namespace GestionSeguros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost,3306;Database=gestion;User Id=root;Password=root;");
            string user = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();

            MySqlDataAdapter da2 = new MySqlDataAdapter($"SELECT * FROM usuario where nombre = '{user}' AND contraseña = '{password}'", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            if(dt2.Rows.Count > 0)
            {
                MessageBox.Show($"Bienvenido {user}");
                inicio inicio = new inicio();
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos, por favor compruebe su usuario y contraseña.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
