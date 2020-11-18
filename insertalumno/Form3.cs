﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insertalumno
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=127.0.0.1;Database=interfaces; Uid=root;Pwd=root;";
            conexion.Open();

            string st = "SELECT * FROM provincias";



            MySqlCommand comando = new MySqlCommand(st, conexion);
            comando.ExecuteNonQuery();
            MySqlDataAdapter da1 = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "provincia";
            comboBox1.DataSource = dt;
            conexion.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=127.0.0.1;Database=interfaces; Uid=root;Pwd=root;";
            conexion.Open();

            string st = "SELECT * FROM municipios WHERE " + comboBox1.SelectedItem + "= municipios.ID;";

            MySqlCommand comando = new MySqlCommand(st, conexion);
            comando.ExecuteNonQuery();
            MySqlDataAdapter da1 = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "municipio";
            comboBox2.DataSource = dt;
            conexion.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
