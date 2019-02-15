using System;
using System.Windows.Forms;
using WMPLib;

namespace TriviaRectangularGame
{
    public partial class FrmFinal : Form
    {
        public FrmFinal()
        {
            InitializeComponent();
        }

        WindowsMediaPlayer wndMediaButon = new WindowsMediaPlayer();
        WindowsMediaPlayer wndMediaAplausos = new WindowsMediaPlayer();

        private void SonidoDelBoton()
        {
            wndMediaButon.URL = @"C:\soundButton.mp3";
            wndMediaButon.controls.play();
        }

        private void Aplausos()
        {
            wndMediaButon.URL = @"C:\aplausos_4.mp3";
            wndMediaButon.controls.play();
        }

        private void FrmFinal_Load(object sender, EventArgs e)
        {
            Aplausos();
            label1.Text = VMJugador.PuntosJugador.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VMJugador.Intentos = 0;
            VMJugador.NombreUsuario = "";
            VMJugador.PuntosJugador = 0;

            SonidoDelBoton();
            FrmInicio frm = new FrmInicio();
            frm.Show();
            this.Hide();
        }
    }
}
