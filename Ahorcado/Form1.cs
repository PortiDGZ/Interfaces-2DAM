using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void metroButton1_Click(object sender, EventArgs e)
        {
            using (Pantalla_de_juego pantalla_De_Juego = new Pantalla_de_juego(textBox1.Text))
            {

                pantalla_De_Juego.ShowDialog();

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
