using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            MySqlConnection conn = new MySqlConnection("Server=localhost,3306;Database=agencia_seguros;User Id=admin;Password=admin;");
            string user = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();

            MySqlDataAdapter da2 = new MySqlDataAdapter($"SELECT * FROM usuario where nombre_usuario = '{user}' AND pass_usuario = '{password}'", conn);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
