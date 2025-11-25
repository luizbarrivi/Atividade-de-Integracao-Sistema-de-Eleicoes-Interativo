namespace Atividade_de_Integração___Sistema_de_Eleições_Interativo.Forms
{
    partial class FormVotacao
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeCandidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCandidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidoCandidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btConfirmarVoto = new System.Windows.Forms.Button();
            this.btEncerrarVotacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "INSIRA O NÚMERO DO CANDIDATO: ";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(255, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 22);
            this.textBox3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "MENU DE VOTAÇÃO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Insira 00 para Voto em Branco.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Para Voto Nulo, insira qualquer número inexistente (exceto o código de branco).";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeCandidato,
            this.numeroCandidato,
            this.partidoCandidato});
            this.dataGridView1.Location = new System.Drawing.Point(24, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 201);
            this.dataGridView1.TabIndex = 13;
            // 
            // nomeCandidato
            // 
            this.nomeCandidato.HeaderText = "Nome";
            this.nomeCandidato.Name = "nomeCandidato";
            this.nomeCandidato.Width = 200;
            // 
            // numeroCandidato
            // 
            this.numeroCandidato.HeaderText = "Número do Candidato";
            this.numeroCandidato.Name = "numeroCandidato";
            this.numeroCandidato.Width = 75;
            // 
            // partidoCandidato
            // 
            this.partidoCandidato.HeaderText = "Partido";
            this.partidoCandidato.Name = "partidoCandidato";
            this.partidoCandidato.Width = 75;
            // 
            // btConfirmarVoto
            // 
            this.btConfirmarVoto.BackColor = System.Drawing.Color.PaleGreen;
            this.btConfirmarVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmarVoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btConfirmarVoto.Location = new System.Drawing.Point(255, 387);
            this.btConfirmarVoto.Name = "btConfirmarVoto";
            this.btConfirmarVoto.Size = new System.Drawing.Size(149, 51);
            this.btConfirmarVoto.TabIndex = 14;
            this.btConfirmarVoto.Text = "CONFIRMAR VOTO";
            this.btConfirmarVoto.UseVisualStyleBackColor = false;
            // 
            // btEncerrarVotacao
            // 
            this.btEncerrarVotacao.BackColor = System.Drawing.Color.Red;
            this.btEncerrarVotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncerrarVotacao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btEncerrarVotacao.Location = new System.Drawing.Point(26, 387);
            this.btEncerrarVotacao.Name = "btEncerrarVotacao";
            this.btEncerrarVotacao.Size = new System.Drawing.Size(149, 51);
            this.btEncerrarVotacao.TabIndex = 15;
            this.btEncerrarVotacao.Text = "ENCERRAR VOTAÇÃO";
            this.btEncerrarVotacao.UseVisualStyleBackColor = false;
            // 
            // FormVotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.btEncerrarVotacao);
            this.Controls.Add(this.btConfirmarVoto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Name = "FormVotacao";
            this.Text = "FormVotacao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCandidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCandidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidoCandidato;
        private System.Windows.Forms.Button btConfirmarVoto;
        private System.Windows.Forms.Button btEncerrarVotacao;
    }
}