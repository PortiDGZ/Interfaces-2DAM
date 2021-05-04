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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionDataSet.municipios' Puede moverla o quitarla según sea necesario.
            this.municipiosTableAdapter.Fill(this.gestionDataSet.municipios);
            // TODO: esta línea de código carga datos en la tabla 'gestionDataSet.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.gestionDataSet.provincias);
            // TODO: esta línea de código carga datos en la tabla 'gestionDataSet.datos' Puede moverla o quitarla según sea necesario.
            this.datosTableAdapter.Fill(this.gestionDataSet.datos);

            MySqlConnection conn = new MySqlConnection("Server=localhost,3306;Database=gestion;User Id=root;Password=root;");

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM provincias", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbProv.DataSource = dt;

        }

        private void cbPob_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost,3306;Database=interfaces;User Id=root;Password=root;");

            MySqlDataAdapter da2 = new MySqlDataAdapter($"SELECT * FROM municipios where provincia = {cbProv.SelectedValue.ToString()}", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cbPob.DisplayMember = "municipio";
            cbPob.ValueMember = "id";
            cbPob.DataSource = dt2;
        }
    }
}
