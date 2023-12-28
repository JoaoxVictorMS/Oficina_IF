namespace Oficina_IF
{
    partial class CadastroServico
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmeter = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.numericDuracao = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericValor = new System.Windows.Forms.NumericUpDown();
            this.comboSituacao = new System.Windows.Forms.ComboBox();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de serviços";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Duração em minutos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Situação";
            // 
            // btnSubmeter
            // 
            this.btnSubmeter.Location = new System.Drawing.Point(158, 491);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Size = new System.Drawing.Size(275, 62);
            this.btnSubmeter.TabIndex = 12;
            this.btnSubmeter.Text = "Submeter";
            this.btnSubmeter.UseVisualStyleBackColor = true;
            this.btnSubmeter.Click += new System.EventHandler(this.btnSubmeter_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(240, 125);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(229, 180);
            this.txtDesc.TabIndex = 14;
            this.txtDesc.Text = "";
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // numericDuracao
            // 
            this.numericDuracao.Location = new System.Drawing.Point(240, 326);
            this.numericDuracao.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericDuracao.Name = "numericDuracao";
            this.numericDuracao.Size = new System.Drawing.Size(229, 20);
            this.numericDuracao.TabIndex = 18;
            this.numericDuracao.ValueChanged += new System.EventHandler(this.numericDuracao_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Valor";
            // 
            // numericValor
            // 
            this.numericValor.Location = new System.Drawing.Point(240, 431);
            this.numericValor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericValor.Name = "numericValor";
            this.numericValor.Size = new System.Drawing.Size(229, 20);
            this.numericValor.TabIndex = 21;
            // 
            // comboSituacao
            // 
            this.comboSituacao.FormattingEnabled = true;
            this.comboSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.comboSituacao.Location = new System.Drawing.Point(240, 376);
            this.comboSituacao.Name = "comboSituacao";
            this.comboSituacao.Size = new System.Drawing.Size(229, 21);
            this.comboSituacao.TabIndex = 23;
            this.comboSituacao.SelectedIndexChanged += new System.EventHandler(this.comboSituacao_SelectedIndexChanged);
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Location = new System.Drawing.Point(12, 12);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(83, 37);
            this.btnVoltarMenu.TabIndex = 24;
            this.btnVoltarMenu.Text = "Voltar ao menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // CadastroServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 578);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.comboSituacao);
            this.Controls.Add(this.numericValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericDuracao);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnSubmeter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CadastroServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroServico";
            this.Load += new System.EventHandler(this.CadastroServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDuracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmeter;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.NumericUpDown numericDuracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericValor;
        private System.Windows.Forms.ComboBox comboSituacao;
        private System.Windows.Forms.Button btnVoltarMenu;
    }
}