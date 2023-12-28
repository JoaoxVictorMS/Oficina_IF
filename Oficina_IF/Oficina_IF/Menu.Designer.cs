namespace Oficina_IF
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnCadastroServico = new System.Windows.Forms.Button();
            this.btnRegistrarVenda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConectarBancoDeDados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Location = new System.Drawing.Point(69, 345);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(176, 51);
            this.btnCadastroCliente.TabIndex = 2;
            this.btnCadastroCliente.Text = "Cadastrar cliente";
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnCadastroServico
            // 
            this.btnCadastroServico.Location = new System.Drawing.Point(69, 277);
            this.btnCadastroServico.Name = "btnCadastroServico";
            this.btnCadastroServico.Size = new System.Drawing.Size(176, 51);
            this.btnCadastroServico.TabIndex = 3;
            this.btnCadastroServico.Text = "Cadastrar serviço";
            this.btnCadastroServico.UseVisualStyleBackColor = true;
            this.btnCadastroServico.Click += new System.EventHandler(this.btnCadastroServico_Click);
            // 
            // btnRegistrarVenda
            // 
            this.btnRegistrarVenda.Location = new System.Drawing.Point(69, 482);
            this.btnRegistrarVenda.Name = "btnRegistrarVenda";
            this.btnRegistrarVenda.Size = new System.Drawing.Size(176, 51);
            this.btnRegistrarVenda.TabIndex = 4;
            this.btnRegistrarVenda.Text = "Registrar Venda";
            this.btnRegistrarVenda.UseVisualStyleBackColor = true;
            this.btnRegistrarVenda.Click += new System.EventHandler(this.btnRegistrarVenda_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(69, 620);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(176, 51);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConectarBancoDeDados
            // 
            this.btnConectarBancoDeDados.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConectarBancoDeDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConectarBancoDeDados.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectarBancoDeDados.ForeColor = System.Drawing.Color.Red;
            this.btnConectarBancoDeDados.Location = new System.Drawing.Point(27, 160);
            this.btnConectarBancoDeDados.Name = "btnConectarBancoDeDados";
            this.btnConectarBancoDeDados.Size = new System.Drawing.Size(265, 87);
            this.btnConectarBancoDeDados.TabIndex = 6;
            this.btnConectarBancoDeDados.Text = "Conectar ao Banco de Dados";
            this.btnConectarBancoDeDados.UseVisualStyleBackColor = false;
            this.btnConectarBancoDeDados.Click += new System.EventHandler(this.btnConectarBancoDeDados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conecte ao banco de dados primeiro";
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.Location = new System.Drawing.Point(69, 412);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(176, 51);
            this.btnCadastroUsuario.TabIndex = 8;
            this.btnCadastroUsuario.Text = "Cadastrar usuário";
            this.btnCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.btnCadastroUsuario_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(69, 552);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(176, 51);
            this.btnConsultas.TabIndex = 9;
            this.btnConsultas.Text = "Tela de consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 749);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnCadastroUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConectarBancoDeDados);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRegistrarVenda);
            this.Controls.Add(this.btnCadastroServico);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastroServico;
        private System.Windows.Forms.Button btnRegistrarVenda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConectarBancoDeDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastroUsuario;
        private System.Windows.Forms.Button btnConsultas;
    }
}