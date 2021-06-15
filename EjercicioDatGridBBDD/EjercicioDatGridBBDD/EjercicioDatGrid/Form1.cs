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
    public partial class Form1 : Form
    {
        /*ATRIBUTOS DE LA CLASE*/
        private FormAlta fAlta;
        private MySqlConnection conexion;
        poliza poliza = new poliza();

        public Form1()
        {
            InitializeComponent();
            btnBajas.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            fAlta = new FormAlta();
            fAlta.ShowDialog();

            if(fAlta.DialogResult == DialogResult.OK)
            {
                //Se abre la conexión con la base de datos
                conexion.Open();

                //Cadena con la consulta
                string query = $"INSERT INTO cliente VALUES ('{fAlta.DNI}', '{fAlta.Nombre}', '{fAlta.Apellido}', " +
                    $"'{fAlta.codigo}', '{fAlta.Telefono}', '{fAlta.Provincia}', '{fAlta.Poblacion}', '{fAlta.tipo_cli}');";

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
            DataGridViewRow filaActual = dataGridView1.CurrentRow;

            //Variables para los datos de la fila actual
            String dni = filaActual.Cells["DNI"].Value.ToString();
            String nom = filaActual.Cells["Nombre"].Value.ToString();
            String ape = filaActual.Cells["Apellidos"].Value.ToString();
            String cp = filaActual.Cells["CP"].Value.ToString();
            String tel = filaActual.Cells["Telefono"].Value.ToString();
            String tipo = filaActual.Cells["Tipo de cliente"].Value.ToString();
            int pro = obtenerProvinciaAlumno(dni);
            int pob = obtenerPoblacionAlumno(dni);

            //String pro = código de provincia
            //String pob = código de municipio

            //Creamos un nuevo formulario para modificar los datos de la fila seccionada
            fAlta = new FormAlta(dni, nom, ape, cp, tel, tipo, pro, pob);
            fAlta.ShowDialog();


            if (fAlta.DialogResult == DialogResult.OK)
            {
                //Se abre la conexión con la base de datos
                conexion.Open();

                //Cadena con la consulta
                string query = $"UPDATE cliente SET DNI = '{fAlta.DNI}', Nombre = '{fAlta.Nombre}', Apellidos = '{fAlta.Apellido}', " +
                    $"CP = '{fAlta.codigo}', Telefono = '{fAlta.Telefono}', Provincia = '{fAlta.Provincia}', " +
                    $"Localidad = '{fAlta.Poblacion}', Tipo_cliente = '{fAlta.tipo_cli}'  WHERE DNI = '{fAlta.DNI}';";

                //Se crea el comando para una consulta no SELECT
                MySqlCommand comando = new MySqlCommand(query, conexion);
                //Se ejecuta el comando

                comando.ExecuteNonQuery();

                //Se actualiza la tabla en el dataGridView
                this.actualizarTabla();
            }
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de querer borrar esta fila?", "Borrar",
                MessageBoxButtons.YesNo);

            if(confirmacion == DialogResult.Yes)
            {
                //Se recoge la fila actual
                DataGridViewRow filaActual = dataGridView1.CurrentRow;

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
                conexion.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnBajas.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agencia_segurosDataSet1.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.agencia_segurosDataSet1.cliente);
            // TODO: esta línea de código carga datos en la tabla 'agencia_segurosDataSet.cliente' Puede moverla o quitarla según sea necesario.

            //Conexión con la base de datos
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Database=agencia_seguros; Uid=admin;Pwd=admin;";

            this.actualizarTabla();
        }

        public void actualizarTabla() //Actualiza el DataGridView de todos los artículos
        {

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            string consulta = "SELECT DNI, Nombre, Apellidos, CP, Telefono, p.provincia AS Provincia, m.municipio AS Poblacion, Tipo_cliente AS 'Tipo de Cliente' " +
                "FROM cliente c, municipios m, provincias p " +
                "WHERE p.id = c.Provincia AND c.Localidad = m.id; ";

            //Se crea el comando para una consulta SELECT
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //Se adapta para MySQL
            MySqlDataAdapter m_datos = new MySqlDataAdapter(comando);

            DataTable dt = new DataTable();
            m_datos.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();
        }

        public int obtenerProvinciaAlumno(String dni)
        {
            int provincia = 0;

            //Se abre la conexión con la base de datos
            conexion.Open();

            string sql = "SELECT Provincia FROM cliente WHERE DNI = '" + dni + "';";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                provincia = dr.GetInt16(0);
            }

            dr.Close();

            conexion.Close();

            //MessageBox.Show(provincia.ToString());

            return provincia;
        }

        public int obtenerPoblacionAlumno(String dni)
        {
            int poblacion = 0;

            //Se abre la conexión con la base de datos
            conexion.Open();

            string sql = "SELECT Localidad FROM cliente WHERE DNI = '" + dni + "';";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                poblacion = dr.GetInt16(0);
            }

            dr.Close();

            //MessageBox.Show(poblacion.ToString());

            return poblacion;
        }

        public void Busqueda(string buscar)
        {

            MySqlConnection conn = new MySqlConnection("Server=localhost,3306;Database=agencia_seguros;User Id=admin;Password=admin;");
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM cliente where Nombre like '%" + buscar + "%' OR DNI like '%" + buscar + "%' OR Apellidos like '%" + buscar + "%' OR Telefono like '%" + buscar + "%' OR Localidad like '%" + buscar + "%' OR CP like '%" + buscar + "%' OR Provincia like '%" + buscar + "%' OR Tipo_cliente like '%" + buscar + "%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Busqueda(textBox1.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            poliza.ShowDialog();
        }
    }
}
