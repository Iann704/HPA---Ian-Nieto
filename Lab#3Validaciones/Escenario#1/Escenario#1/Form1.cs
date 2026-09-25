using EjemploGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escenario_1
{
    public partial class Form1 : Form
    {
        ArrayList listaPersonas = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Persona miColaborador = new Persona();

            miColaborador.Id = listaPersonas.Count + 1;
            miColaborador.Nombres = txtNombres.Text;
            miColaborador.Apellidos = txtApellidos.Text;
            miColaborador.Correo = txtCorreo.Text;
            miColaborador.FechaNacimiento = dtpFechaNacimiento.Value;
            miColaborador.Salario = decimal.Parse(txtSalario.Text);

            listaPersonas.Add(miColaborador);

            dgvdatos.DataSource = null;
            dgvdatos.DataSource = listaPersonas;

            // Limpiar los campos
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtSalario.Clear();
        }
    }
}
