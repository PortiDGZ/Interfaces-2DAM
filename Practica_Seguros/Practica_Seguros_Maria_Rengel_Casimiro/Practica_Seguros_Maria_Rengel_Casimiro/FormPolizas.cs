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
    public partial class FormPolizas : Form
    {
        /*ATRIBUTOS*/
        private MySqlConnection conexion;
        private Poliza poliza;

        private Boolean polizasPorCliente; //True si accedemos a las pólizas de un determinado cliente
        private String dni_cliente;

        public FormPolizas()
        {
            InitializeComponent();

            this.polizasPorCliente = false;
        }

        public FormPolizas(String dni)
        {
            InitializeComponent();

            this.dni_cliente = dni;
            this.polizasPorCliente = true;
        }

        private void FormPolizas_Load(object sender, EventArgs e)
        {
            //Conexión con la base de datos
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Database=agencia_seguros; Uid=root;Pwd='admin';";

            //Creamos un nuevo objeto Poliza
            this.poliza = new Poliza();

            //Mostramos las filas del DataGridView
            tablaPolizas();
        }

        private void lblCerrarPolizasCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tablaPolizas()
        {
            /**CONSULTA QUE SE EJECUTARÁ PARA VISUALIZAR LA TABLA**/
            String consulta = poliza.orderByFechaDesc();

            //Si estamos accediendo a las pólizas de un determnado cliente
            if (polizasPorCliente)
            {
                consulta = poliza.obtenerPolizasCliente(this.dni_cliente);
            }

            /**FIN CONSULTA QUE SE EJECUTARÁ PARA VISUALIZAR LA TABLA**/

            //Borramos el contenido del DataGridView
            dgvPolizas.AutoGenerateColumns = true;
            dgvPolizas.DataSource = null;
            dgvPolizas.Columns.Clear();
            dgvPolizas.Rows.Clear();

            //Se abre la conexión con la base de datos
            conexion.Open();

            //Se crea el comando para una consulta SELECT
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //Se adapta para MySQL
            MySqlDataAdapter m_datos = new MySqlDataAdapter(comando);

            //Se reace la tabla
            DataTable dt = new DataTable();
            m_datos.Fill(dt);
            dgvPolizas.DataSource = dt;

            conexion.Close();
        }
    }
}
