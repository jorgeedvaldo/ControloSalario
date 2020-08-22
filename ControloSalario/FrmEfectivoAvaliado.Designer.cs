namespace ControloSalario
{
    partial class FrmEfectivoAvaliado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbPatente = new System.Windows.Forms.Label();
            this.LbNomeAgente = new System.Windows.Forms.Label();
            this.LbCodigoAgente = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbAgente = new System.Windows.Forms.ComboBox();
            this.DtDataAvaliacao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CbPresencaNoTrabalho = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbEntregaNoTrabalho = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbPontualidade = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbPatente);
            this.groupBox1.Controls.Add(this.LbNomeAgente);
            this.groupBox1.Controls.Add(this.LbCodigoAgente);
            this.groupBox1.Location = new System.Drawing.Point(434, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 122);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Agente";
            // 
            // LbPatente
            // 
            this.LbPatente.AutoSize = true;
            this.LbPatente.Location = new System.Drawing.Point(17, 90);
            this.LbPatente.Name = "LbPatente";
            this.LbPatente.Size = new System.Drawing.Size(96, 13);
            this.LbPatente.TabIndex = 62;
            this.LbPatente.Text = "Nenhum Escolhido";
            // 
            // LbNomeAgente
            // 
            this.LbNomeAgente.AutoSize = true;
            this.LbNomeAgente.Location = new System.Drawing.Point(17, 56);
            this.LbNomeAgente.Name = "LbNomeAgente";
            this.LbNomeAgente.Size = new System.Drawing.Size(96, 13);
            this.LbNomeAgente.TabIndex = 62;
            this.LbNomeAgente.Text = "Nenhum Escolhido";
            // 
            // LbCodigoAgente
            // 
            this.LbCodigoAgente.AutoSize = true;
            this.LbCodigoAgente.Location = new System.Drawing.Point(17, 25);
            this.LbCodigoAgente.Name = "LbCodigoAgente";
            this.LbCodigoAgente.Size = new System.Drawing.Size(13, 13);
            this.LbCodigoAgente.TabIndex = 62;
            this.LbCodigoAgente.Text = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(33, 318);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 32);
            this.btnSalvar.TabIndex = 70;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(149, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 32);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Escolha o Agente";
            // 
            // CbAgente
            // 
            this.CbAgente.DisplayMember = "Nome";
            this.CbAgente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAgente.FormattingEnabled = true;
            this.CbAgente.Location = new System.Drawing.Point(33, 44);
            this.CbAgente.Name = "CbAgente";
            this.CbAgente.Size = new System.Drawing.Size(361, 21);
            this.CbAgente.TabIndex = 68;
            this.CbAgente.ValueMember = "Id";
            this.CbAgente.SelectedIndexChanged += new System.EventHandler(this.CbAgente_SelectedIndexChanged);
            // 
            // DtDataAvaliacao
            // 
            this.DtDataAvaliacao.Location = new System.Drawing.Point(33, 103);
            this.DtDataAvaliacao.Name = "DtDataAvaliacao";
            this.DtDataAvaliacao.Size = new System.Drawing.Size(361, 20);
            this.DtDataAvaliacao.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Data de Avaliação";
            // 
            // CbPresencaNoTrabalho
            // 
            this.CbPresencaNoTrabalho.DisplayMember = "Nome";
            this.CbPresencaNoTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPresencaNoTrabalho.FormattingEnabled = true;
            this.CbPresencaNoTrabalho.Items.AddRange(new object[] {
            "Presente",
            "Ausências Raras",
            "Ausências Medianas",
            "Muitas Vezes Ausênte"});
            this.CbPresencaNoTrabalho.Location = new System.Drawing.Point(33, 160);
            this.CbPresencaNoTrabalho.Name = "CbPresencaNoTrabalho";
            this.CbPresencaNoTrabalho.Size = new System.Drawing.Size(361, 21);
            this.CbPresencaNoTrabalho.TabIndex = 76;
            this.CbPresencaNoTrabalho.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Presença no Trabalho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Entrega no Trabalho";
            // 
            // CbEntregaNoTrabalho
            // 
            this.CbEntregaNoTrabalho.DisplayMember = "Nome";
            this.CbEntregaNoTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEntregaNoTrabalho.FormattingEnabled = true;
            this.CbEntregaNoTrabalho.Items.AddRange(new object[] {
            "Dá tudo de sí",
            "Regular",
            "Não é Entregue ao Trabalho"});
            this.CbEntregaNoTrabalho.Location = new System.Drawing.Point(33, 215);
            this.CbEntregaNoTrabalho.Name = "CbEntregaNoTrabalho";
            this.CbEntregaNoTrabalho.Size = new System.Drawing.Size(361, 21);
            this.CbEntregaNoTrabalho.TabIndex = 78;
            this.CbEntregaNoTrabalho.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Pontualidade";
            // 
            // CbPontualidade
            // 
            this.CbPontualidade.DisplayMember = "Nome";
            this.CbPontualidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPontualidade.FormattingEnabled = true;
            this.CbPontualidade.Items.AddRange(new object[] {
            "Sempre Pontual",
            "Atrasos Raros",
            "Atrasos Constantes",
            "Sempre Atrasa"});
            this.CbPontualidade.Location = new System.Drawing.Point(33, 271);
            this.CbPontualidade.Name = "CbPontualidade";
            this.CbPontualidade.Size = new System.Drawing.Size(361, 21);
            this.CbPontualidade.TabIndex = 80;
            this.CbPontualidade.ValueMember = "Id";
            // 
            // FrmEfectivoAvaliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 377);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbPontualidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbEntregaNoTrabalho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbPresencaNoTrabalho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtDataAvaliacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbAgente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEfectivoAvaliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliação do Efectivo";
            this.Load += new System.EventHandler(this.FrmEfectivoAvaliado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbPatente;
        private System.Windows.Forms.Label LbNomeAgente;
        private System.Windows.Forms.Label LbCodigoAgente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbAgente;
        private System.Windows.Forms.DateTimePicker DtDataAvaliacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbPresencaNoTrabalho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbEntregaNoTrabalho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbPontualidade;
    }
}