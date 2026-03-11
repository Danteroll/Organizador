namespace Organizador.Forms
{
    partial class Invitados
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
            label1 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            btnEliminar = new Button();
            txtBuscar = new TextBox();
            button4 = new Button();
            button5 = new Button();
            dgvInvitados = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            panelDatosInvitados = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvitados).BeginInit();
            panelDatosInvitados.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(14, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 54);
            label1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 28);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 31);
            textBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(445, 208);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(56, 31);
            numericUpDown1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.LimeGreen;
            checkBox1.Location = new Point(115, 208);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(156, 29);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "CONFIRMADO";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(115, 250);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 4;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(276, 250);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(118, 36);
            button2.TabIndex = 5;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(442, 250);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 36);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.TextChanged += btnEliminar_Click;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(115, 304);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(444, 31);
            txtBuscar.TabIndex = 7;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(42, 499);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(118, 36);
            button4.TabIndex = 8;
            button4.Text = "Limpiar ";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(180, 499);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(142, 36);
            button5.TabIndex = 9;
            button5.Text = "Exportar CSV";
            button5.UseVisualStyleBackColor = true;
            // 
            // dgvInvitados
            // 
            dgvInvitados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInvitados.BackgroundColor = SystemColors.InactiveBorder;
            dgvInvitados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvitados.GridColor = SystemColors.ScrollBar;
            dgvInvitados.Location = new Point(42, 345);
            dgvInvitados.Margin = new Padding(4);
            dgvInvitados.Name = "dgvInvitados";
            dgvInvitados.RowHeadersWidth = 51;
            dgvInvitados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvitados.Size = new Size(645, 106);
            dgvInvitados.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 312);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 12;
            label3.Text = "Buscar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 211);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 13;
            label4.Text = "Acompañantes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(508, 34);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 14;
            label5.Text = "Telefono";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(631, 31);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 31);
            textBox3.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 86);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 16;
            label6.Text = "Alergias";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 80);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(340, 31);
            textBox4.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(508, 86);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 18;
            label7.Text = "Grupo";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(631, 83);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(155, 31);
            textBox5.TabIndex = 19;
            // 
            // panelDatosInvitados
            // 
            panelDatosInvitados.Controls.Add(textBox1);
            panelDatosInvitados.Controls.Add(label7);
            panelDatosInvitados.Controls.Add(textBox5);
            panelDatosInvitados.Controls.Add(label2);
            panelDatosInvitados.Controls.Add(label6);
            panelDatosInvitados.Controls.Add(label5);
            panelDatosInvitados.Controls.Add(textBox3);
            panelDatosInvitados.Controls.Add(textBox4);
            panelDatosInvitados.Dock = DockStyle.Top;
            panelDatosInvitados.Location = new Point(0, 0);
            panelDatosInvitados.Name = "panelDatosInvitados";
            panelDatosInvitados.Size = new Size(892, 148);
            panelDatosInvitados.TabIndex = 20;
            // 
            // Invitados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 230, 240);
            ClientSize = new Size(892, 550);
            Controls.Add(panelDatosInvitados);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvInvitados);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(txtBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Invitados";
            Text = "Invitados";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvitados).EndInit();
            panelDatosInvitados.ResumeLayout(false);
            panelDatosInvitados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button btnEliminar;
        private TextBox txtBuscar;
        private Button button4;
        private Button button5;
        private DataGridView dgvInvitados;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Panel panelDatosInvitados;
    }
}