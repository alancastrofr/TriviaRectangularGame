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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        FrmDados frmDados = new FrmDados();

        private void button1_Click(object sender, EventArgs e)
        {
            frmDados.nomberUsuario = txtNombreUsuario.Text;
            frmDados.Show();
            this.Hide();
        }
    }
}
