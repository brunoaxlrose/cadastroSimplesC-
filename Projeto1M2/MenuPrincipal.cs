using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto1M2
{
    public partial class frm_MenuPrincipal : Form
    {

        //Disciplina: Ldgica de programação
        //professor:  ADilson Lima
        //Atividade: M2 - Ativ.1
        //Autor: Bruno Lucas Alcantara De Oliveira 
        //Site: https://telelab.aids.gov.br/index.php/cadastro
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelTopo.BackColor = Color.FromArgb(135, 206, 250);  //Cor de fundo para a parte do topo no título
        }

        private void btnCadastrar_Click(object sender, EventArgs e) // abre a tela Cadastrar 
        {

            frm_Cadastro telaCadastro = new frm_Cadastro();
            telaCadastro.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e) // abre a tela Consultar 
        {

            frm_Consultar telaConsulta = new frm_Consultar();
            telaConsulta.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e) // botão de sair, ao clicar abre caixa de dialogo para fechar ou não aplicação.
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Sair",

              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
