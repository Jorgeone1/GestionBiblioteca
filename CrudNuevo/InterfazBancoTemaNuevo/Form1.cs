using Interfaz2;
using System.Runtime.InteropServices;

namespace InterfazBancoTemaNuevo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;


        }
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        private void PanelContenedor_SizeChanged(object sender, EventArgs e)
        {
            // Calcula el nuevo tamaño para pictureBox1 y label1
            int newWidth = panelContenedor.ClientSize.Width;
            int newHeight = panelContenedor.ClientSize.Height;

            pictureBox1.Size = new Size((newWidth - 100) / 2, newHeight / 2);



        }

        protected override void WndProc(ref Message msg)
        {
            switch (msg.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref msg);
                    var hitpoint = this.PointToClient(new Point(msg.LParam.ToInt32() & 0xffff, msg.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitpoint))
                        msg.Result = new IntPtr(HTBOTTOMRIGHT);

                    break;
                default:
                    base.WndProc(ref msg);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);


            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush bluebrush = new SolidBrush(Color.FromArgb(100, 170, 100));
            e.Graphics.FillRectangle(bluebrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
            //100, 170, 100
        }
        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            pictureBox1.Size = new Size(898, 678);//449k 339
            pictureBox1.Location = new Point(292, 99);

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            pictureBox1.Size = new Size(449, 339);
            pictureBox1.Location = new Point(196, 79);

            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form2>();
            button1.BackColor = Color.FromArgb(100, 170, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form3>();
            InicioSesion.BackColor = Color.FromArgb(100, 170, 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form6>();
            button3.BackColor = Color.FromArgb(100, 170, 100);
        }

        private void AbrirFormulario<miForm>() where miForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<miForm>().FirstOrDefault(); ;
            if (formulario == null)
            {
                formulario = new miForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form2"] == null)
                button1.BackColor = Color.FromArgb(100, 150, 100);
            if (Application.OpenForms["Form3"] == null)
                InicioSesion.BackColor = Color.FromArgb(100, 150, 100);
            if (Application.OpenForms["Form4"] == null)
                button3.BackColor = Color.FromArgb(100, 150, 100);
            if (Application.OpenForms["Form5"] == null)
                button4.BackColor = Color.FromArgb(100, 150, 100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form5>();
            button4.BackColor = Color.FromArgb(100, 170, 100);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

    }

}