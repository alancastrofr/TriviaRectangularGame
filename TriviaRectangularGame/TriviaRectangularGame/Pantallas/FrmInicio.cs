using System;
using System.Drawing;
using System.Windows.Forms;
using TriviaRectangularGame.Logicas;
using WMPLib;

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
            wndMediaButon.URL = Logica.Pantalla.ConfigurarAudio(1);
            wndMediaButon.controls.play();
        }

        private void SonidoFondo()
        {
            wndMedia.URL = Logica.Pantalla.ConfigurarAudio(2);
            wndMedia.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Jugador.ValidarNombreJugador(txtNombreUsuario.Text);

            wndMedia.controls.stop();
            SonidoDelBoton();

            frmDados.Show();
            this.Hide();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

            lblTitulo.ForeColor = Color.DeepPink;
            lblSubTitulo.ForeColor = Color.Blue;          

            txtNombreUsuario.BackColor = Color.Black;
            txtNombreUsuario.ForeColor = Color.Yellow;
            
            #region Timer
            timer1.Enabled = true;
            timer1.Interval = 400;
            #endregion

            #region Musica
            SonidoFondo();
            #endregion
        }

        private void CambiarColor()
        {
            #region Titulo
            if (lblTitulo.ForeColor != Color.Yellow)
            {
                lblTitulo.ForeColor = Color.Yellow;
                lblTitulo.Show();
            }            
            else
            {
                lblTitulo.ForeColor = Color.Purple;
                lblTitulo.Hide();
            }


            if (lblTitulo2.ForeColor != Color.Yellow)
            {
                lblTitulo2.ForeColor = Color.Yellow;
                lblTitulo2.Hide();
            }
            else
            {
                lblTitulo2.ForeColor = Color.Purple;
                lblTitulo2.Show();
            }

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
