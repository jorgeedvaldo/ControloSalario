namespace ControloSalario
{
    partial class FrmCadastroAgente
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
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPatente = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.dtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefone1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtBI = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAgente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMorada
            // 
            this.txtMorada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMorada.Location = new System.Drawing.Point(374, 154);
            this.txtMorada.Multiline = true;
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(316, 92);
            this.txtMorada.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "Morada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Patente";
            // 
            // cbPatente
            // 
            this.cbPatente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPatente.FormattingEnabled = true;
            this.cbPatente.Items.AddRange(new object[] {
            "Comissário Geral",
            "Comissário Chefe",
            "Comissário",
            "Sub-Comissário",
            "Superintendente Chefe",
            "Superintendente",
            "Intendente",
            "Inspector Chefe",
            "Inspector",
            "Sub-inspector",
            "1º Sub-chefe",
            "2º Sub-chefe",
            "3º Sub-chefe",
            "Agente de 1ª classe",
            "Agente de 2ª classe",
            "Agente de 3ª classe"});
            this.cbPatente.Location = new System.Drawing.Point(374, 93);
            this.cbPatente.Name = "cbPatente";
            this.cbPatente.Size = new System.Drawing.Size(316, 21);
            this.cbPatente.TabIndex = 77;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(136, 453);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 32);
            this.btnLimpar.TabIndex = 76;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Telefone Alternativo";
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone2.Location = new System.Drawing.Point(374, 40);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(316, 20);
            this.txtTelefone2.TabIndex = 74;
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNascimento.Location = new System.Drawing.Point(20, 265);
            this.dtDataNascimento.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.dtDataNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.Size = new System.Drawing.Size(316, 20);
            this.dtDataNascimento.TabIndex = 73;
            this.dtDataNascimento.Value = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Sexo";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO"});
            this.cbSexo.Location = new System.Drawing.Point(20, 202);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(316, 21);
            this.cbSexo.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 16);
            this.label13.TabIndex = 67;
            this.label13.Text = "Telefone Principal";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(20, 453);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 32);
            this.btnSalvar.TabIndex = 69;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 65;
            this.label8.Text = "Data de Nascimento";
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone1.Location = new System.Drawing.Point(20, 392);
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(316, 20);
            this.txtTelefone1.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Nº BI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Nome Completo";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(20, 142);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(316, 20);
            this.txtNome.TabIndex = 62;
            // 
            // txtBI
            // 
            this.txtBI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBI.Location = new System.Drawing.Point(20, 329);
            this.txtBI.Name = "txtBI";
            this.txtBI.Size = new System.Drawing.Size(316, 20);
            this.txtBI.TabIndex = 64;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(252, 453);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 32);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 83;
            this.label7.Text = "N.º Guia";
            // 
            // txtGuia
            // 
            this.txtGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuia.Location = new System.Drawing.Point(20, 85);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(316, 20);
            this.txtGuia.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 84;
            this.label9.Text = "Nº Agente";
            // 
            // txtAgente
            // 
            this.txtAgente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgente.Location = new System.Drawing.Point(20, 30);
            this.txtAgente.Name = "txtAgente";
            this.txtAgente.Size = new System.Drawing.Size(316, 20);
            this.txtAgente.TabIndex = 82;
            // 
            // FrmCadastroAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 512);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAgente);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPatente);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefone2);
            this.Controls.Add(this.dtDataNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefone1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtBI);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroAgente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Agentes";
            this.Load += new System.EventHandler(this.FrmCadastroAgente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPatente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefone2;
        private System.Windows.Forms.DateTimePicker dtDataNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefone1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtBI;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAgente;
    }
}