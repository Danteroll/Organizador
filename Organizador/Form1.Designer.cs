namespace Organizador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            iconSmall = new FontAwesome.Sharp.IconButton();
            iconBtnFull = new FontAwesome.Sharp.IconButton();
            iconClose = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            fontDialog1 = new FontDialog();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(40, 51, 79);
            panelMenu.Controls.Add(iconButton4);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 617);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 40;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 320);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 10, 0);
            iconButton4.Size = new Size(220, 60);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "Agenda";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Chair;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 40;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 260);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 10, 0);
            iconButton3.Size = new Size(220, 60);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "Mapa de Mesas";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 200);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 10, 0);
            iconButton2.Size = new Size(220, 60);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Invitados";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 140);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 10, 0);
            iconButton1.Size = new Size(220, 60);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Inicio";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.AccessibleRole = AccessibleRole.None;
            btnHome.Image = Properties.Resources.image__2_;
            btnHome.Location = new Point(12, 28);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(189, 79);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += pictureBox1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(234, 236, 245);
            panelTitleBar.Controls.Add(iconSmall);
            panelTitleBar.Controls.Add(iconBtnFull);
            panelTitleBar.Controls.Add(iconClose);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1055, 100);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // iconSmall
            // 
            iconSmall.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconSmall.BackColor = Color.FromArgb(234, 236, 245);
            iconSmall.FlatAppearance.BorderSize = 0;
            iconSmall.FlatStyle = FlatStyle.Flat;
            iconSmall.ForeColor = Color.SlateGray;
            iconSmall.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconSmall.IconColor = Color.SlateGray;
            iconSmall.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSmall.IconSize = 20;
            iconSmall.Location = new Point(928, 5);
            iconSmall.Name = "iconSmall";
            iconSmall.Size = new Size(36, 29);
            iconSmall.TabIndex = 4;
            iconSmall.UseVisualStyleBackColor = false;
            iconSmall.Click += iconSmall_Click;
            // 
            // iconBtnFull
            // 
            iconBtnFull.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconBtnFull.BackColor = Color.FromArgb(234, 236, 245);
            iconBtnFull.FlatAppearance.BorderSize = 0;
            iconBtnFull.FlatStyle = FlatStyle.Flat;
            iconBtnFull.ForeColor = Color.SlateGray;
            iconBtnFull.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            iconBtnFull.IconColor = Color.SlateGray;
            iconBtnFull.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnFull.IconSize = 20;
            iconBtnFull.Location = new Point(970, 5);
            iconBtnFull.Name = "iconBtnFull";
            iconBtnFull.Size = new Size(36, 29);
            iconBtnFull.TabIndex = 3;
            iconBtnFull.UseVisualStyleBackColor = false;
            iconBtnFull.Click += iconBtnFull_Click;
            // 
            // iconClose
            // 
            iconClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconClose.BackColor = Color.FromArgb(234, 236, 245);
            iconClose.FlatAppearance.BorderSize = 0;
            iconClose.FlatStyle = FlatStyle.Flat;
            iconClose.ForeColor = Color.SlateGray;
            iconClose.IconChar = FontAwesome.Sharp.IconChar.X;
            iconClose.IconColor = Color.SlateGray;
            iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClose.IconSize = 20;
            iconClose.Location = new Point(1012, 5);
            iconClose.Name = "iconClose";
            iconClose.Size = new Size(36, 29);
            iconClose.TabIndex = 2;
            iconClose.UseVisualStyleBackColor = false;
            iconClose.Click += iconClose_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.ForeColor = Color.FromArgb(81, 92, 117);
            lblTitleChildForm.Location = new Point(66, 41);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(54, 25);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(234, 236, 245);
            iconCurrentChildForm.ForeColor = Color.SlateGray;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.SlateGray;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 44;
            iconCurrentChildForm.Location = new Point(15, 28);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(47, 44);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(235, 236, 245);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(220, 100);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1055, 18);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(228, 230, 240);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 118);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1055, 499);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 617);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private FontDialog fontDialog1;
        private FontAwesome.Sharp.IconButton iconClose;
        private FontAwesome.Sharp.IconButton iconSmall;
        private FontAwesome.Sharp.IconButton iconBtnFull;
    }
}
