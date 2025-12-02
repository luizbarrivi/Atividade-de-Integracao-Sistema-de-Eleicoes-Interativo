using Atividade_de_Integração___Sistema_de_Eleições_Interativo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Atividade_de_Integração___Sistema_de_Eleições_Interativo.Forms
{
    public partial class FormCadastroCandidatos : Form
    {
        List<Candidato> listaCandidatos = new List<Candidato>();
        public FormCadastroCandidatos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Candidato objCandidato = new Candidato();
            objCandidato.nomeCompleto = txtNomeComp.Text;
            objCandidato.nomeApelido = txtNomeExibi.Text;
            objCandidato.numeroCandidato = Convert.ToInt32(txtNumero.Text);
            objCandidato.partido = txtPartido.Text;

            listaCandidatos.Add(objCandidato);
            MessageBox.Show("Salvo com sucesso!", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNomeComp.Clear(); txtNomeExibi.Clear(); txtNumero.Clear(); txtPartido.Clear();

            txtNomeComp.Select();

            var pasta = new XLWorkbook("C:\\Users\\Augusto Linhares\\Desktop\\RegistroCandidato");

            var plan = pasta.Worksheet(1); //selecionei a planilha 1

            int qtdLinhas = plan.RowsUsed().Count();//quantas linhas estão sendo usadas


            int linhaLivre = qtdLinhas + 1;

            plan.Cell(linhaLivre, 1).Value = linhaLivre - 1;

            plan.Cell(linhaLivre, 2).Value = objCandidato.nomeCompleto;
            plan.Cell(linhaLivre, 3).Value = objCandidato.nomeApelido;
            plan.Cell(linhaLivre, 4).Value = objCandidato.numeroCandidato;
            plan.Cell(linhaLivre, 5).Value = objCandidato.partido;

            pasta.Save();
        }
    }
}
