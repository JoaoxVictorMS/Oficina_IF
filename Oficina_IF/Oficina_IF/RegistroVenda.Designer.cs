namespace Oficina_IF
{
    partial class RegistroVenda
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
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataVenda = new System.Windows.Forms.DateTimePicker();
            this.comboPagamento = new System.Windows.Forms.ComboBox();
            this.comboSituacao = new System.Windows.Forms.ComboBox();
            this.numericSubtotal = new System.Windows.Forms.NumericUpDown();
            this.numericDesconto = new System.Windows.Forms.NumericUpDown();
            this.numericValorTotal = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextObervacoes = new System.Windows.Forms.RichTextBox();
            this.btnSubmeter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboUsuario = new System.Windows.Forms.ComboBox();
            this.comboServico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValorTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar venda";
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Location = new System.Drawing.Point(12, 12);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(83, 37);
            this.btnVoltarMenu.TabIndex = 26;
            this.btnVoltarMenu.Text = "Voltar ao menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 30);
            this.label7.TabIndex = 34;
            this.label7.Text = "Data de venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Subtotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(693, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 36;
            this.label3.Text = "Desconto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(684, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 37;
            this.label4.Text = "Valor Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 30);
            this.label5.TabIndex = 38;
            this.label5.Text = "Forma de Pagamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(702, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 30);
            this.label6.TabIndex = 39;
            this.label6.Text = "Situação";
            // 
            // dataVenda
            // 
            this.dataVenda.Location = new System.Drawing.Point(269, 164);
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.Size = new System.Drawing.Size(229, 20);
            this.dataVenda.TabIndex = 53;
            // 
            // comboPagamento
            // 
            this.comboPagamento.FormattingEnabled = true;
            this.comboPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão a Vista",
            "Cartão a Prazo",
            "Pix",
            "Depósito Bancário"});
            this.comboPagamento.Location = new System.Drawing.Point(800, 277);
            this.comboPagamento.Name = "comboPagamento";
            this.comboPagamento.Size = new System.Drawing.Size(229, 21);
            this.comboPagamento.TabIndex = 54;
            // 
            // comboSituacao
            // 
            this.comboSituacao.FormattingEnabled = true;
            this.comboSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo",
            "Finalizada/Entregue"});
            this.comboSituacao.Location = new System.Drawing.Point(800, 332);
            this.comboSituacao.Name = "comboSituacao";
            this.comboSituacao.Size = new System.Drawing.Size(229, 21);
            this.comboSituacao.TabIndex = 55;
            // 
            // numericSubtotal
            // 
            this.numericSubtotal.DecimalPlaces = 2;
            this.numericSubtotal.Location = new System.Drawing.Point(800, 115);
            this.numericSubtotal.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericSubtotal.Name = "numericSubtotal";
            this.numericSubtotal.Size = new System.Drawing.Size(229, 20);
            this.numericSubtotal.TabIndex = 56;
            // 
            // numericDesconto
            // 
            this.numericDesconto.DecimalPlaces = 2;
            this.numericDesconto.Location = new System.Drawing.Point(800, 168);
            this.numericDesconto.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericDesconto.Name = "numericDesconto";
            this.numericDesconto.Size = new System.Drawing.Size(229, 20);
            this.numericDesconto.TabIndex = 57;
            // 
            // numericValorTotal
            // 
            this.numericValorTotal.DecimalPlaces = 2;
            this.numericValorTotal.Location = new System.Drawing.Point(800, 229);
            this.numericValorTotal.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericValorTotal.Name = "numericValorTotal";
            this.numericValorTotal.Size = new System.Drawing.Size(229, 20);
            this.numericValorTotal.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(663, 395);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 30);
            this.label13.TabIndex = 59;
            this.label13.Text = "Observações";
            // 
            // richTextObervacoes
            // 
            this.richTextObervacoes.Location = new System.Drawing.Point(800, 395);
            this.richTextObervacoes.Name = "richTextObervacoes";
            this.richTextObervacoes.Size = new System.Drawing.Size(229, 159);
            this.richTextObervacoes.TabIndex = 68;
            this.richTextObervacoes.Text = "";
            // 
            // btnSubmeter
            // 
            this.btnSubmeter.Location = new System.Drawing.Point(429, 597);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Size = new System.Drawing.Size(275, 62);
            this.btnSubmeter.TabIndex = 69;
            this.btnSubmeter.Text = "Submeter";
            this.btnSubmeter.UseVisualStyleBackColor = true;
            this.btnSubmeter.Click += new System.EventHandler(this.btnSubmeter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 30);
            this.label8.TabIndex = 70;
            this.label8.Text = "Selecione o cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 30);
            this.label9.TabIndex = 71;
            this.label9.Text = "Selecione o usuário";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(74, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 30);
            this.label10.TabIndex = 72;
            this.label10.Text = "Selecione o serviço";
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(269, 218);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(229, 21);
            this.comboCliente.TabIndex = 73;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.comboCliente_SelectedIndexChanged);
            // 
            // comboUsuario
            // 
            this.comboUsuario.FormattingEnabled = true;
            this.comboUsuario.Location = new System.Drawing.Point(269, 268);
            this.comboUsuario.Name = "comboUsuario";
            this.comboUsuario.Size = new System.Drawing.Size(229, 21);
            this.comboUsuario.TabIndex = 74;
            this.comboUsuario.SelectedIndexChanged += new System.EventHandler(this.comboUsuario_SelectedIndexChanged);
            // 
            // comboServico
            // 
            this.comboServico.FormattingEnabled = true;
            this.comboServico.Location = new System.Drawing.Point(269, 323);
            this.comboServico.Name = "comboServico";
            this.comboServico.Size = new System.Drawing.Size(229, 21);
            this.comboServico.TabIndex = 75;
            this.comboServico.SelectedIndexChanged += new System.EventHandler(this.comboServico_SelectedIndexChanged);
            // 
            // RegistroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 688);
            this.Controls.Add(this.comboServico);
            this.Controls.Add(this.comboUsuario);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSubmeter);
            this.Controls.Add(this.richTextObervacoes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericValorTotal);
            this.Controls.Add(this.numericDesconto);
            this.Controls.Add(this.numericSubtotal);
            this.Controls.Add(this.comboSituacao);
            this.Controls.Add(this.comboPagamento);
            this.Controls.Add(this.dataVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.label1);
            this.Name = "RegistroVenda";
            this.Text = "Registro de venda";
            this.Load += new System.EventHandler(this.RegistroVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValorTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dataVenda;
        private System.Windows.Forms.ComboBox comboPagamento;
        private System.Windows.Forms.ComboBox comboSituacao;
        private System.Windows.Forms.NumericUpDown numericSubtotal;
        private System.Windows.Forms.NumericUpDown numericDesconto;
        private System.Windows.Forms.NumericUpDown numericValorTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextObervacoes;
        private System.Windows.Forms.Button btnSubmeter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboUsuario;
        private System.Windows.Forms.ComboBox comboServico;
    }
}