using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlnIntegrador.Datos;
using SlnIntegrador.Entidades;

namespace WindowsPresentacion
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente()
            {

                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Domicilio = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                NroHistorialClinica = Convert.ToInt32(txtNcli.Text),
                MedicoId = 2



            };

            int filasAfectadas = abmPaciente.Insert(paciente);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("paciente insertado");
                MostrarPaciente();
            }

        }






        //Metodo

        private void MostrarPaciente()
        {
            GridMedico.DataSource = abmPaciente.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPaciente();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente()
            {
                PacienteId = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Domicilio = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                NroHistorialClinica = Convert.ToInt32(txtNcli.Text),
                MedicoId = 2

            };

            int filasAfectadas = abmPaciente.Update(paciente);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Modificacion ok");
                MostrarPaciente();

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int PacienteId = Convert.ToInt32(txtId.Text);

            Paciente paciente = abmPaciente.SelectWhereById(PacienteId);
            MessageBox.Show($"Nombre Paciente:  {paciente.Nombre} " +
                $"\n Apellido Paciente: {paciente.Apellido}" +
                $"\nNumero de historia clinica: {paciente.NroHistorialClinica}" );

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Paciente paciente= new Paciente()
            {
                PacienteId = Convert.ToInt32(txtId.Text),
                MedicoId = 2
            };


            int filasAfectadas = abmPaciente.Delete(paciente);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarPaciente();

            }
        }
    }
}
