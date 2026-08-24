using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descuentos_IanNieto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float Ventainit;
            float Descuento;
            float Descporc;
            float Ventafin;

            if (float.TryParse(txtValorVenta.Text.Replace(",", "."), out Ventainit))
            {
                
                if (Ventainit >= 500)
                {
                    Descporc = 0.3f;
                    txtDescporc.Text = "30%";
                }
                else if (Ventainit >= 300)
                {
                    Descporc = 0.2f;
                    txtDescporc.Text = "20%";
                }
                else if (Ventainit >= 100)
                {
                    Descporc = 0.1f;
                    txtDescporc.Text = "10%";
                }
                else
                {
                    Descporc = 0f;
                    txtDescporc.Text = "0%";
                }

                Descuento = Ventainit * Descporc;
                txtDescuento.Text = Descuento.ToString();

                Ventafin = Ventainit - Descuento;
                txtVentafin.Text = Ventafin.ToString();
            }
            else { MessageBox.Show("Informacion incorrecta, ingrese numeros"); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorVenta.Text = "";
            txtDescporc.Text = "";
            txtDescuento.Text = "";
            txtVentafin.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrara la ventana");
            MessageBox.Show("Cerrando");
            Application.Exit();
        }
    }
}
