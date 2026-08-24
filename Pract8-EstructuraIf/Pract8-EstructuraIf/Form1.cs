using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract8_EstructuraIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void RadioButton_CheckedChanged(object sender, EventArgs e) {

            
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbtSuma.Checked)
            {
                lblSigno.Text = "+";
                txtResult.Text = (float.Parse(txtNum1.Text) + float.Parse(txtNum2.Text)).ToString();
            }
            else if (rbtResta.Checked)
            {
                lblSigno.Text = "-";
                txtResult.Text = (float.Parse(txtNum1.Text) - float.Parse(txtNum2.Text)).ToString();

            }
            else if (rbtMultiplicacion.Checked)
            {
                lblSigno.Text = "*";
                txtResult.Text = (float.Parse(txtNum1.Text) * float.Parse(txtNum2.Text)).ToString();
            }
            else if (rbtDivision.Checked)
            {
                lblSigno.Text = "/";
                txtResult.Text = (float.Parse(txtNum1.Text) / float.Parse(txtNum2.Text)).ToString();
            }

            else {
                MessageBox.Show("Ingrese los números y seleccione la operación");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrara la ventana");
            MessageBox.Show("Cerrando");
            Application.Exit();
        }
    }
}
