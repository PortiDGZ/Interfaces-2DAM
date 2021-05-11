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
            // TODO: esta línea de código carga datos en la tabla 'agencia_segurosDataSet.municipios' Puede moverla o quitarla según sea necesario.
            this.municipiosTableAdapter1.Fill(this.agencia_segurosDataSet.municipios);
            // TODO: esta línea de código carga datos en la tabla 'agencia_segurosDataSet.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter1.Fill(this.agencia_segurosDataSet.provincias);


            MySqlConnection conn = new MySqlConnection("Server=localhost,3306;Database=agencia_seguros;User Id=admin;Password=admin;");

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM provincias", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbProv.DataSource = dt;

        }
        private void cbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost,3306;Database=agencia_seguros;User Id=admin;Password=admin;");

            MySqlDataAdapter da2 = new MySqlDataAdapter($"SELECT * FROM municipios where provincia = {cbProv.SelectedValue.ToString()}", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cbPob.DisplayMember = "municipio";
            cbPob.ValueMember = "id";
            cbPob.DataSource = dt2;
        }
    }
}
