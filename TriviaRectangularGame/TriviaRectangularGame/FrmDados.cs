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
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            btnContinuar.Visible = false;
            btnLanzarDados.Visible = true;

            FrmPreguntas frm = new FrmPreguntas();
            frm.Show();
            this.Close();
        }
    }
}
