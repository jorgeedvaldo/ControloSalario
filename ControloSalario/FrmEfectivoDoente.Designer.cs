namespace ControloSalario
{
    partial class FrmEfectivoDoente
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbAgente = new System.Windows.Forms.ComboBox();
            this.TxtDoencaPotencial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbDoenteAoDomicilio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbPatente);
            this.groupBox1.Controls.Add(this.LbNomeAgente);
            this.groupBox1.Controls.Add(this.LbCodigoAgente);
            this.groupBox1.Location = new System.Drawing.Point(434, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 122);
            this.groupBox1.TabIndex = 67;
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
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(149, 320);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 32);
            this.btnLimpar.TabIndex = 66;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(33, 320);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 32);
            this.btnSalvar.TabIndex = 64;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(265, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 32);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Escolha o Agente";
            // 
            // CbAgente
            // 
            this.CbAgente.DisplayMember = "Nome";
            this.CbAgente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAgente.FormattingEnabled = true;
            this.CbAgente.Location = new System.Drawing.Point(33, 46);
            this.CbAgente.Name = "CbAgente";
            this.CbAgente.Size = new System.Drawing.Size(361, 21);
            this.CbAgente.TabIndex = 62;
            this.CbAgente.ValueMember = "Id";
            this.CbAgente.SelectedIndexChanged += new System.EventHandler(this.CbAgente_SelectedIndexChanged);
            // 
            // TxtDoencaPotencial
            // 
            this.TxtDoencaPotencial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDoencaPotencial.Location = new System.Drawing.Point(33, 111);
            this.TxtDoencaPotencial.Name = "TxtDoencaPotencial";
            this.TxtDoencaPotencial.Size = new System.Drawing.Size(361, 20);
            this.TxtDoencaPotencial.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Doença Potencial";
            // 
            // CbDoenteAoDomicilio
            // 
            this.CbDoenteAoDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDoenteAoDomicilio.FormattingEnabled = true;
            this.CbDoenteAoDomicilio.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.CbDoenteAoDomicilio.Location = new System.Drawing.Point(33, 176);
            this.CbDoenteAoDomicilio.Name = "CbDoenteAoDomicilio";
            this.CbDoenteAoDomicilio.Size = new System.Drawing.Size(361, 21);
            this.CbDoenteAoDomicilio.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Doente ao Domicílio";
            // 
            // FrmEfectivoDoente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbDoenteAoDomicilio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDoencaPotencial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbAgente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEfectivoDoente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efectivo Doente";
            this.Load += new System.EventHandler(this.FrmEfectivoDoente_Load);
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
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbAgente;
        private System.Windows.Forms.TextBox TxtDoencaPotencial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbDoenteAoDomicilio;
        private System.Windows.Forms.Label label3;
    }
}