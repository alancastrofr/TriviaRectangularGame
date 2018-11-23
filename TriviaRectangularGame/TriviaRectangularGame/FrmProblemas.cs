using System;
using System.Windows.Forms;

namespace TriviaRectangularGame
{
    public partial class FrmProblemas : Form
    {
        public FrmProblemas()
        {
            InitializeComponent();
        }

        string respCorrecta;
        int tiempo = 0;

        private void FrmProblemas_Load(object sender, EventArgs e)
        {
            btnSi.Text = "Los números rectangulares son aceptados";
            btnNo.Text = "Los números rectangulares NO son aceptados";
            lblProblema.Text = "";
            #region CargarPreguntas
            Random rdm = new Random();

            switch (rdm.Next(1, 6))
            {
                case 1:
                    lblFrecuencia.Text = "Prueba de Frecuencias - Considerando α= 5%, n= 4, 0.03991   0.17546   0.24122   0.03788   0.4822"; respCorrecta = btnNo.Text; break;
                case 2:
                    lblFrecuencia.Text = "Prueba de Frecuencias - Considerando α= 5%, n= 4, 0.15551   0.31454   0.81002   0.48825   0.01010   0.26266   0.34999   0.70000   0.31774   0.07222"; respCorrecta = btnSi.Text; break;
                case 3:
                    lblFrecuencia.Text = "Prueba de Frecuencias - Considerando α= 10%, n= 2, 0.15551   0.31454   0.81002   0.48825   0.01010   0.26266   0.34999   0.70000   0.31774   0.07222"; respCorrecta = btnNo.Text; break;
                case 4:
                    lblFrecuencia.Text = "Considerando α= 5%, n= 4, 0.33014   0.61149   0.77523   0.04047   0.43338   0.00025   0.11283   0.97214   0.68681   0.11489"; respCorrecta = btnSi.Text; break;
                case 5:
                    lblFrecuencia.Text = "Prueba KS - Considerando α= 5%, 0.19906   0.23115   0.05551   0.85476   0.16886"; respCorrecta = btnNo.Text; break;
                case 6:
                    lblFrecuencia.Text = "Prueba KS – Considerando α= 10%, 0.03991   0.17546   0.48228   0.24122   0.03788"; respCorrecta = btnNo.Text; break;
                default:
                    lblFrecuencia.Text = "Prueba de Series – Considerando α= 50%, n= 2, 0.19906   0.23115   0.05551   0.85476   0.16886"; respCorrecta = btnSi.Text; break;
            }            
            #endregion

            #region Timer
            timer1.Enabled = true;
            timer1.Interval = 10000;

            timer2.Enabled = true;
            timer2.Interval = 1000;

            label1.Text = "";
            #endregion

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            FrmDados frmdados = new FrmDados();
            frmdados.Show();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            if (respCorrecta == btnSi.Text)
                Jugador.PuntosJugador = Jugador.PuntosJugador + 1;

            FrmDados dados = new FrmDados();
            dados.Show();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (respCorrecta == btnNo.Text)
                Jugador.PuntosJugador = Jugador.PuntosJugador + 1;

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

        private void timer2_Tick(object sender, EventArgs e)
        {
            tiempo = tiempo + 1;
            label1.Text = tiempo.ToString() + "seg";
        }
    }
}
