using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina_IF
{
    public partial class RegistroVenda : Form
    {

        private MySqlConnection conexao;
        public RegistroVenda(MySqlConnection conexao)
        {
            InitializeComponent();
            conexao = new MySqlConnection("server=localhost;User Id=root;database=Oficina;password=");
            this.conexao = conexao;
        }

        private void RegistroVenda_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();

                // Carregar dados dos clientes nos ComboBoxes
                MySqlCommand comandoClientes = new MySqlCommand("SELECT NomeCompleto FROM Cliente", conexao);
                MySqlDataReader readerClientes = comandoClientes.ExecuteReader();

                while (readerClientes.Read())
                {
                    string nomeCliente = readerClientes.GetString(0); // Use o índice da coluna
                    comboCliente.Items.Add(nomeCliente);
                }

                readerClientes.Close();

                // Carregar dados dos usuários nos ComboBoxes
                MySqlCommand comandoUsuarios = new MySqlCommand("SELECT Usuario FROM Usuario", conexao);
                MySqlDataReader readerUsuarios = comandoUsuarios.ExecuteReader();

                while (readerUsuarios.Read())
                {
                    string nomeUsuario = readerUsuarios.GetString(0); // Use o índice da coluna
                    comboUsuario.Items.Add(nomeUsuario);
                }

                readerUsuarios.Close();

                // Carregar dados dos serviços nos ComboBoxes
                MySqlCommand comandoServicos = new MySqlCommand("SELECT descricao FROM Servico", conexao);
                MySqlDataReader readerServicos = comandoServicos.ExecuteReader();

                while (readerServicos.Read())
                {
                    string descricaoServico = readerServicos.GetString(0); // Use o índice da coluna
                    comboServico.Items.Add(descricaoServico);
                }

                readerServicos.Close();
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



        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            if (comboCliente.SelectedItem == null || comboUsuario.SelectedItem == null || comboServico.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um cliente, um usuário e um serviço.");
                return;
            }

            try
            {
                conexao.Open();

                string descricaoServicoSelecionado = comboServico.SelectedItem.ToString();
                MySqlCommand comandoVerificarServico = new MySqlCommand($"SELECT situacao FROM Servico WHERE descricao = '{descricaoServicoSelecionado}'", conexao);
                string situacaoServico = comandoVerificarServico.ExecuteScalar()?.ToString();

                if (situacaoServico != null && situacaoServico.Equals("inativo", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Este serviço não pode ser comercializado, pois está marcado como inativo.");
                    return;
                }

                // Obter o ID do Cliente selecionado
                MySqlCommand comandoClienteId = new MySqlCommand($"SELECT IdCliente FROM Cliente WHERE NomeCompleto = '{comboCliente.SelectedItem}'", conexao);
                int idCliente = Convert.ToInt32(comandoClienteId.ExecuteScalar());

                // Obter o ID do Usuário selecionado
                MySqlCommand comandoUsuarioId = new MySqlCommand($"SELECT IdUsuario FROM Usuario WHERE Usuario = '{comboUsuario.SelectedItem}'", conexao);
                int idUsuario = Convert.ToInt32(comandoUsuarioId.ExecuteScalar());

                // Obter o ID do Serviço selecionado
                MySqlCommand comandoServicoId = new MySqlCommand($"SELECT IdServico FROM Servico WHERE descricao = '{descricaoServicoSelecionado}'", conexao);
                int idServico = Convert.ToInt32(comandoServicoId.ExecuteScalar());

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                string DatadeVenda = dataVenda.Value.ToString("yyyy-MM-dd");
                decimal Subtotal = numericSubtotal.Value;
                decimal Desconto = numericDesconto.Value;
                decimal ValorTotal = numericValorTotal.Value;
                string FormaPagamento = comboPagamento.Text;
                string Situacao = comboSituacao.Text;
                string Observacoes = richTextObervacoes.Text;

                // Usar os IDs obtidos para inserir na tabela Vendas
                comando.CommandText = $"INSERT INTO Vendas (IdCliente, IdUsuario, IdServico, DatadeVenda, Subtotal, Desconto, ValorTotal, FormaPagamento, Situacao, Observacoes) VALUES ({idCliente}, {idUsuario}, {idServico}, '{DatadeVenda}', {Subtotal}, {Desconto}, {ValorTotal}, '{FormaPagamento}', '{Situacao}', '{Observacoes}')";

                comando.ExecuteNonQuery();
                MessageBox.Show("Registro inserido!");
                comando.Dispose();
                dataVenda.Value = DateTime.Now;
                numericSubtotal.Value = 0;
                numericDesconto.Value = 0;
                numericValorTotal.Value = 0;
                comboPagamento.SelectedIndex = -1;
                comboSituacao.SelectedIndex = -1;
                richTextObervacoes.Clear();
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


        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Close();
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
