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
    public partial class FormGestion : Form
    {
        /*ATRIBUTOS DE LA CLASE*/
        private FormAlta fAlta;
        private FormPolizas fPolizas;
        private MySqlConnection conexion;

        public FormGestion()
        {
            InitializeComponent();
        }

        private void FormGestion_Load(object sender, EventArgs e)
        {
            //Conexión con la base de datos
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Database=agencia_seguros; Uid=root;Pwd='admin';";

            this.actualizarTabla();

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            fAlta = new FormAlta();
            fAlta.ShowDialog();

            if (fAlta.DialogResult == DialogResult.OK)
            {
                //Se abre la conexión con la base de datos
                conexion.Open();

                //Cadena con la consulta
                string query = $"INSERT INTO cliente VALUES ('{fAlta.Dni}', '{fAlta.Nombre}', '{fAlta.Apellidos}', " +
                    $"'{fAlta.Telefono}', '{fAlta.Localidad}', '{fAlta.CodPostal}', '{fAlta.Provincia}', '{fAlta.Tipo}');";

                //Se crea el comando para una consulta no SELECT
                MySqlCommand comando = new MySqlCommand(query, conexion);
                //Se ejecuta el comando
                comando.ExecuteNonQuery();

                //Se actualiza la tabla en el dataGridView
                this.actualizarTabla();

                //Se cierra la conexión
                conexion.Close();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de querer borrar este cliente?", "Borrar",
                MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                //Se recoge la fila actual
                DataGridViewRow filaActual = dgvClientes.CurrentRow;

                //DNI (Clave primaria) de la fila actual
                String dni = filaActual.Cells["DNI"].Value.ToString();

                //Se abre la conexión con la base de datos
                conexion.Open();

                //Cadena con la consulta
                string query = $"DELETE FROM cliente WHERE DNI = '{dni}'";

                //Se crea el comando para una consulta no SELECT
                MySqlCommand comando = new MySqlCommand(query, conexion);
                //Se ejecuta el comando
                comando.ExecuteNonQuery();

                //Se actualiza la tabla en el dataGridView
                this.actualizarTabla();

                //Se cierra la conexión
                conexion.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Se recoge la fila actual
            DataGridViewRow filaActual = dgvClientes.CurrentRow;

            //Variables para los datos de la fila actual
            String dni = filaActual.Cells["DNI"].Value.ToString();
            String nom = filaActual.Cells["Nombre"].Value.ToString();
            String ape = filaActual.Cells["Apellidos"].Value.ToString();
            String tel = filaActual.Cells["Telefono"].Value.ToString();
            int pro = obtenerProvinciaCliente(dni);
            int loc = obtenerLocalidadCliente(dni);
            String cp = filaActual.Cells["Cod. Postal"].Value.ToString();
            String tip = filaActual.Cells["Tipo"].Value.ToString();


            //Creamos un nuevo formulario para modificar los datos de la fila seccionada
            fAlta = new FormAlta(dni, nom, ape, tel, pro, loc, cp, tip);
            fAlta.ShowDialog();


            if (fAlta.DialogResult == DialogResult.OK)
            {
                //Se abre la conexión con la base de datos
                conexion.Open();

                //Cadena con la consulta
                string query = $"UPDATE cliente SET DNI = '{fAlta.Dni}', Nombre = '{fAlta.Nombre}', " +
                    $"Apellidos = '{fAlta.Apellidos}', Telefono = '{fAlta.Telefono}', Localidad = {fAlta.Localidad}, " +
                    $"CP = '{fAlta.CodPostal}', Provincia = {fAlta.Provincia}, Tipo_cliente = '{fAlta.Tipo}' " +
                    $"WHERE DNI = '{fAlta.Dni}';";

                //Se crea el comando para una consulta no SELECT
                MySqlCommand comando = new MySqlCommand(query, conexion);
                //Se ejecuta el comando

                comando.ExecuteNonQuery();

                //Se actualiza la tabla en el dataGridView
                this.actualizarTabla();

                //Se cierra la conexión
                conexion.Close();
            }
        }

        public void actualizarTabla() //Actualiza el DataGridView de todos los artículos
        {
            // TODO: esta línea de código carga datos en la tabla 'agencia_segurosDataSet.cliente' Puede moverla o quitarla según sea necesario.
            //this.clienteTableAdapter.Fill(this.agencia_segurosDataSet.cliente);

            dgvClientes.AutoGenerateColumns = true;
            dgvClientes.DataSource = null;
            dgvClientes.Columns.Clear();
            dgvClientes.Rows.Clear();

            string consulta = "SELECT DNI, Nombre, Apellidos, Telefono AS 'Teléfono', m.municipio AS Localidad, CP AS 'Cod. Postal', " +
                "p.provincia AS Provincia, Tipo_cliente AS Tipo " +
                "FROM cliente c, municipios m, provincias p " +
                "WHERE p.id = c.Provincia AND c.Localidad = m.id; ";

            //Se crea el comando para una consulta SELECT
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //Se adapta para MySQL
            MySqlDataAdapter m_datos = new MySqlDataAdapter(comando);

            DataTable dt = new DataTable(); 
            m_datos.Fill(dt);
            dgvClientes.DataSource = dt;

            conexion.Close();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnBaja.Enabled = true;
        }

        public int obtenerProvinciaCliente(String dniAlumno)
        {
            int provincia = 0;

            //Se abre la conexión con la base de datos
            conexion.Open();

            string sql = "SELECT Provincia FROM cliente WHERE DNI = '" + dniAlumno + "';";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                provincia = dr.GetInt16(0); //Devuelve el primer entero que encuentra en el resultSet
            }

            dr.Close();
            conexion.Close();

            //MessageBox.Show(provincia.ToString());

            return provincia;
        }

        public int obtenerLocalidadCliente(String dniAlumno)
        {
            int poblacion = 0;

            //Se abre la conexión con la base de datos
            conexion.Open();

            string sql = "SELECT Localidad FROM cliente WHERE DNI = '" + dniAlumno + "';";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                poblacion = dr.GetInt16(0);
            }

            dr.Close();
            conexion.Close();

            //MessageBox.Show(poblacion.ToString());

            return poblacion;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            //Cierra todas las ventanas del programa y lo finaliza
            Application.Exit();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            String buscar = txtBuscador.Text;
            
            if(buscar != "")
            {
                dgvClientes.AutoGenerateColumns = true;
                dgvClientes.DataSource = null;
                dgvClientes.Columns.Clear();
                dgvClientes.Rows.Clear();

                string consulta = "SELECT DNI, Nombre, Apellidos, Telefono AS Teléfono, m.municipio AS Localidad, CP AS 'Cod. Postal', " +
                "p.provincia AS Provincia, Tipo_cliente AS Tipo " +
                "FROM cliente c, municipios m, provincias p " +
                "WHERE (p.id = c.Provincia AND c.Localidad = m.id) " +
                "AND (DNI LIKE '%" + buscar + "%' OR Nombre LIKE '%" + buscar + "%' OR Apellidos LIKE '%" + buscar + "%' " +
                "OR Telefono LIKE '%" + buscar + "%' OR m.municipio LIKE '%" + buscar + "%' OR CP LIKE '%" + buscar + "%' " +
                "OR p.provincia LIKE '%" + buscar + "%' OR Tipo_cliente LIKE '%" + buscar + "%');";

                //Se crea el comando para una consulta SELECT
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                //Se adapta para MySQL
                MySqlDataAdapter m_datos = new MySqlDataAdapter(comando);

                DataTable dt = new DataTable();
                m_datos.Fill(dt);
                dgvClientes.DataSource = dt;

                conexion.Close();
            }

            else
            {
                actualizarTabla();
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se recoge la fila actual
            DataGridViewRow filaActual = dgvClientes.CurrentRow;

            //DNI (Clave primaria) de la fila actual
            String dni = filaActual.Cells["DNI"].Value.ToString();

            fPolizas = new FormPolizas(dni);
            fPolizas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var DNI = report.Text;

            report rep = new report(DNI);
            rep.ShowDialog();
        }

        private void btnVerPolizas_Click(object sender, EventArgs e)
        {
            fPolizas = new FormPolizas();
            fPolizas.ShowDialog();
        }
    }
}
