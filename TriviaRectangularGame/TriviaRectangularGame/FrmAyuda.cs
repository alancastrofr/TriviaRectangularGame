using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaRectangularGame
{
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            label1.Text = "Las reglas serán: " +
"El usuario deberá ingresar un nombre para comenzar a jugar." +
"El usuario deberá lanzar 5 veces los dados virtuales, y responder 5 preguntas o 5 problemas." +
"Si la suma de los dados es “par” deberá resolver una pregunta." +
"El tiempo límite para resolver una pregunta será de 40 segundos." +
"El jugador obtendrá 10 puntos en caso de resolver una pregunta correctamente." +
"Si la suma de los dados es “impar” deberá resolver un problema." +
"El tiempo límite para resolver un problema será 6 minutos." +
"El jugador obtendrá 20 puntos en caso de resolver un problema correctamente." +

"Requisitos" +

"El usuario deberá tener conocimiento de la materia Modelado y Simulación de sistemas." +
"El usuario deberá contar con el material de apoyo necesario para solucionar los problemas(calculadora, hoja en blanco, lápiz, tabla de valores)";
        }
    }
}
