namespace InterfazBancoTemaNuevo
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
            panelContenedor = new Panel();
            panelFormularios = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            InicioSesion = new Button();
            button1 = new Button();
            Barra = new Panel();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnRestaurar = new PictureBox();
            panelContenedor.SuspendLayout();
            panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaption;
            panelContenedor.Controls.Add(panelFormularios);
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Controls.Add(Barra);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1100, 600);
            panelContenedor.TabIndex = 0;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = SystemColors.Control;
            panelFormularios.Controls.Add(pictureBox1);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panelFormularios.ForeColor = Color.Black;
            panelFormularios.Location = new Point(240, 40);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(860, 560);
            panelFormularios.TabIndex = 2;
            panelFormularios.Paint += panelFormularios_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Interfaz2.Properties.Resources.coviran;
            pictureBox1.Location = new Point(196, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 339);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(100, 150, 100);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(InicioSesion);
            panelMenu.Controls.Add(button1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 40);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(240, 560);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 103);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(91, 43);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Puesto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(92, 75);
            label4.Name = "label4";
            label4.Size = new Size(45, 13);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(91, 12);
            label3.Name = "label3";
            label3.Size = new Size(51, 13);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Interfaz2.Properties.Resources.user__1_;
            pictureBox2.Location = new Point(4, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 150, 100);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 170, 100);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Gainsboro;
            button4.Image = Interfaz2.Properties.Resources.payment11;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(6, 222);
            button4.Name = "button4";
            button4.Size = new Size(230, 42);
            button4.TabIndex = 3;
            button4.Text = "              Recibos";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 150, 100);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 170, 100);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Gainsboro;
            button3.Image = Interfaz2.Properties.Resources.phone_book__1_12;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(5, 173);
            button3.Name = "button3";
            button3.Size = new Size(230, 42);
            button3.TabIndex = 2;
            button3.Text = "              Empleados";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // InicioSesion
            // 
            InicioSesion.FlatAppearance.BorderSize = 0;
            InicioSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 150, 100);
            InicioSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 170, 100);
            InicioSesion.FlatStyle = FlatStyle.Flat;
            InicioSesion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InicioSesion.ForeColor = Color.Gainsboro;
            InicioSesion.Image = Interfaz2.Properties.Resources.person_settings11;
            InicioSesion.ImageAlign = ContentAlignment.MiddleLeft;
            InicioSesion.Location = new Point(7, 506);
            InicioSesion.Name = "InicioSesion";
            InicioSesion.Size = new Size(230, 42);
            InicioSesion.TabIndex = 1;
            InicioSesion.Text = "              Iniciar Sesión";
            InicioSesion.TextAlign = ContentAlignment.MiddleLeft;
            InicioSesion.UseVisualStyleBackColor = true;
            InicioSesion.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(100, 150, 100);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 150, 100);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 170, 100);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Gainsboro;
            button1.Image = Interfaz2.Properties.Resources.health__1_11;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(5, 125);
            button1.Name = "button1";
            button1.Size = new Size(230, 42);
            button1.TabIndex = 0;
            button1.Text = "             Productos";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Barra
            // 
            Barra.BackColor = Color.DarkOliveGreen;
            Barra.Controls.Add(btnMinimizar);
            Barra.Controls.Add(btnMaximizar);
            Barra.Controls.Add(btnCerrar);
            Barra.Controls.Add(btnRestaurar);
            Barra.Dock = DockStyle.Top;
            Barra.Location = new Point(0, 0);
            Barra.Name = "Barra";
            Barra.Size = new Size(1100, 40);
            Barra.TabIndex = 0;
            Barra.MouseDown += Barra_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Interfaz2.Properties.Resources.Minimize;
            btnMinimizar.Location = new Point(1028, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(16, 16);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = Interfaz2.Properties.Resources.maximize3;
            btnMaximizar.Location = new Point(1050, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(16, 16);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Interfaz2.Properties.Resources.Close;
            btnCerrar.Location = new Point(1072, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(16, 16);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Interfaz2.Properties.Resources.Normal;
            btnRestaurar.Location = new Point(1050, 12);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(16, 16);
            btnRestaurar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(680, 500);
            Name = "Form1";
            Text = "Form1";
            panelContenedor.ResumeLayout(false);
            panelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panelMenu;
        private Panel Barra;
        private Panel panelFormularios;
        private PictureBox btnMaximizar;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox btnRestaurar;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button4;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Button InicioSesion;
        private Label label2;
    }
}