using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int dia, mes, año;

            if (txtDia.Text != "" && txtMes.Text != "" && txtAño.Text != "")
            {
                if (int.TryParse(txtDia.Text, out dia) && int.TryParse(txtMes.Text, out mes) && int.TryParse(txtAño.Text, out año))
                {
                    if ((dia > 1 && dia < 32) && (mes < 13 && mes > 0))
                    {
                        string texto = txtDia.Text + " - " + txtMes.Text + " - " + txtAño.Text;
                        lblFechafinal.Text = "La fecha es: " + texto;
                    }

                    else { MessageBox.Show("Ingrese una fecha correcta"); }
                }
                else { MessageBox.Show("Datos erroneos, ingrese números de fechas"); }
            }
            else { MessageBox.Show("Falta información por completar"); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrara la ventana");
            MessageBox.Show("Cerrando");
            Application.Exit();
            
            
        }
    }
}
