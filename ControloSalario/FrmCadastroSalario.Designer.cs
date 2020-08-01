namespace ControloSalario
{
    partial class FrmCadastroSalario
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbAgente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIRT = new System.Windows.Forms.NumericUpDown();
            this.txtINSS = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubcidioTransporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubcidioAlimentacao = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.txtIRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINSS)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Escolha o Agente";
            // 
            // cbAgente
            // 
            this.cbAgente.DisplayMember = "Nome";
            this.cbAgente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgente.FormattingEnabled = true;
            this.cbAgente.Items.AddRange(new object[] {
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
            this.cbAgente.Location = new System.Drawing.Point(12, 48);
            this.cbAgente.Name = "cbAgente";
            this.cbAgente.Size = new System.Drawing.Size(316, 21);
            this.cbAgente.TabIndex = 79;
            this.cbAgente.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 89;
            this.label7.Text = "Percentagem IRT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 90;
            this.label9.Text = "Digite o salário base";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioBase.Location = new System.Drawing.Point(12, 107);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(316, 20);
            this.txtSalarioBase.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 86;
            this.label3.Text = "Percentagem  INSS";
            // 
            // txtIRT
            // 
            this.txtIRT.Location = new System.Drawing.Point(394, 120);
            this.txtIRT.Name = "txtIRT";
            this.txtIRT.Size = new System.Drawing.Size(316, 20);
            this.txtIRT.TabIndex = 91;
            // 
            // txtINSS
            // 
            this.txtINSS.Location = new System.Drawing.Point(394, 177);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(316, 20);
            this.txtINSS.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "Subsidio de Transporte";
            // 
            // txtSubcidioTransporte
            // 
            this.txtSubcidioTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubcidioTransporte.Location = new System.Drawing.Point(12, 177);
            this.txtSubcidioTransporte.Name = "txtSubcidioTransporte";
            this.txtSubcidioTransporte.Size = new System.Drawing.Size(316, 20);
            this.txtSubcidioTransporte.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Subsidio de Alimentação";
            // 
            // txtSubcidioAlimentacao
            // 
            this.txtSubcidioAlimentacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubcidioAlimentacao.Location = new System.Drawing.Point(12, 247);
            this.txtSubcidioAlimentacao.Name = "txtSubcidioAlimentacao";
            this.txtSubcidioAlimentacao.Size = new System.Drawing.Size(316, 20);
            this.txtSubcidioAlimentacao.TabIndex = 95;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(129, 306);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 32);
            this.btnLimpar.TabIndex = 99;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(13, 306);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 32);
            this.btnSalvar.TabIndex = 97;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(245, 306);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 32);
            this.btnCancelar.TabIndex = 98;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 29);
            this.label4.TabIndex = 100;
            this.label4.Text = "Descontos";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(722, 365);
            this.shapeContainer1.TabIndex = 101;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 357;
            this.lineShape1.X2 = 357;
            this.lineShape1.Y1 = 46;
            this.lineShape1.Y2 = 265;
            // 
            // FrmCadastroSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubcidioAlimentacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubcidioTransporte);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.txtIRT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAgente);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroSalario";
            this.Text = "Cadastro de Salário";
            this.Load += new System.EventHandler(this.FrmCadastroSalario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINSS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAgente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtIRT;
        private System.Windows.Forms.NumericUpDown txtINSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubcidioTransporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubcidioAlimentacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;

    }
}