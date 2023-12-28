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
    public partial class Consultas : Form
    {

        private MySqlConnection conexao;
        public Consultas(MySqlConnection conexao)
        {
            InitializeComponent();
        }

        private void btnListaServicos_Click(object sender, EventArgs e)
        {
            dataGridServicos.Rows.Clear();
            string strConn = "server=localhost;User Id=root;database=Oficina;password=";
            MySqlConnection conexao = new MySqlConnection(strConn);

            try
            {
                int idSelecionado = (int)numericIdCliente.Value; // Obtém o número escolhido no NumericUpDown

                string query = "SELECT * from Servico";

                // Se nenhum número for selecionado (o valor do NumericUpDown for zero), selecione todos os registros
                if (idSelecionado != 0)
                {
                    query = $"SELECT * from Servico WHERE IdServico = {idSelecionado}"; // Seleciona apenas o registro correspondente ao ID escolhido
                }

                DataTable dados = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConn);
                conexao.Open();
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dataGridServicos.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                dataGridServicos.Rows.Clear();
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            dataGridClientes.Rows.Clear();
            string strConn = "server=localhost;User Id=root;database=Oficina;password=";
            MySqlConnection conexao = new MySqlConnection(strConn);

            try
            {
                string nomeSelecionado = richNomeCliente.Text; // Obtém o nome escolhido na caixa de texto

                string query = "SELECT * from Cliente";

                // Se nenhum nome for selecionado (campo em branco), selecione todos os registros
                if (string.IsNullOrWhiteSpace(nomeSelecionado))
                {
                    query = "SELECT * from Cliente"; // Seleciona todos os registros da tabela Cliente
                }
                else
                {
                    query = $"SELECT * from Cliente WHERE NomeCompleto LIKE '%{nomeSelecionado}%'"; // Seleciona apenas os registros correspondentes ao nome
                }

                DataTable dados = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConn);
                conexao.Open();
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dataGridClientes.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                dataGridClientes.Rows.Clear();
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void btnListaUsuarios_Click(object sender, EventArgs e)
        {
            dataGridUsuario.Rows.Clear();
            string strConn = "server=localhost;User Id=root;database=Oficina;password=";
            MySqlConnection conexao = new MySqlConnection(strConn);

            try
            {
                string usuarioSelecionado = richUsername.Text; // Obtém o nome de usuário escolhido na caixa de texto

                string query = "SELECT * from Usuario";

                // Se nenhum nome de usuário for especificado (campo em branco), selecione todos os registros
                if (string.IsNullOrWhiteSpace(usuarioSelecionado))
                {
                    query = "SELECT * from Usuario"; // Seleciona todos os registros da tabela Usuario
                }
                else
                {
                    query = $"SELECT * from Usuario WHERE Usuario LIKE '%{usuarioSelecionado}%'"; // Seleciona apenas os registros correspondentes ao nome de usuário
                }

                DataTable dados = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConn);
                conexao.Open();
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dataGridUsuario.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                dataGridUsuario.Rows.Clear();
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void btnListaVendas_Click(object sender, EventArgs e)
        {
            dataGridVenda.Rows.Clear();
            string strConn = "server=localhost;User Id=root;database=Oficina;password=";
            MySqlConnection conexao = new MySqlConnection(strConn);

            try
            {
                int vendaSelecionada = (int)numericIdServico.Value; // Obtém o número de venda escolhido no numericUpDown

                string query = "SELECT * from Vendas";

                // Se nenhum número de venda for especificado (campo em branco), selecione todos os registros
                if (vendaSelecionada == 0)
                {
                    query = "SELECT * from Vendas"; // Seleciona todos os registros da tabela Vendas
                }
                else
                {
                    query = $"SELECT * from Vendas WHERE IdVenda = {vendaSelecionada}"; // Seleciona apenas os registros correspondentes ao número de venda
                }

                DataTable dados = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConn);
                conexao.Open();
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dataGridVenda.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                dataGridVenda.Rows.Clear();
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Close();
        }
    }
}
