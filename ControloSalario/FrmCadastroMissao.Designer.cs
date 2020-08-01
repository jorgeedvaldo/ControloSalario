namespace ControloSalario
{
    partial class FrmCadastroMissao
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
            this.dgAgente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtDataFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbAgente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionarNaLista = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAgente
            // 
            this.dgAgente.AllowUserToAddRows = false;
            this.dgAgente.AllowUserToDeleteRows = false;
            this.dgAgente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgAgente.Location = new System.Drawing.Point(409, 280);
            this.dgAgente.Name = "dgAgente";
            this.dgAgente.ReadOnly = true;
            this.dgAgente.RowHeadersVisible = false;
            this.dgAgente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAgente.Size = new System.Drawing.Size(344, 131);
            this.dgAgente.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nome do Agente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dtDataInicio
            // 
            this.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicio.Location = new System.Drawing.Point(12, 109);
            this.dtDataInicio.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtDataInicio.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDataInicio.Name = "dtDataInicio";
            this.dtDataInicio.Size = new System.Drawing.Size(316, 20);
            this.dtDataInicio.TabIndex = 77;
            this.dtDataInicio.Value = new System.DateTime(2020, 7, 31, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 75;
            this.label8.Text = "Data de Início";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "Nome da Missão";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(12, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(316, 20);
            this.txtNome.TabIndex = 74;
            // 
            // dtDataFim
            // 
            this.dtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFim.Location = new System.Drawing.Point(15, 193);
            this.dtDataFim.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtDataFim.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDataFim.Name = "dtDataFim";
            this.dtDataFim.Size = new System.Drawing.Size(316, 20);
            this.dtDataFim.TabIndex = 79;
            this.dtDataFim.Value = new System.DateTime(2020, 7, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "Data de Fim Prevista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Local da Missão";
            // 
            // txtLocal
            // 
            this.txtLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocal.Location = new System.Drawing.Point(15, 265);
            this.txtLocal.Multiline = true;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(316, 89);
            this.txtLocal.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 83;
            this.label4.Text = "Descrição da Missão";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(409, 45);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(344, 105);
            this.txtDescricao.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Prestes a iniciar",
            "A decorrer",
            "Concluída",
            "Cancelada"});
            this.cbEstado.Location = new System.Drawing.Point(409, 174);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(344, 21);
            this.cbEstado.TabIndex = 85;
            // 
            // cbAgente
            // 
            this.cbAgente.DisplayMember = "Nome";
            this.cbAgente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgente.FormattingEnabled = true;
            this.cbAgente.Location = new System.Drawing.Point(409, 253);
            this.cbAgente.Name = "cbAgente";
            this.cbAgente.Size = new System.Drawing.Size(231, 21);
            this.cbAgente.TabIndex = 87;
            this.cbAgente.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Agentes Disponíveis";
            // 
            // btnAdicionarNaLista
            // 
            this.btnAdicionarNaLista.Location = new System.Drawing.Point(646, 251);
            this.btnAdicionarNaLista.Name = "btnAdicionarNaLista";
            this.btnAdicionarNaLista.Size = new System.Drawing.Size(107, 23);
            this.btnAdicionarNaLista.TabIndex = 88;
            this.btnAdicionarNaLista.Text = "Adicionar na Lista";
            this.btnAdicionarNaLista.UseVisualStyleBackColor = true;
            this.btnAdicionarNaLista.Click += new System.EventHandler(this.btnAdicionarNaLista_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(132, 409);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 32);
            this.btnLimpar.TabIndex = 91;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(16, 409);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 32);
            this.btnSalvar.TabIndex = 89;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(248, 409);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 32);
            this.btnCancelar.TabIndex = 90;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(409, 417);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(344, 23);
            this.btnRemover.TabIndex = 92;
            this.btnRemover.Text = "Remover da Lista";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // FrmCadastroMissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 503);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionarNaLista);
            this.Controls.Add(this.cbAgente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.dtDataFim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDataInicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgAgente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroMissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Missões";
            this.Load += new System.EventHandler(this.FrmCadastroMissao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAgente;
        private System.Windows.Forms.DateTimePicker dtDataInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtDataFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbAgente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionarNaLista;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnRemover;
    }
}