using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercicio20
{
    public partial class Exibicao : Form
    {
        string txt;   
        public Exibicao(string texto)
        {
            txt = texto;
            InitializeComponent();
           
        }

        private void Exibicao_Load(object sender, EventArgs e)
        {
            textBox1.Text = txt;
        }
    }
}
