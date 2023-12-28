using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Oficina_IF
{
    public partial class CadastroCliente : Form
    {

        private MySqlConnection conexao;
        public CadastroCliente(MySqlConnection conexao)
        {
            InitializeComponent();
            
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

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

                string NomeCompleto = txtNomeCompleto.Text;
                string Situacao = comboSituacao.Text;
                string CPF = txtCPF.Text;
                string RG = txtRG.Text;
                string Genero = comboGenero.Text;
                string DataNascimento = dataNascimento.Value.ToString("yyyy-MM-dd");
                string EstadoCivil = txtEstadoCivil.Text;
                string Profissao = txtProfissao.Text;
                string Nacionalidade = txtNacionalidade.Text;
                string Telefone = txtTelefone.Text;
                string Celular = txtCelular.Text;
                string Whatsapp = comboWhatsApp.Text;
                string Email = txtEmail.Text;
                string Endereco = txtEndereco.Text;
                string Numero = txtNumero.Text;
                string Complemento = txtComplemento.Text;
                string Bairro = txtBairro.Text;
                string Cidade = txtCidade.Text;
                string UF = txtUF.Text;
                string CEP = txtCEP.Text;
                string Observacoes = richTextObervacoes.Text;


                comando.CommandText = "INSERT INTO Cliente (NomeCompleto, Situacao, CPF, RG, Genero, DataNascimento, EstadoCivil, Profissao, Nacionalidade, Telefone, Celular, Whatsapp, Email, Endereco, Numero, Complemento, Bairro, Cidade, UF, CEP, Observacoes) " +
                                     "VALUES ('" + NomeCompleto + "', '" + Situacao + "','" + CPF + "','" + RG + "','" + Genero + "','" + DataNascimento + "', '" + EstadoCivil + "','" + Profissao + "','" + Nacionalidade + "','" + Telefone + "','" + Celular + "','" + Whatsapp + "','" + Email + "','" + Endereco + "','" + Numero + "', '" + Complemento + "','" + Bairro + "','" + Cidade + "','" + UF + "','" + CEP + "','" + Observacoes + "')";
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro inserido!");
                comando.Dispose();
                txtNomeCompleto.Clear();
                comboSituacao.SelectedIndex = -1; 
                txtCPF.Clear();
                txtRG.Clear();
                comboGenero.SelectedIndex = -1; 
                txtEstadoCivil.Clear();
                txtProfissao.Clear();
                txtNacionalidade.Clear();
                txtTelefone.Clear();
                txtCelular.Clear();
                comboWhatsApp.SelectedIndex = -1; 
                txtEmail.Clear();
                txtEndereco.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtUF.Clear();
                txtCEP.Clear();
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
    }
}
