using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace TriviaRectangularGame
{
    public partial class FrmDados : Form
    {
        public FrmDados()
        {
            InitializeComponent();
        }

        public string nomberUsuario;
        public string sumDados;

        WindowsMediaPlayer wndMediaButon = new WindowsMediaPlayer();

        private void SonidoDelBoton()
        {
            wndMediaButon.URL = @"C:\soundButton.mp3";
            wndMediaButon.controls.play();
        }

        private void SonidoDados()
        {
            wndMediaButon.URL = @"C:\soundDices.mp3";
            wndMediaButon.controls.play();
        }

        private void FrmDados_Load(object sender, EventArgs e)
        {     
            
            lblNombreUsuario.Text = Jugador.NombreUsuario;
            lblPuntos.Text = Jugador.PuntosJugador.ToString();
            if (Jugador.Intentos == 5)
            {
                FrmFinal frm = new FrmFinal();
                frm.Show();
                this.Close();
            }
            btnLanzarDados.Text = "Lanzar";
            btnContinuar.Visible = false;
        }

        private void btnLanzarDados_Click(object sender, EventArgs e)
        {
            SonidoDelBoton();
            SonidoDados();

            btnContinuar.Text = "Continuar";
            btnContinuar.Visible = true;
            btnLanzarDados.Visible = false;

            Random random = new Random();
            int dado1 = random.Next(1, 6);
            int dado2 = random.Next(1, 6);

            pictureBox1.Image = BuscarImagenDado(dado1.ToString());
            pictureBox2.Image = BuscarImagenDado(dado2.ToString());

            sumDados = ((dado1 + dado2 ) % 2).ToString();
            Jugador.Intentos = Jugador.Intentos + 1;

        }

        private Image BuscarImagenDado(string numRandom)
        {
            Image imagenSeleccionada = null;

            switch (numRandom)
            {
                case "1": imagenSeleccionada = Properties.Resources.diceOne; break;
                case "2": imagenSeleccionada = Properties.Resources.diceTwo; break;
                case "3": imagenSeleccionada = Properties.Resources.diceThree; break;
                case "4": imagenSeleccionada = Properties.Resources.diceFour; break;
                case "5": imagenSeleccionada = Properties.Resources.diceFive; break;
                case "6": imagenSeleccionada = Properties.Resources.diceSix; break;
                default:
                    break;
            }

            return imagenSeleccionada;
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            SonidoDelBoton();

            btnContinuar.Visible = false;
            btnLanzarDados.Visible = true;

            FrmPreguntas frmPreguntas = new FrmPreguntas();
            FrmProblemas frmProblemas = new FrmProblemas();

            if (sumDados == "0")
            {
                frmPreguntas.Show();
            }
            else
            {
                frmProblemas.Show();

            }
            
            this.Hide();
        }
    }
}
