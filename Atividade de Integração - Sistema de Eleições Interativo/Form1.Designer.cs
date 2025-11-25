namespace Atividade_de_Integração___Sistema_de_Eleições_Interativo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btResultados = new System.Windows.Forms.Button();
            this.btVotacao = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btResultados
            // 
            this.btResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResultados.Location = new System.Drawing.Point(106, 384);
            this.btResultados.Name = "btResultados";
            this.btResultados.Size = new System.Drawing.Size(244, 37);
            this.btResultados.TabIndex = 1;
            this.btResultados.Text = "Resultados";
            this.btResultados.UseVisualStyleBackColor = true;
            this.btResultados.Click += new System.EventHandler(this.btResultados_Click);
            // 
            // btVotacao
            // 
            this.btVotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVotacao.Location = new System.Drawing.Point(106, 190);
            this.btVotacao.Name = "btVotacao";
            this.btVotacao.Size = new System.Drawing.Size(244, 37);
            this.btVotacao.TabIndex = 2;
            this.btVotacao.Text = "Votação";
            this.btVotacao.UseVisualStyleBackColor = true;
            this.btVotacao.Click += new System.EventHandler(this.btVotacao_Click);
            // 
            // btCadastro
            // 
            this.btCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.Location = new System.Drawing.Point(106, 99);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(244, 37);
            this.btCadastro.TabIndex = 3;
            this.btCadastro.Text = "Cadastro de Candidatos";
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.btVotacao);
            this.Controls.Add(this.btResultados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btResultados;
        private System.Windows.Forms.Button btVotacao;
        private System.Windows.Forms.Button btCadastro;
    }
}

