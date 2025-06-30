namespace TccBarbearia.Apresentação
{
    partial class esqueciSenha
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelNovaSenha = new System.Windows.Forms.Label();
            this.txbNovaSenha = new System.Windows.Forms.TextBox();
            this.labelConfirmarSenha = new System.Windows.Forms.Label();
            this.txbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(387, 159);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(372, 112);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 22);
            this.txtCpf.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(372, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // labelNovaSenha
            // 
            this.labelNovaSenha.AutoSize = true;
            this.labelNovaSenha.Location = new System.Drawing.Point(377, 223);
            this.labelNovaSenha.Name = "labelNovaSenha";
            this.labelNovaSenha.Size = new System.Drawing.Size(85, 16);
            this.labelNovaSenha.TabIndex = 3;
            this.labelNovaSenha.Text = "Nova Senha:";
            // 
            // txbNovaSenha
            // 
            this.txbNovaSenha.Location = new System.Drawing.Point(372, 242);
            this.txbNovaSenha.Name = "txbNovaSenha";
            this.txbNovaSenha.Size = new System.Drawing.Size(100, 22);
            this.txbNovaSenha.TabIndex = 4;
            // 
            // labelConfirmarSenha
            // 
            this.labelConfirmarSenha.AutoSize = true;
            this.labelConfirmarSenha.Location = new System.Drawing.Point(369, 276);
            this.labelConfirmarSenha.Name = "labelConfirmarSenha";
            this.labelConfirmarSenha.Size = new System.Drawing.Size(109, 16);
            this.labelConfirmarSenha.TabIndex = 5;
            this.labelConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txbConfirmarSenha
            // 
            this.txbConfirmarSenha.Location = new System.Drawing.Point(372, 295);
            this.txbConfirmarSenha.Name = "txbConfirmarSenha";
            this.txbConfirmarSenha.Size = new System.Drawing.Size(100, 22);
            this.txbConfirmarSenha.TabIndex = 6;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Location = new System.Drawing.Point(380, 333);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarSenha.TabIndex = 7;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // esqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.txbConfirmarSenha);
            this.Controls.Add(this.labelConfirmarSenha);
            this.Controls.Add(this.txbNovaSenha);
            this.Controls.Add(this.labelNovaSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "esqueciSenha";
            this.Text = "Recuperação de Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelNovaSenha;
        private System.Windows.Forms.TextBox txbNovaSenha;
        private System.Windows.Forms.Label labelConfirmarSenha;
        private System.Windows.Forms.TextBox txbConfirmarSenha;
        private System.Windows.Forms.Button btnAlterarSenha;
    }
}
