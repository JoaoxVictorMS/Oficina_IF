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
    public partial class CadastroUsuario : Form
    {

        private MySqlConnection conexao;
        public CadastroUsuario(MySqlConnection conexao)
        {
            InitializeComponent();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Close();
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
                string Usuario = txtUsuário.Text;
                string Senha = txtSenha.Text;
                string Situacao = comboSituacao.Text;


                comando.CommandText = "INSERT INTO Usuario (NomeCompleto, Usuario, Senha, Situacao) VALUES ('" + NomeCompleto + "', '" + Usuario + "', '" + Senha + "', '" + Situacao + "');";
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro inserido!");
                comando.Dispose();
                txtNomeCompleto.Clear();
                txtUsuário.Clear();
                txtSenha.Clear();
                comboSituacao.SelectedIndex = -1;
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
    }
}
