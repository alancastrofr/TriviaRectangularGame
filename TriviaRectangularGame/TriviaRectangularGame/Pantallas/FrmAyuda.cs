using System;
using System.Windows.Forms;
using WMPLib;

namespace TriviaRectangularGame
{
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        WindowsMediaPlayer wndMediaButon = new WindowsMediaPlayer();

        private void SonidoDelBoton()
        {
            wndMediaButon.URL = @"C:\soundButton.mp3";
            wndMediaButon.controls.play();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            this.Text = "Instrucciones";

            label1.Text = "Las reglas: " + "\r\n" +
                          "El usuario deberá ingresar un nombre para comenzar a jugar." + "\r\n" +
                          "El usuario deberá lanzar 5 veces los dados virtuales, y responder 5 preguntas o 5 problemas." + "\r\n" +
                          "Si la suma de los dados es “par” deberá resolver una pregunta." + "\r\n" +
                          "El tiempo límite para resolver una pregunta será de 40 segundos." + "\r\n" +
                          "El jugador obtendrá 10 puntos en caso de resolver una pregunta correctamente." + "\r\n" +
                          "Si la suma de los dados es “impar” deberá resolver un problema." + "\r\n" +
                          "El tiempo límite para resolver un problema será 6 minutos." + "\r\n" +
                          "El jugador obtendrá 20 puntos en caso de resolver un problema correctamente." + "\r\n" + "\r\n" +

                          "Requisitos: " + "\r\n" +
                          "El usuario deberá tener conocimiento de la materia Modelado y Simulación de sistemas." + "\r\n" +
                          "El usuario deberá contar con el material de apoyo necesario para solucionar los problemas (calculadora, hoja en blanco, " + "\r\n" + "lápiz, tabla de valores.)";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresoInicio_Click(object sender, EventArgs e)
        {
            SonidoDelBoton();
            this.Hide();
        }
    }
}
