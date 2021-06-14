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
            MySqlConnection conn = new MySqlConnection("Server=localhost,3307;Database=agencia_seguros;User Id=root;Password=admin;");
            string user = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();

            MySqlDataAdapter da2 = new MySqlDataAdapter($"SELECT * FROM usuario where nombre_usuario = '{user}'", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            if(dt2.Rows.Count > 0)
            {
                MySqlDataAdapter da3 = new MySqlDataAdapter($"SELECT * FROM usuario where pass_usuario = '{password}'", conn);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
                    MessageBox.Show($"Bienvenido {user}");
                    inicio inicio = new inicio();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    error_pass.Text = "La contraseña es incorrecta";
                    error_pass.Show();
                }
            }
            else
            {
                error_usu.Text = "El usuario es incorrecto";
                error_usu.Show();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Quieres salir de la aplicación?", "Confirmación", buttons);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            error_usu.Hide();
            error_pass.Hide();
        }
    }
}
