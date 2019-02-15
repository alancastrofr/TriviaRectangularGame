using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace TriviaRectangularGame
{
    public partial class FrmPreguntas : Form
    {
        public FrmPreguntas()
        {
            InitializeComponent();
        }
              
        string respCorrecta;

        int tiempoMinutos = 0;
        int tiempoSegundos = 40;

        WindowsMediaPlayer wndMediaButon = new WindowsMediaPlayer();

        private void SonidoDelBoton()
        {
            wndMediaButon.URL = @"C:\soundButton.mp3";
            wndMediaButon.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SonidoDelBoton();

            if (respCorrecta == btnRespuesta1.Text)
                VMJugador.PuntosJugador = VMJugador.PuntosJugador + 1;
            
            FrmDados dados = new FrmDados();
            dados.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SonidoDelBoton();

            if (respCorrecta == btnRespuesta4.Text)
                VMJugador.PuntosJugador = VMJugador.PuntosJugador + 1;

            FrmDados dados = new FrmDados();
            dados.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SonidoDelBoton();

            if (respCorrecta == btnRespuesta2.Text)
                VMJugador.PuntosJugador = VMJugador.PuntosJugador + 1;

            FrmDados dados = new FrmDados();
            dados.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SonidoDelBoton();

            if (respCorrecta == btnRespuesta3.Text)
                VMJugador.PuntosJugador = VMJugador.PuntosJugador + 1;

            FrmDados dados = new FrmDados();
            dados.Show();
            this.Close();
        }

        private void FrmPreguntas_Load(object sender, EventArgs e)
        {
            #region CargarPreguntas
            Random rdm = new Random();
            switch (rdm.Next(1,8))
            {
                case 1: lblPregunta.Text = "Definió simulación como el proceso de diseñar y desarrollar un modelo computarizado de un sistema o proceso.";
                    btnRespuesta1.Text = "H. Maisel";
                    btnRespuesta2.Text = "Thomas Naylor";
                    btnRespuesta3.Text = "Robert E. Shannon";
                    btnRespuesta4.Text = "Ninguno de los anteriores";
                    respCorrecta = btnRespuesta3.Text;
                    break;
                case 2:
                    lblPregunta.Text = "Sirven como retroalimentación que compara el desempeño con los objetivos.";
                    btnRespuesta1.Text = "Salidas";
                    btnRespuesta2.Text = "Entradas";
                    btnRespuesta3.Text = "Sistemas expertos";
                    btnRespuesta4.Text = "Acciones";
                    respCorrecta = btnRespuesta1.Text;
                    break;
                case 3:
                    lblPregunta.Text = "Definió simulación como una técnica numérica para conducir experimentos en una computadora digital.";
                    btnRespuesta1.Text = "H. Maisel";
                    btnRespuesta2.Text = "Thomas Naylor";
                    btnRespuesta3.Text = "Robert E. Shannon";
                    btnRespuesta4.Text = "Ninguno de los anteriores";
                    respCorrecta = btnRespuesta2.Text;
                    break;
                case 4:
                    lblPregunta.Text = "Se requiere para realizar un análisis preliminar del sistema para determinar iteración de este con otros, restricciones, variables internas, etc.";
                    btnRespuesta1.Text = "Implementación";
                    btnRespuesta2.Text = "Experimentación ";
                    btnRespuesta3.Text = "Validación";
                    btnRespuesta4.Text = "Definición del Sistema";
                    respCorrecta = btnRespuesta4.Text;
                    break;
                case 5:
                    lblPregunta.Text = "Aquí se interpretan los resultados que arroja la simulación y en base a esto se toma una decisión.";
                    btnRespuesta1.Text = "Manual técnico";
                    btnRespuesta2.Text = "Interpretación";
                    btnRespuesta3.Text = "Resultados";
                    btnRespuesta4.Text = "Información gerencial";
                    respCorrecta = btnRespuesta2.Text;
                    break;
                case 6:
                    lblPregunta.Text = "Lo correcto es decir simulacro.";
                    btnRespuesta1.Text = "Simulación";
                    btnRespuesta2.Text = "Experimento";
                    btnRespuesta3.Text = "Similar";
                    btnRespuesta4.Text = "Simultaneo";
                    respCorrecta = btnRespuesta1.Text;
                    break;
                case 7:
                    lblPregunta.Text = "Es una de las etapas principales, por medio de ella es posible detallar deficiencias en la formulación del modelo o en los datos alimentados al mismo.";
                    btnRespuesta1.Text = "Documentación";
                    btnRespuesta2.Text = "Experiencia";
                    btnRespuesta3.Text = "Soporte";
                    btnRespuesta4.Text = "validación";
                    respCorrecta = btnRespuesta4.Text;
                    break;
                case 8:
                    lblPregunta.Text = "Documentación que el departamento de procesamiento de datos debe tener del modelo.";
                    btnRespuesta1.Text = "Manual de usuario";
                    btnRespuesta2.Text = "Técnico";
                    btnRespuesta3.Text = "Sistema aleatorio";
                    btnRespuesta4.Text = "Informativo";
                    respCorrecta = btnRespuesta2.Text;
                    break;
                case 9:
                    lblPregunta.Text = "Son la base de conocimiento, una máquina de inferencia que conecta al usuario con el sistema procesando consultas por medio de lenguajes.";
                    btnRespuesta1.Text = "Componentes Básicos";
                    btnRespuesta2.Text = "Tiempo";
                    btnRespuesta3.Text = "Objetivos";
                    btnRespuesta4.Text = "Entradas";
                    respCorrecta = btnRespuesta1.Text;
                    break;
                default:
                    break;
            }
            #endregion

            #region Timer
            timer1.Enabled = true;
            timer1.Interval = 40000;

            timer2.Enabled = true;
            timer2.Interval = 40000;

            timer3.Enabled = true;
            timer3.Interval = 1000;

            lblReloj.Text = "";
            #endregion
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
                tiempoMinutos = 00;

            lblReloj.Text = tiempoMinutos.ToString() + " : " + tiempoSegundos.ToString();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tiempoSegundos = tiempoSegundos - 1;

            if (tiempoSegundos < 10)
                lblReloj.ForeColor = Color.Red;


            if (tiempoSegundos == -1)
                tiempoSegundos = 60;

            lblReloj.Text = tiempoMinutos.ToString() + " : " + tiempoSegundos.ToString();

        }

        private void lblReloj_Click(object sender, EventArgs e)
        {

        }
    }
}
