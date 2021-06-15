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

namespace EjercicioDatGrid
{
    public partial class FormAlta : Form
    {
        /*ATRIBUTOS DE LA CLASE*/
        private MySqlConnection conexion;

        private String Dni;
        private String nombre;
        private String apellido;
        private String cp;
        private String telefono;
        private String tipo;
        private int provincia;
        private int poblacion;
        private Boolean modificar; //True si el formulario es para modificar

        //Constructor para el formulario en modo dar de alta
        public FormAlta()
        {
            InitializeComponent();

            this.modificar = false;
        }
        
        //Constructor para el formulario en modo modificar
        public FormAlta(String dni, String nom, String ape, String cp, String tipo,
            String tel, int prov, int pob)
        {
            InitializeComponent();

            //Los valores pasados por parámetros se asignan a los atributos de la clase
            this.Dni = dni;
            this.nombre = nom;
            this.apellido = ape;
            this.cp = cp;
            this.telefono = tel;
            this.provincia = prov;
            this.poblacion = pob;
            this.tipo = tipo;
            this.modificar = true;
        }

        private void establecerConexion()
        {
            //Conexión con la base de datos
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Database=agencia_seguros; Uid=admin;Pwd=admin;";
        }

        private void llenarComboProvincias()
        {
            this.provinciasTableAdapter.Fill(this.agencia_segurosDataSet1.provincias);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Se recogen los valores de los textView
            this.Dni = txtDNI.Text;
            this.nombre = txtNombre.Text;
            this.apellido = txtApellido.Text;
            this.cp = txtCp.Text;
            this.telefono = txtTelefono.Text;
            this.tipo = cmb_tipo.GetItemText(cmb_tipo.SelectedItem);
            this.provincia = int.Parse(cmbProvincias.SelectedValue.ToString());
            this.poblacion = int.Parse(cmbPoblaciones.SelectedValue.ToString());

            this.Close();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agencia_segurosDataSet1.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.agencia_segurosDataSet1.provincias);
            // TODO: esta línea de código carga datos en la tabla 'agencia_segurosDataSet.provincias' Puede moverla o quitarla según sea necesario.
            establecerConexion();
            llenarComboProvincias();

            //Si el formulario está en modo modificar
            if(modificar)
            {
                //Los valores pasados por parámetros se asignan a los textView del formulario
                txtDNI.Text = this.DNI;
                txtNombre.Text = this.nombre;
                txtApellido.Text = this.apellido;
                txtCp.Text = this.cp;
                txtTelefono.Text = this.telefono;
                cmbProvincias.SelectedValue = this.provincia;
                cmbPoblaciones.SelectedValue = this.poblacion;
                cmb_tipo.SelectedItem = this.tipo;
            }
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se hace disponible el combo de las poblaciones
            lblPoblacion.Enabled = true;
            cmbPoblaciones.Enabled = true; 

            //Se abre la conexión con la base de datos
            conexion.Open();

            //Se obtiene el id de la provincia seleccionada
            String idProvincia = cmbProvincias.SelectedValue.ToString();

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
            cmbPoblaciones.DisplayMember = "municipio"; //Municipio que se muestra en el combo
            cmbPoblaciones.ValueMember = "id"; //El valor que le corresponde a este municipio (en este caso la id)
            cmbPoblaciones.DataSource = municipios; //Los datos que recoge de la base de datos

            //Se cierra la conexión
            conexion.Close();
        }

        /*MÉTODOS GET*/
        public string DNI { get => Dni; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string codigo { get => cp; }
        public string Telefono { get => telefono; }
        public string tipo_cli { get => tipo; }
        public int Provincia { get => provincia; }
        public int Poblacion { get => poblacion; }

    }
}
