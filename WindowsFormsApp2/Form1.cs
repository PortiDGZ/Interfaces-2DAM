using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, result_sum, result_rest, result_multp, result_div;
            string selected = "";
            num1 = 0;
            num2 = 0;
            num3 = 0;
            if(num1_txt.Text != "" && num2_txt.Text != "" && num3_txt.Text != "")
            {
                num1 = Convert.ToDouble(num1_txt.Text);
                num2 = Convert.ToDouble(num2_txt.Text);
                num3 = Convert.ToDouble(num3_txt.Text);

            }
            else
            {

                MessageBox.Show("Introduce los tres números", "Error");
            }
      
            if (groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) != null)
            {
                selected = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
            }
            else
            {

                MessageBox.Show("Selecciona una opción", "Error");
            }
            switch (selected)
            {
                case "rad_sumar": result_sum = num1 + num2 + num3;
                    placeholder_lbl.Text = Convert.ToString(result_sum);
                    break;
                case "rad_restar": result_rest = num1 - num2 - num3;
                    placeholder_lbl.Text = Convert.ToString(result_rest);
                    break;
                case "rad_mult": result_multp = num1 * num2 *num3;
                    placeholder_lbl.Text = Convert.ToString(result_multp);
                    break;
                case "rad_div": result_div = (num1 / num2) / num3;
                    placeholder_lbl.Text = Convert.ToString(result_div);
                    break;
                case "rad_all": result_sum = num1 + num2 + num3;
                              result_rest = num1 - num2 - num3;
                              result_multp = num1 * num2 * num3;
                              result_div = num1 / num2 / num3;
                    placeholder_lbl.Text = "Suma: " + result_sum + " Resta: " + result_rest + " Multiplicación: " + result_multp + " División: " + result_div;
                    break;


            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            num1_txt.Clear();
            num2_txt.Clear();
            num3_txt.Clear();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
