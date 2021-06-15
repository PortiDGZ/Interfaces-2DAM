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
    public partial class FormAlta : Form
    {
        /*ATRIBUTOS DE LA CLASE*/
        private MySqlConnection conexion;

        private String dni;
        private String nombre;
        private String apellidos;
        private String telefono;
        private int provincia;
        private int localidad;
        private String codPostal;
        private String tipo;
        private Boolean modificar; //True si el formulario es para modificar


        //Constructor para el formulario en modo dar de alta
        public FormAlta()
        {
            InitializeComponent();

            this.modificar = false;
        }

        //Constructor para el formulario en modo modificar
        public FormAlta(String dni, String nom, String ape, String tel, int prov, int loc, String cp, String tip)
        {
            InitializeComponent();

            //Los valores pasados por parámetros se asignan a los atributos de la clase
            this.dni = dni;
            this.nombre = nom;
            this.apellidos = ape;
            this.telefono = tel;
            this.provincia = prov;
            this.localidad = loc;
            this.codPostal = cp;
            this.tipo = tip;
            this.modificar = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Se recogen los valores de los textView
            this.dni = txtDNI.Text;
            this.nombre = txtNombre.Text;
            this.apellidos = txtApellido.Text;
            this.telefono = txtTelefono.Text;
            this.provincia = int.Parse(cmbProvincias.SelectedValue.ToString());
            this.localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
            this.codPostal = txtCodPostal.Text;
            this.tipo = cmbTiposCliente.Text;

            //Se cierra la ventana
            this.Close();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            establecerConexion();
            llenarComboProvincias();

            //Si el formulario está en modo modificar
            if (modificar)
            {
                //Se cambia el texto del título de la ventana
                //this.Text = "Modificar";

                //Se cambia el texto de la cabecera del formulario
                lblAltaModificar.Text = "MODIFICAR";

                //Los valores pasados por parámetros se asignan a los textView del formulario
                txtDNI.Text = this.Dni;
                txtNombre.Text = this.Nombre;
                txtApellido.Text = this.Apellidos;
                txtTelefono.Text = this.Telefono;
                cmbProvincias.SelectedValue = this.Provincia;
                cmbLocalidades.SelectedValue = this.Localidad;
                txtCodPostal.Text = this.CodPostal;
                cmbTiposCliente.SelectedText = this.Tipo;
            }
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se hace disponible el combo de las localidades
            lblLocalidad.Enabled = true;
            cmbLocalidades.Enabled = true;

            //Se obtiene el id de la provincia seleccionada
            String idProvincia = cmbProvincias.SelectedValue.ToString();

            //Se abre la conexión con la base de datos
            conexion.Open();

            //Cadena con la consulta
            string consulta = "SELECT * FROM municipios WHERE provincia = " + idProvincia;

            //Se crea el comando para una consulta SELECT
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //Se adapta para MySQL
            MySqlDataAdapter m_datos = new MySqlDataAdapter(comando);

            //Se crea un objeto DataTable para adaptarlo a modo tabla
            DataTable municipios = new DataTable();

            //Se llena el MySqlDataAdapter con el DataTable
            m_datos.Fill(municipios);

            //Se llena el combo de las poblaciones con la tabla de municipios de la base de datos filtrada según la provincia 
            //Se le asigna el texto y valor a cada elemento del combo con los campos de la tabla municipios
            cmbLocalidades.DisplayMember = "municipio"; //Municipio que se muestra en el combo
            cmbLocalidades.ValueMember = "id"; //El valor que le corresponde a este municipio (en este caso la id)
            cmbLocalidades.DataSource = municipios; //Los datos que recoge de la base de datos

            //Se cierra la conexión
            conexion.Close();
        }

        private void establecerConexion()
        {
            //Conexión con la base de datos
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Database=agencia_seguros; Uid=root;Pwd='admin';";
        }

        private void llenarComboProvincias()
        {
            // TODO: esta línea de código carga datos en la tabla 'agencia_segurosDataSet1.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.agencia_segurosDataSet1.provincias);
        }

        /*MÉTODOS GET*/
        public string Dni { get => dni; }
        public string Nombre { get => nombre; }
        public string Apellidos { get => apellidos; }
        public string Telefono { get => telefono; }
        public int Provincia { get => provincia; }
        public int Localidad { get => localidad; }
        public string CodPostal { get => codPostal; }
        public string Tipo { get => tipo; }

        private void lblCerrarAlta_Click(object sender, EventArgs e)
        {
            //Cierra el propio formulario
            this.Close();
        }
    }
}
