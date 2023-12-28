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
    public partial class Login : Form
    {

        public static bool Cancelar = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (CadastroUsuarios.Login(usuario, senha))
            {
                Menu f = new Menu();
                f.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Application.Exit(); 
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
