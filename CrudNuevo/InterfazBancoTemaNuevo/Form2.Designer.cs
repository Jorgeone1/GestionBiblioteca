namespace Interfaz2
{
    partial class Form2
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
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textID = new TextBox();
            textNombre = new TextBox();
            textDescripcion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textPrecio = new TextBox();
            label6 = new Label();
            textIVA = new TextBox();
            buttonCrear = new Button();
            buttonActualizar = new Button();
            buttonCancelar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 54, 75);
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(754, 522);
            button1.Name = "button1";
            button1.Size = new Size(78, 27);
            button1.TabIndex = 8;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(573, 105);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 9;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(528, 403);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // textID
            // 
            textID.Location = new Point(576, 128);
            textID.Name = "textID";
            textID.Size = new Size(247, 23);
            textID.TabIndex = 11;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(576, 172);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(247, 23);
            textNombre.TabIndex = 12;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(576, 223);
            textDescripcion.Multiline = true;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(247, 86);
            textDescripcion.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 154);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 15;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(573, 205);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 16;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(573, 321);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(40, 15);
            label5.TabIndex = 18;
            label5.Text = "Precio";
            label5.Click += label5_Click;
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(576, 339);
            textPrecio.Name = "textPrecio";
            textPrecio.RightToLeft = RightToLeft.No;
            textPrecio.Size = new Size(247, 23);
            textPrecio.TabIndex = 17;
            textPrecio.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(573, 365);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(34, 15);
            label6.TabIndex = 20;
            label6.Text = "IVA%";
            // 
            // textIVA
            // 
            textIVA.Location = new Point(576, 383);
            textIVA.Name = "textIVA";
            textIVA.RightToLeft = RightToLeft.No;
            textIVA.Size = new Size(247, 23);
            textIVA.TabIndex = 19;
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(577, 424);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(246, 27);
            buttonCrear.TabIndex = 21;
            buttonCrear.Text = "Insertar";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(577, 457);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(125, 27);
            buttonActualizar.TabIndex = 22;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(708, 457);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(115, 27);
            buttonCancelar.TabIndex = 23;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(354, 31);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 14;
            label2.Text = "Productos";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 561);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonCrear);
            Controls.Add(label6);
            Controls.Add(textIVA);
            Controls.Add(label5);
            Controls.Add(textPrecio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textDescripcion);
            Controls.Add(textNombre);
            Controls.Add(textID);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Formulario 1";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textID;
        private TextBox textNombre;
        private TextBox textDescripcion;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textPrecio;
        private Label label6;
        private TextBox textIVA;
        private Button buttonCrear;
        private Button buttonActualizar;
        private Button buttonCancelar;
        private Label label2;
    }
}