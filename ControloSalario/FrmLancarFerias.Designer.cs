namespace ControloSalario
{
    partial class FrmLancarFerias
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
            this.CbAgente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.DtDataRegresso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbCodigoAgente = new System.Windows.Forms.Label();
            this.LbNomeAgente = new System.Windows.Forms.Label();
            this.LbPatente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbAgente
            // 
            this.CbAgente.DisplayMember = "Nome";
            this.CbAgente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAgente.FormattingEnabled = true;
            this.CbAgente.Location = new System.Drawing.Point(12, 49);
            this.CbAgente.Name = "CbAgente";
            this.CbAgente.Size = new System.Drawing.Size(361, 21);
            this.CbAgente.TabIndex = 0;
            this.CbAgente.ValueMember = "Id";
            this.CbAgente.SelectedIndexChanged += new System.EventHandler(this.CbAgente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha o Agente";
            // 
            // TxtDias
            // 
            this.TxtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDias.Location = new System.Drawing.Point(12, 122);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(361, 20);
            this.TxtDias.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total de Dias";
            // 
            // DtDataInicio
            // 
            this.DtDataInicio.Location = new System.Drawing.Point(12, 190);
            this.DtDataInicio.Name = "DtDataInicio";
            this.DtDataInicio.Size = new System.Drawing.Size(361, 20);
            this.DtDataInicio.TabIndex = 4;
            this.DtDataInicio.ValueChanged += new System.EventHandler(this.DtDataInicio_ValueChanged);
            // 
            // DtDataRegresso
            // 
            this.DtDataRegresso.Location = new System.Drawing.Point(12, 265);
            this.DtDataRegresso.Name = "DtDataRegresso";
            this.DtDataRegresso.Size = new System.Drawing.Size(361, 20);
            this.DtDataRegresso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Início";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de Regresso";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(128, 323);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 32);
            this.btnLimpar.TabIndex = 60;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 323);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 32);
            this.btnSalvar.TabIndex = 58;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(244, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 32);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbPatente);
            this.groupBox1.Controls.Add(this.LbNomeAgente);
            this.groupBox1.Controls.Add(this.LbCodigoAgente);
            this.groupBox1.Location = new System.Drawing.Point(413, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 122);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Agente";
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
            // LbNomeAgente
            // 
            this.LbNomeAgente.AutoSize = true;
            this.LbNomeAgente.Location = new System.Drawing.Point(17, 56);
            this.LbNomeAgente.Name = "LbNomeAgente";
            this.LbNomeAgente.Size = new System.Drawing.Size(96, 13);
            this.LbNomeAgente.TabIndex = 62;
            this.LbNomeAgente.Text = "Nenhum Escolhido";
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
            // FrmLancarFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtDataRegresso);
            this.Controls.Add(this.DtDataInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbAgente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLancarFerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançar Ferias";
            this.Load += new System.EventHandler(this.LancarFerias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbAgente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtDataInicio;
        private System.Windows.Forms.DateTimePicker DtDataRegresso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbPatente;
        private System.Windows.Forms.Label LbNomeAgente;
        private System.Windows.Forms.Label LbCodigoAgente;
    }
}