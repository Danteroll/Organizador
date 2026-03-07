namespace Organizador.Forms
{
    partial class MapaMesas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelListaInvitados = new Panel();
            ltbInvitados = new ListBox();
            labelLista = new Label();
            panelMapaMesas = new Panel();
            nudMesas = new NumericUpDown();
            btnAplicarMesas = new Button();
            ltbInvitadosMesa = new ListBox();
            panelListaInvitados.SuspendLayout();
            panelMapaMesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMesas).BeginInit();
            SuspendLayout();
            // 
            // panelListaInvitados
            // 
            panelListaInvitados.Controls.Add(nudMesas);
            panelListaInvitados.Controls.Add(ltbInvitados);
            panelListaInvitados.Controls.Add(btnAplicarMesas);
            panelListaInvitados.Controls.Add(labelLista);
            panelListaInvitados.Dock = DockStyle.Right;
            panelListaInvitados.Location = new Point(648, 0);
            panelListaInvitados.Name = "panelListaInvitados";
            panelListaInvitados.Size = new Size(152, 450);
            panelListaInvitados.TabIndex = 0;
            // 
            // ltbInvitados
            // 
            ltbInvitados.FormattingEnabled = true;
            ltbInvitados.Location = new Point(16, 72);
            ltbInvitados.Name = "ltbInvitados";
            ltbInvitados.Size = new Size(117, 129);
            ltbInvitados.TabIndex = 1;
            ltbInvitados.SelectedIndexChanged += ltbInvitados_SelectedIndexChanged;
            ltbInvitados.MouseDown += ltbInvitados_MouseDown;
            // 
            // labelLista
            // 
            labelLista.AutoSize = true;
            labelLista.Location = new Point(15, 9);
            labelLista.Name = "labelLista";
            labelLista.Size = new Size(125, 25);
            labelLista.TabIndex = 0;
            labelLista.Text = "Lista Invitados";
            // 
            // panelMapaMesas
            // 
            panelMapaMesas.AllowDrop = true;
            panelMapaMesas.Controls.Add(ltbInvitadosMesa);
            panelMapaMesas.Dock = DockStyle.Fill;
            panelMapaMesas.Location = new Point(0, 0);
            panelMapaMesas.Name = "panelMapaMesas";
            panelMapaMesas.Size = new Size(648, 450);
            panelMapaMesas.TabIndex = 1;
            panelMapaMesas.DragEnter += Mesa_DragEnter;
            panelMapaMesas.DragOver += Mesa_DragEnter;
            panelMapaMesas.Paint += panelMapaMesas_Paint;
            // 
            // nudMesas
            // 
            nudMesas.Location = new Point(6, 271);
            nudMesas.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudMesas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMesas.Name = "nudMesas";
            nudMesas.Size = new Size(119, 31);
            nudMesas.TabIndex = 2;
            nudMesas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAplicarMesas
            // 
            btnAplicarMesas.Location = new Point(6, 308);
            btnAplicarMesas.Name = "btnAplicarMesas";
            btnAplicarMesas.Size = new Size(106, 58);
            btnAplicarMesas.TabIndex = 1;
            btnAplicarMesas.Text = "Agregar Mesa";
            btnAplicarMesas.UseVisualStyleBackColor = true;
            btnAplicarMesas.Click += btnAplicarMesas_Click;
            // 
            // ltbInvitadosMesa
            // 
            ltbInvitadosMesa.FormattingEnabled = true;
            ltbInvitadosMesa.Location = new Point(40, 33);
            ltbInvitadosMesa.Name = "ltbInvitadosMesa";
            ltbInvitadosMesa.Size = new Size(180, 129);
            ltbInvitadosMesa.TabIndex = 0;
            ltbInvitadosMesa.SelectedIndexChanged += ltbInvitadosMesa_SelectedIndexChanged;
            ltbInvitadosMesa.MouseDown += ltbInvitadosMesa_MouseDown;
            // 
            // MapaMesas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 230, 240);
            ClientSize = new Size(800, 450);
            Controls.Add(panelMapaMesas);
            Controls.Add(panelListaInvitados);
            Name = "MapaMesas";
            Text = "MapaMesas";
            Load += MapaMesas_Load;
            panelListaInvitados.ResumeLayout(false);
            panelListaInvitados.PerformLayout();
            panelMapaMesas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMesas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelListaInvitados;
        private Label labelLista;
        private Panel panelMapaMesas;
        private ListBox ltbInvitados;
        private ListBox ltbInvitadosMesa;
        private Button btnAplicarMesas;
        private NumericUpDown nudMesas;
    }
}