namespace Atividade_de_Integração___Sistema_de_Eleições_Interativo.Forms
{
    partial class FormCadastroCandidatos
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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txtNomeComp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeExibi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE CANDIDATOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.PaleGreen;
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCadastrar.Location = new System.Drawing.Point(287, 346);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(165, 41);
            this.btCadastrar.TabIndex = 1;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // txtNomeComp
            // 
            this.txtNomeComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeComp.Location = new System.Drawing.Point(20, 105);
            this.txtNomeComp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeComp.Name = "txtNomeComp";
            this.txtNomeComp.Size = new System.Drawing.Size(431, 26);
            this.txtNomeComp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOME COMPLETO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "NOME DE EXIBIÇÃO/APELIDO:";
            // 
            // txtNomeExibi
            // 
            this.txtNomeExibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeExibi.Location = new System.Drawing.Point(20, 178);
            this.txtNomeExibi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeExibi.Name = "txtNomeExibi";
            this.txtNomeExibi.Size = new System.Drawing.Size(431, 26);
            this.txtNomeExibi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "NÚMERO DO CANDIDATO:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(241, 230);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(89, 26);
            this.txtNumero.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARTIDO DO CANDIDATO:";
            // 
            // txtPartido
            // 
            this.txtPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartido.Location = new System.Drawing.Point(241, 276);
            this.txtPartido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(89, 26);
            this.txtPartido.TabIndex = 8;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(65, 346);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(165, 41);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // FormCadastroCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 430);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPartido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeExibi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeComp);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCadastroCandidatos";
            this.Text = "FormCadastroCandidatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox txtNomeComp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeExibi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.Button btCancelar;
    }
}