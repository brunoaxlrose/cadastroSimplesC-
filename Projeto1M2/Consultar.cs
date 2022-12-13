using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace Projeto1M2
{
    public partial class frm_Consultar : Form
    {
        public frm_Consultar()
        {
            InitializeComponent();
        }
        private void Consultar_Load(object sender, EventArgs e)
        {
            //Banco de dados mySQL
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=cadastro_cliente; password=''"); // caminho para a conexão do meu banco de dados
            MySqlCommand sqlQuery = new MySqlCommand("SELECT * FROM dados_formularios WHERE  1",  conexao); // comando para selecionar da tabela dados_formulario
            try
            {
                conexao.Open(); // Abre a Conexão
                MySqlDataReader datReader = sqlQuery.ExecuteReader();

                while (datReader.Read())
                {
                    object[] registro = new object[datReader.FieldCount];

                    // Cabeçalho do DataGrid
                    if (dataGridView1.Rows.Count == 0)
                    {
                        for (int i = 0; i < datReader.FieldCount; i++)
                        {
                            dataGridView1.Columns.Add(datReader.GetName(i), datReader.GetName(i));
                        }
                    }
                    // Traz o registro.
                    for (int i = 0; i < datReader.FieldCount; i++)
                    {
                        registro[i] = datReader.GetValue(i); // monta o registro.                        
                    }
                    dataGridView1.Rows.Add(registro); // Adiciona a linha
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "ERRO Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
