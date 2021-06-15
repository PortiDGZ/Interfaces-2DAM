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
    public partial class report : Form
    {
        public report(string DNI)
        {
            InitializeComponent();
            CrystalReport11.SetParameterValue("DNI", DNI);
        }
    }
}
