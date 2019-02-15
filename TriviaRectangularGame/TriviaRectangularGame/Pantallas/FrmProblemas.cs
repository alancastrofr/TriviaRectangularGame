using System;
using System.Windows.Forms;
using WMPLib;

namespace TriviaRectangularGame
{
    public partial class FrmProblemas : Form
    {
        public FrmProblemas()
        {
            InitializeComponent();
        }

        string respCorrecta;

        int tiempoMinutos = 6;
        int tiempoSegundos = 00;

        WindowsMediaPlayer wndMediaButon = new WindowsMediaPlayer();

        private void SonidoDelBoton()
        {
            wndMediaButon.URL = @"C:\soundButton.mp3";
            wndMediaButon.controls.play();
        }

        private void FrmProblemas_Load(object sender, EventArgs e)
        {
            btnSi.Text = "Los números rectangulares son aceptados";
            btnNo.Text = "Los números rectangulares NO son aceptados";
            
            #region CargarPreguntas
            Random rdm = new Random();

            switch (rdm.Next(1, 6))
            {
                case 1:
                    lblFrecuencia.Text = "Prueba de Frecuencias - Considerando α= 5%, n= 4." + "\r\n" + "0.03991   0.17546   0.24122   0.03788   0.4822"; respCorrecta = btnNo.Text; break;
                case 2:
                    lblFrecuencia.Text = "Prueba de Frecuencias - Considerando α= 5%, n= 4." + "\r\n" + " 0.15551   0.31454   0.81002   0.48825   0.01010   0.26266   0.34999   0.70000   0.31774   0.07222"; respCorrecta = btnSi.Text; break;
                case 3:
                    lblFrecuencia.Text = "Prueba de Frecuencias - Considerando α= 10%, n= 2. " + "\r\n" + " 0.15551   0.31454   0.81002   0.48825   0.01010   0.26266   0.34999   0.70000   0.31774   0.07222"; respCorrecta = btnNo.Text; break;
                case 4:
                    lblFrecuencia.Text = "Considerando α= 5%, n= 4. " + "\r\n" + " 0.33014   0.61149   0.77523   0.04047   0.43338   0.00025   0.11283   0.97214   0.68681   0.11489"; respCorrecta = btnSi.Text; break;
                case 5:
                    lblFrecuencia.Text = "Prueba KS - Considerando α= 5%. " + "\r\n" + " 0.19906   0.23115   0.05551   0.85476   0.16886"; respCorrecta = btnNo.Text; break;
                case 6:
                    lblFrecuencia.Text = "Prueba KS – Considerando α= 10%." + "\r\n" + " 0.03991   0.17546   0.48228   0.24122   0.03788"; respCorrecta = btnNo.Text; break;
                default:
                    lblFrecuencia.Text = "Prueba de Series – Considerando α= 50%. " + "\r\n" + " n= 2, 0.19906   0.23115   0.05551   0.85476   0.16886"; respCorrecta = btnSi.Text; break;
            }
            #endregion

            #region Timer
            timer1.Enabled = true;
            timer1.Interval = 600000;

            timer2.Enabled = true;
            timer2.Interval = 62000;

            timer3.Enabled = true;
            timer3.Interval = 1000;

            lblReloj.Text = "";
            #endregion

        }       

        private void btnSi_Click(object sender, EventArgs e)
        {
            SonidoDelBoton();

            if (respCorrecta == btnSi.Text)
                VMJugador.PuntosJugador = VMJugador.PuntosJugador + 1;

            FrmDados dados = new FrmDados();
            dados.Show();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            SonidoDelBoton();

            if (respCorrecta == btnNo.Text)
                VMJugador.PuntosJugador = VMJugador.PuntosJugador + 1;

            FrmDados dados = new FrmDados();
            dados.Show();
            this.Close();
        }

        private void lblFrecuencia_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            FrmDados frmdados = new FrmDados();
            frmdados.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tiempoMinutos = tiempoMinutos - 1;

            if (tiempoMinutos == -1)
                tiempoMinutos = 0;

            lblReloj.Text = tiempoMinutos.ToString() + " : " + tiempoSegundos.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (tiempoMinutos == 6)
            {
                tiempoMinutos = tiempoMinutos - 1;
            }

            tiempoSegundos = tiempoSegundos - 1;

            if (tiempoSegundos == -1)
                tiempoSegundos = 59;

            lblReloj.Text = tiempoMinutos.ToString() + " : " + tiempoSegundos.ToString();
        }
    }
}
