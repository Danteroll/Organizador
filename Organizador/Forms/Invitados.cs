using Organizador.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; // Necesario para la búsqueda
using System.Windows.Forms;

namespace Organizador.Forms
{
    public partial class Invitados : Form
    {
        // Guardamos la lista completa para filtrar sin volver a la base de datos
        private List<Invitado> listaCompleta = new List<Invitado>();

        public Invitados()
        {
            InitializeComponent();
            CargarDatosInvitados();
        }

        private void CargarDatosInvitados()
        {
            try
            {
                listaCompleta = DatabaseManager.ObtenerInvitados();
                dgvInvitados.DataSource = null;
                dgvInvitados.DataSource = listaCompleta;

                // Ocultamos la columna ID si existe para un diseño más limpio
                if (dgvInvitados.Columns["Id"] != null)
                    dgvInvitados.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        // --- LÓGICA DE BÚSQUEDA ---
        // Asegúrate de que tu TextBox de búsqueda se llame 'txtBuscar' en el diseño
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower().Trim();

            // Filtramos por Nombre o Grupo usando LINQ
            var filtrados = listaCompleta.Where(i =>
                i.Nombre.ToLower().Contains(filtro) ||
                i.Grupo.ToLower().Contains(filtro)
            ).ToList();

            dgvInvitados.DataSource = filtrados;
        }

        // --- LÓGICA DE ELIMINAR ---
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInvitados.SelectedRows.Count > 0)
            {
                // Obtenemos el ID de la fila seleccionada en el DataGridView
                int id = Convert.ToInt32(dgvInvitados.SelectedRows[0].Cells["Id"].Value);

                var confirmacion = MessageBox.Show("¿Seguro que deseas eliminar a este invitado?",
                                                 "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    DatabaseManager.EliminarInvitado(id);
                    CargarDatosInvitados(); // Refrescamos la tabla
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila completa en la tabla.");
            }
        }

        // --- BOTÓN AGREGAR (Manteniendo tu lógica actual) ---
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) return;

            DatabaseManager.AgregarInvitado(textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            CargarDatosInvitados();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBox1.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
            txtBuscar.Clear();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvInvitados.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtenemos el valor de la celda llamada "Id"
                    var valorCelda = dgvInvitados.SelectedRows[0].Cells["Id"].Value;

                    if (valorCelda != null)
                    {
                        int id = Convert.ToInt32(valorCelda);

                        var respuesta = MessageBox.Show("¿Seguro que deseas eliminar este invitado?",
                                                         "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (respuesta == DialogResult.Yes)
                        {
                            // Llamada al método de la base de datos
                            DatabaseManager.EliminarInvitado(id);

                            // IMPORTANTE: Refrescar la tabla para ver el cambio
                            CargarDatosInvitados();
                            MessageBox.Show("Invitado eliminado con éxito.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona la fila completa del invitado que quieres borrar.");
            }
        }
    }
}