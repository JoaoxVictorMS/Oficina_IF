using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Oficina_IF
{
    public partial class BoasVindas : Form
    {
        public static bool Cancelar = false;

        public BoasVindas()
        {
            InitializeComponent();
        }

        private void BoasVindas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Application.Exit();
        }
    }
}
