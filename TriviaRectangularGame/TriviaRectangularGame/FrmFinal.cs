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
    public partial class FrmFinal : Form
    {
        public FrmFinal()
        {
            InitializeComponent();
        }

        private void FrmFinal_Load(object sender, EventArgs e)
        {
            label1.Text = Jugador.PuntosJugador.ToString();
        }
    }
}
