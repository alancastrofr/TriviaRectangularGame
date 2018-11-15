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
    public partial class FrmDados : Form
    {
        public FrmDados()
        {
            InitializeComponent();
        }

        public string nomberUsuario;

        private void FrmDados_Load(object sender, EventArgs e)
        {            
            lblNombreUsuario.Text = nomberUsuario;
            btnLanzarDados.Text = "Lanzar";
            btnContinuar.Visible = false;
        }

        private void btnLanzarDados_Click(object sender, EventArgs e)
        {
            btnContinuar.Text = "Continuar";
            btnContinuar.Visible = true;
            btnLanzarDados.Visible = false;

            Random random = new Random();
            textBox1.Text = random.Next(1, 6).ToString();
            textBox2.Text = random.Next(1, 6).ToString();
            pictureBox1.Image = BuscarImagenDado(textBox1.Text);
            pictureBox2.Image = BuscarImagenDado(textBox2.Text);
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
            btnContinuar.Visible = false;
            btnLanzarDados.Visible = true;

            FrmPreguntas frm = new FrmPreguntas();
            frm.Show();
            this.Hide();
        }
    }
}
