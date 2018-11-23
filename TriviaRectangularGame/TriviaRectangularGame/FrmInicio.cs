using System;
using System.Drawing;
using System.Windows.Forms;

namespace TriviaRectangularGame
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        FrmDados frmDados = new FrmDados();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "" || txtNombreUsuario.Text == string.Empty)
                Jugador.NombreUsuario = "Jugador X";
            else
                Jugador.NombreUsuario = txtNombreUsuario.Text;

            frmDados.Show();
            this.Hide();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

            lblTitulo.ForeColor = System.Drawing.Color.HotPink;
            //lblTitulo.Font = new Font("Game Over", 80, FontStyle.Bold);

            lblSubTitulo.ForeColor = System.Drawing.Color.Blue;
            //lblSubTitulo.Font = new Font("Game Over", 60, FontStyle.Bold);

            txtNombreUsuario.BackColor = Color.Black;
            txtNombreUsuario.ForeColor = Color.Yellow;

            #region Timer
            timer1.Enabled = true;
            timer1.Interval = 400;
            #endregion
        }

        private void CambiarColor()
        {
            #region Titulo
            if (lblTitulo.ForeColor != Color.HotPink)
                lblTitulo.ForeColor = Color.HotPink;
            else
                lblTitulo.ForeColor = Color.Blue;
            #endregion

            #region SubTitulo
            if (lblSubTitulo.ForeColor != Color.Blue)
                lblSubTitulo.ForeColor = Color.Blue;
            else
                lblSubTitulo.ForeColor = Color.HotPink;
            #endregion

            #region BtnEnter
            if (btnEntrar.ForeColor != Color.Black)
            {
                btnEntrar.ForeColor = Color.Black;
                btnEntrar.BackColor = Color.Gray;
            }
            else
            {
                btnEntrar.ForeColor = Color.Yellow;
                btnEntrar.BackColor = Color.Black;
            }
              
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CambiarColor();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAyuda frm = new FrmAyuda();
            frm.Show();
            
        }
    }
}
