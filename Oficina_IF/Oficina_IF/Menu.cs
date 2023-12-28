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
    public partial class Menu : Form
    {

        private MySqlConnection conexao;
        private bool conexaoEstabelecida = false;
        public Menu()
        {
            InitializeComponent();
            conexao = new MySqlConnection("server=localhost;User Id=root;database=Oficina;password=");     
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Login f = new Login();

            //while (CadastroUsuarios.UsuarioLogado == null)
            //{
            //    Visible = false; //this.Visible
            //    f.ShowDialog();

            //    if (Login.Cancelar == true)
            //    {
            //        Application.Exit();
            //        return;
            //    }
            //}

            
            //Visible = true;
        }


        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            if (conexao == null || conexao.State != ConnectionState.Open)
            {
                MessageBox.Show("Por favor, conecte-se ao banco de dados primeiro");
                return;
            } else
            {
                CadastroCliente f = new CadastroCliente(conexao);
                f.Show();
                this.Hide();

            }

        }


        private void btnCadastroServico_Click(object sender, EventArgs e)
        {
            if (conexao == null || conexao.State != ConnectionState.Open)
            {
                MessageBox.Show("Por favor, conecte-se ao banco de dados primeiro");
                return;
            } else 
            {
                CadastroServico f = new CadastroServico(conexao);
                f.Show();
                this.Hide();
            }
        }

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            if (conexao == null || conexao.State != ConnectionState.Open)
            {
                MessageBox.Show("Por favor, conecte-se ao banco de dados primeiro");
                return;
            }
         
            try
            {
                //conexao.Open();

                MySqlCommand comandoClientes = new MySqlCommand("SELECT COUNT(*) FROM Cliente", conexao);
                MySqlCommand comandoUsuarios = new MySqlCommand("SELECT COUNT(*) FROM Usuario", conexao);
                MySqlCommand comandoServicos = new MySqlCommand("SELECT COUNT(*) FROM Servico", conexao);

                int totalClientes = Convert.ToInt32(comandoClientes.ExecuteScalar());
                int totalUsuarios = Convert.ToInt32(comandoUsuarios.ExecuteScalar());
                int totalServicos = Convert.ToInt32(comandoServicos.ExecuteScalar());

                if (totalClientes == 0 || totalUsuarios == 0 || totalServicos == 0)
                {
                    string mensagem = "É necessário cadastrar pelo menos:\n";
                    if (totalClientes == 0)
                    {
                        mensagem += "- Um cliente\n";
                    }
                    if (totalUsuarios == 0)
                    {
                        mensagem += "- Um usuário\n";
                    }
                    if (totalServicos == 0)
                    {
                        mensagem += "- Um serviço\n";
                    }

                    MessageBox.Show(mensagem);
                }
                else
                {
                    RegistroVenda f = new RegistroVenda(conexao);
                    f.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

    

        private void btnSair_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }


        
        private void btnConectarBancoDeDados_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "server=localhost;User Id=root;database=Oficina;password=";
                conexao = new MySqlConnection(strConn);
                conexao.Open();
                MessageBox.Show("Conectado ao banco de dados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar\n" + ex);
            }
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            if (conexao == null || conexao.State != ConnectionState.Open)
            {
                MessageBox.Show("Por favor, conecte-se ao banco de dados primeiro");
                return;
            }
            else
            {
                CadastroUsuario f = new CadastroUsuario(conexao);
                f.Show();
                this.Hide();
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            if (conexao == null || conexao.State != ConnectionState.Open)
            {
                MessageBox.Show("Por favor, conecte-se ao banco de dados primeiro");
                return;
            }
            else
            {
                Consultas f = new Consultas(conexao);
                f.Show();
                this.Hide();
            }
        }
    }
}
