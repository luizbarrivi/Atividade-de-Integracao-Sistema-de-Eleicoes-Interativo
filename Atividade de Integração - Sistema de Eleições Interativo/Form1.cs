using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividade_de_Integração___Sistema_de_Eleições_Interativo.Forms;

namespace Atividade_de_Integração___Sistema_de_Eleições_Interativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            FormCadastroCandidatos form = new FormCadastroCandidatos();
            form.ShowDialog();
        }

        private void btVotacao_Click(object sender, EventArgs e)
        {
            FormVotacao form = new FormVotacao();
            form.ShowDialog();
        }

        private void btResultados_Click(object sender, EventArgs e)
        {
            FormResultados form = new FormResultados();
            form.ShowDialog();
        }
    }
}
