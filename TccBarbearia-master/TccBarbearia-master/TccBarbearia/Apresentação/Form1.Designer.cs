namespace TccBarbearia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_EsqueciSenha = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_senha
            // 
            this.txb_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_senha.Location = new System.Drawing.Point(467, 305);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.Size = new System.Drawing.Size(386, 21);
            this.txb_senha.TabIndex = 20;
            this.txb_senha.UseSystemPasswordChar = true;
            // 
            // txb_email
            // 
            this.txb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email.Location = new System.Drawing.Point(467, 222);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(386, 21);
            this.txb_email.TabIndex = 21;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_entrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_entrar.BackgroundImage")));
            this.btn_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Location = new System.Drawing.Point(369, 383);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(251, 49);
            this.btn_entrar.TabIndex = 23;
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.BackgroundImage")));
            this.btn_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Location = new System.Drawing.Point(623, 520);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(182, 32);
            this.btn_cadastrar.TabIndex = 22;
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click_1);
            // 
            // btn_EsqueciSenha
            // 
            this.btn_EsqueciSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EsqueciSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EsqueciSenha.BackgroundImage")));
            this.btn_EsqueciSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EsqueciSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EsqueciSenha.Location = new System.Drawing.Point(604, 342);
            this.btn_EsqueciSenha.Name = "btn_EsqueciSenha";
            this.btn_EsqueciSenha.Size = new System.Drawing.Size(258, 26);
            this.btn_EsqueciSenha.TabIndex = 19;
            this.btn_EsqueciSenha.UseVisualStyleBackColor = true;
            this.btn_EsqueciSenha.Click += new System.EventHandler(this.btn_EsqueciSenha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1042, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1042, 570);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_senha);
            this.Controls.Add(this.btn_EsqueciSenha);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_EsqueciSenha;
        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_entrar;
    }
}

