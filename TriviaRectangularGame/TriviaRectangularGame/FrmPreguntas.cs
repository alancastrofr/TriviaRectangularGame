﻿using System;
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
    public partial class FrmPreguntas : Form
    {
        public FrmPreguntas()
        {
            InitializeComponent();
        }
               

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDados dados = new FrmDados();
            dados.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDados dados = new FrmDados();
            dados.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDados dados = new FrmDados();
            dados.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FrmDados dados = new FrmDados();
            dados.Show();
            this.Close();
        }
    }
}
