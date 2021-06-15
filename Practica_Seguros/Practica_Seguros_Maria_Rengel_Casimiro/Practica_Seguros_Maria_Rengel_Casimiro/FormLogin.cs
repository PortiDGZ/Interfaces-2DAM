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

namespace Practica_Seguros_Maria_Rengel_Casimiro
{
    public partial class FormLogin : Form
    {
        /*ATRIBUTOS DE LA CLASE*/
        private MySqlConnection conexion;
        private FormGestion fGestion;

        private String usuario;
        private String password;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //Conexión con la base de datos
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Database=agencia_seguros; Uid=root;Pwd='admin';";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            password = txtPassword.Text;

            //Se abre la conexión con la base de datos
            conexion.Open();

            //Cadena con la consulta
            string consulta = $"SELECT * FROM usuario WHERE nombre_usuario = '{usuario}' AND pass_usuario = '{password}'";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader dr = comando.ExecuteReader();

            //Si la consulta devuelve filas es usuario es correcto
            if (dr.HasRows)
            {
                //MessageBox.Show("Usario correcto");

                fGestion = new FormGestion();
                fGestion.Show();

                this.Hide();
            }

            else
            {
                txtPassword.Text = ""; //Se borra el contenido del textbox de la contraseña
                lblError.Text = "Usuario o contraseña incorrectos";
            }

            dr.Close();
            conexion.Close();

            //MessageBox.Show(provincia.ToString());
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            //Cierra todas las ventanas del programa y lo finaliza
            Application.Exit();
        }
    }
}
