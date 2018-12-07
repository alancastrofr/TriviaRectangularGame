using System;
using System.Drawing;
using WMPLib;
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
        WindowsMediaPlayer wndMedia = new WindowsMediaPlayer();
        WindowsMediaPlayer wndMediaButon = new WindowsMediaPlayer();

        private void SonidoDelBoton()
        {
            wndMediaButon.URL = @"C:\soundButton.mp3";
            wndMediaButon.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "" || txtNombreUsuario.Text == string.Empty)
                Jugador.NombreUsuario = "Jugador 1";
            else
                Jugador.NombreUsuario = txtNombreUsuario.Text;

            wndMedia.controls.stop();
            SonidoDelBoton();

            frmDados.Show();
            this.Hide();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

            lblTitulo.ForeColor = System.Drawing.Color.DeepPink;
            lblSubTitulo.ForeColor = System.Drawing.Color.Blue;          

            txtNombreUsuario.BackColor = Color.Black;
            txtNombreUsuario.ForeColor = Color.Yellow;
            
            #region Timer
            timer1.Enabled = true;
            timer1.Interval = 400;
            #endregion

            #region Musica
            wndMedia.URL = @"C:\DisfigureBlank.mp3";
            wndMedia.controls.play();
            #endregion
        }

        private void CambiarColor()
        {
            #region Titulo
            if (lblTitulo.ForeColor != Color.DeepPink)
                lblTitulo.ForeColor = Color.DeepPink;
            else
                lblTitulo.ForeColor = Color.Blue;
            #endregion

            #region SubTitulo
            if (lblSubTitulo.ForeColor != Color.Blue)
                lblSubTitulo.ForeColor = Color.Blue;
            else
                lblSubTitulo.ForeColor = Color.DeepPink;
            #endregion

            #region BtnEnter
            if (btnEntrar.ForeColor != Color.Black)
            {
                btnEntrar.ForeColor = Color.Black;
                btnEntrar.BackColor = Color.Gray;

                btnAyuda.ForeColor = Color.Black;
                btnAyuda.BackColor = Color.Gray;
            }
            else
            {
                btnEntrar.ForeColor = Color.Yellow;
                btnEntrar.BackColor = Color.Black;

                btnAyuda.ForeColor = Color.Yellow;
                btnAyuda.BackColor = Color.Black;
            }
              
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CambiarColor();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {            
            SonidoDelBoton();

            FrmAyuda frm = new FrmAyuda();
            frm.Show();
            
        }
    }
}
