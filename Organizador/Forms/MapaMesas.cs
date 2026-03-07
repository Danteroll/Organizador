using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Organizador.Models;

namespace Organizador.Forms
{
    public partial class MapaMesas : Form
    {
        private Mesa? mesaSeleccionada;

        public MapaMesas()
        {
            InitializeComponent();

            panelMapaMesas.AllowDrop = true;
            ltbInvitadosMesa.Visible = true;
            btnAplicarMesas.Visible = true;
            nudMesas.Visible = true;

            // Asegurar que los MouseDown estén conectados (por si el diseñador no lo hizo)

        }

        private void MapaMesas_Load(object sender, EventArgs e)
        {
            CargarListaInvitados();
            DibujarMapaMesas();
        }

        public void RefrescarTodo()
        {
            CargarListaInvitados();

            if (panelMapaMesas.Controls.Count == 0)
                DibujarMapaMesas();
            else
                ActualizarBotonesMesas();

            RefrescarInvitadosMesaSeleccionada();
        }

        private void RefrescarInvitadosMesaSeleccionada()
        {
            if (mesaSeleccionada == null)
            {
                ltbInvitadosMesa.DataSource = null;
                return;
            }

            var lista = DatabaseManager.ObtenerInvitadosPorMesa(mesaSeleccionada.Id);

            ltbInvitadosMesa.DataSource = null;
            ltbInvitadosMesa.DisplayMember = "Nombre";
            ltbInvitadosMesa.DataSource = lista;
        }

        private void ActualizarBotonesMesas()
        {
            foreach (Control control in panelMapaMesas.Controls)
            {
                if (control is Button btnMesa && btnMesa.Tag is Mesa m)
                {
                    int ocupacion = DatabaseManager.ObtenerOcupacionActual(m.Id);
                    btnMesa.Text = $"MESA {m.NumeroMesa}\n({ocupacion}/{m.Capacidad})\n{m.Tipo}";
                    btnMesa.BackColor = (ocupacion >= m.Capacidad) ? Color.LightCoral : Color.LightGreen;
                }
            }
        }

        private void CargarListaInvitados()
        {
            ltbInvitados.DataSource = null;
            ltbInvitados.DisplayMember = "Nombre";
            ltbInvitados.DataSource = DatabaseManager.ObtenerInvitadosPendientes();
        }

        private void DibujarMapaMesas()
        {
            panelMapaMesas.Controls.Clear();
            var mesas = DatabaseManager.ObtenerMesas();

            // Colocación tipo grid para que no se apilen
            int x = 10;
            int y = 10;
            int espacio = 10;
            int anchoBtn = 120;
            int altoBtn = 120;

            foreach (var m in mesas)
            {
                Button btnMesa = new Button();
                int ocupacion = DatabaseManager.ObtenerOcupacionActual(m.Id);

                btnMesa.Size = new Size(anchoBtn, altoBtn);
                btnMesa.Location = new Point(x, y);

                btnMesa.Text = $"MESA {m.NumeroMesa}\n({ocupacion}/{m.Capacidad})\n{m.Tipo}";
                btnMesa.Tag = m;
                btnMesa.BackColor = (ocupacion >= m.Capacidad) ? Color.LightCoral : Color.LightGreen;
                btnMesa.FlatStyle = FlatStyle.Flat;
                btnMesa.FlatAppearance.BorderSize = 1;

                btnMesa.AllowDrop = true;
                btnMesa.DragEnter += Mesa_DragEnter;
                btnMesa.DragDrop += Mesa_DragDrop;
                btnMesa.DragLeave += Mesa_DragLeave;

                // Clic izquierdo (ver lista) más confiable con Click
                btnMesa.Click += Mesa_Click;

                // Clic derecho (menú)
                btnMesa.MouseUp += Mesa_MouseUp;

                panelMapaMesas.Controls.Add(btnMesa);

                // avanzar posición
                x += anchoBtn + espacio;
                if (x + anchoBtn > panelMapaMesas.Width)
                {
                    x = 10;
                    y += altoBtn + espacio;
                }
            }
        }

        // Drag desde pendientes
        private void ltbInvitados_MouseDown(object sender, MouseEventArgs e)
        {
            if (ltbInvitados.SelectedItem is Invitado invitado)
                ltbInvitados.DoDragDrop(invitado, DragDropEffects.Move);
        }

        // Drag desde mesa seleccionada
        private void ltbInvitadosMesa_MouseDown(object sender, MouseEventArgs e)
        {
            if (ltbInvitadosMesa.SelectedItem is Invitado invitado)
                ltbInvitadosMesa.DoDragDrop(invitado, DragDropEffects.Move);
        }

        private void Mesa_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(typeof(Invitado)))
            {
                e.Effect = DragDropEffects.Move;
                if (sender is Button btn)
                {
                    btn.FlatAppearance.BorderSize = 3;
                    btn.FlatAppearance.BorderColor = Color.Yellow;
                }
            }
        }

        private void Mesa_DragDrop(object? sender, DragEventArgs e)
        {
            if (sender is Button btnMesa &&
                e.Data != null &&
                e.Data.GetData(typeof(Invitado)) is Invitado invitado)
            {
                Mesa mesa = (Mesa)btnMesa.Tag!;
                int ocupados = DatabaseManager.ObtenerOcupacionActual(mesa.Id);

                // Si quieres permitir mover aunque ya esté en otra mesa:
                // tu DatabaseManager.AsignarInvitadoAMesa debe hacer UPDATE/INSERT (ya lo vimos)

                if (ocupados < mesa.Capacidad)
                {
                    DatabaseManager.AsignarInvitadoAMesa(invitado.Id, mesa.Id);
                    RefrescarTodo();
                }
                else
                {
                    MessageBox.Show("¡Esta mesa ya está llena!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Mesa_DragLeave(object? sender, EventArgs e)
        {
            if (sender is Button btnMesa)
            {
                btnMesa.FlatAppearance.BorderSize = 1;
                btnMesa.FlatAppearance.BorderColor = Color.Black;
            }
        }

        // Clic izquierdo: seleccionar mesa y mostrar invitados
        private void Mesa_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            mesaSeleccionada = (Mesa)btn.Tag!;
            RefrescarInvitadosMesaSeleccionada();

            // opcional: feedback visual
            this.Text = $"MapaMesas - Mesa {mesaSeleccionada.NumeroMesa}";
        }

        // Clic derecho: menú para quitar invitados
        private void Mesa_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || sender is not Button btnMesa) return;

            Mesa mesa = (Mesa)btnMesa.Tag!;
            ContextMenuStrip menu = new ContextMenuStrip();

            var invitadosEnMesa = DatabaseManager.ObtenerInvitadosPorMesa(mesa.Id);

            if (invitadosEnMesa.Count == 0)
            {
                menu.Items.Add("Mesa vacía").Enabled = false;
            }
            else
            {
                var titulo = new ToolStripMenuItem($"Mesa {mesa.NumeroMesa} ({invitadosEnMesa.Count}/{mesa.Capacidad})")
                {
                    Enabled = false,
                    Font = new Font(DefaultFont, FontStyle.Bold)
                };
                menu.Items.Add(titulo);
                menu.Items.Add(new ToolStripSeparator());

                foreach (var inv in invitadosEnMesa)
                {
                    var item = new ToolStripMenuItem($"❌ Quitar a {inv.Nombre}");
                    item.Click += (s, ev) =>
                    {
                        var result = MessageBox.Show($"¿Deseas quitar a {inv.Nombre} de la mesa?",
                            "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            DatabaseManager.QuitarInvitadoDeMesa(inv.Id);
                            RefrescarTodo();
                        }
                    };
                    menu.Items.Add(item);
                }
            }

            menu.Show(btnMesa, e.Location);
        }

        private void ltbInvitados_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ltbInvitadosMesa_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panelMapaMesas_Paint(object sender, PaintEventArgs e) { }

        private void btnAplicarMesas_Click(object sender, EventArgs e)
        {
            int cantidad = (int)nudMesas.Value;
            DatabaseManager.AjustarCantidadMesas(cantidad);

            mesaSeleccionada = null;
            ltbInvitadosMesa.DataSource = null;

            DibujarMapaMesas();
            RefrescarTodo();
        }
    }
}