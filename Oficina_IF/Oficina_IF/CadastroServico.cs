using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Oficina_IF
{
    public partial class CadastroServico : Form
    {

        private MySqlConnection conexao;
        public CadastroServico(MySqlConnection conexao)
        {
            InitializeComponent();
        }

        
        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            string strConn = "server=localhost;User Id=root;database=Oficina;password=";
            MySqlConnection conexao = new MySqlConnection(strConn);
            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                string descricao = txtDesc.Text;
                int duracao_minutos = (int)numericDuracao.Value;
                string situacao = comboSituacao.Text;
                decimal valor = numericValor.Value;
                

                comando.CommandText = "INSERT INTO Servico (descricao, duracao_minutos, situacao, valor) VALUES ('" + descricao + "', " + duracao_minutos + ", '" + situacao + "', " + valor + ");";
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro inserido!");
                comando.Dispose();
                txtDesc.Clear();
                numericDuracao.Value = 0;
                numericValor.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void numericDuracao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateDataCadastro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string situacaoSelecionada = comboSituacao.SelectedItem.ToString();
        }

        
        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Close();
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroServico_Load(object sender, EventArgs e)
        {

        }
    }
}
