using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Projeto1M2
{
    public partial class frm_Cadastro : Form
    {
        Cadastroo pessoa = new Cadastroo(); // Instância do objeto Cadastroo
        public frm_Cadastro()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelTopo.BackColor = Color.FromArgb(135, 206, 250); //Personalizar cores do painel manualmente
            panelCentro.BackColor = Color.FromArgb(220, 220, 220);
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Botão para registrar todos os campos do forms CadastroPrincipal
            pessoa.setSenha(txtSenha.Text);
            pessoa.setRepitaSenha(txtConfirmeSenha.Text);
            //Condição para validar se campo senha é igual ao repita senha
            if (!pessoa.validarSenhas()) {
                MessageBox.Show("Senhas não compatíveis");
                return; 
            }
            pessoa.setUsuario(txtUsuario.Text);
            pessoa.setNome(txtNome.Text);
            pessoa.setSobrenome(txtSobrenome.Text);
            pessoa.setEmail(txtEmail.Text);
            pessoa.setOcupacao(cbxOcupacao.Text);
            pessoa.setPais(cbxPais.Text);
            pessoa.setEstado(cbxEstado.Text);
            pessoa.setCidade(cbxCidade.Text);
            pessoa.setCPF(txtCPF.Text);
            pessoa.setEscolaridade(cbxEscolaridade.Text);
            pessoa.setAreaFormacao(cbxAreaFormacao.Text);
           
            //Banco de dados mySQL
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=cadastro_cliente; password=''");
            MySqlCommand sqlQuery = new MySqlCommand("INSERT INTO dados_formularios (usuario, senha, nome, sobrenome, email,ocupacao, pais" +
                                                             ", estado, cidade, cpf, escolaridade, area_Formacao)" +
                                                             "VALUES('" + pessoa.getUsuario() + "','" + pessoa.getSenha() + "','" + pessoa.getNome() + "','" +
                                                                         pessoa.getSobrenome() + "','" + pessoa.getEmail() + "','" + pessoa.getOcupacao() + "','" +
                                                                         pessoa.getPais() + "','" + pessoa.getEstado() + "','" + pessoa.getCidade() + "','" +
                                                                         pessoa.getCPF() + "','" + pessoa.getEscolaridade() + "','" + pessoa.getAreaFormacao() + "')", conexao);
            try
            {
                conexao.Open();
                sqlQuery.ExecuteNonQuery();
                MessageBox.Show("Dados armazenados com sucesso dentro do banco de dados!", "Salvar dados MySQL ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro mySQL verifique mensagem " + ex, "Verificar mySQL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
