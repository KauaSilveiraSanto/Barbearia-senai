namespace TccBarbearia.Apresentação
{
    partial class Cadastrar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txb_email1 = new System.Windows.Forms.TextBox();
            this.txb_senha1 = new System.Windows.Forms.TextBox();
            this.txb_ConfSenha = new System.Windows.Forms.TextBox();
            this.btn_Cadastro = new System.Windows.Forms.Button();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txb_cpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txb_email1
            // 
            this.txb_email1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_email1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email1.Location = new System.Drawing.Point(85, 141);
            this.txb_email1.Name = "txb_email1";
            this.txb_email1.Size = new System.Drawing.Size(352, 17);
            this.txb_email1.TabIndex = 2;
            this.txb_email1.TextChanged += new System.EventHandler(this.txb_email1_TextChanged);
            // 
            // txb_senha1
            // 
            this.txb_senha1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_senha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_senha1.Location = new System.Drawing.Point(85, 272);
            this.txb_senha1.Name = "txb_senha1";
            this.txb_senha1.Size = new System.Drawing.Size(352, 17);
            this.txb_senha1.TabIndex = 4;
            this.txb_senha1.UseSystemPasswordChar = true;
            this.txb_senha1.TextChanged += new System.EventHandler(this.txb_senha1_TextChanged);
            // 
            // txb_ConfSenha
            // 
            this.txb_ConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_ConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ConfSenha.Location = new System.Drawing.Point(85, 344);
            this.txb_ConfSenha.Name = "txb_ConfSenha";
            this.txb_ConfSenha.Size = new System.Drawing.Size(352, 17);
            this.txb_ConfSenha.TabIndex = 5;
            this.txb_ConfSenha.UseSystemPasswordChar = true;
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cadastro.BackgroundImage")));
            this.btn_Cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cadastro.Location = new System.Drawing.Point(177, 403);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Size = new System.Drawing.Size(175, 35);
            this.btn_Cadastro.TabIndex = 6;
            this.btn_Cadastro.UseVisualStyleBackColor = true;
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
            // 
            // txb_nome
            // 
            this.txb_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txb_nome.Location = new System.Drawing.Point(85, 85);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(352, 19);
            this.txb_nome.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txb_cpf
            // 
            this.txb_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txb_cpf.Location = new System.Drawing.Point(85, 204);
            this.txb_cpf.Name = "txb_cpf";
            this.txb_cpf.Size = new System.Drawing.Size(352, 19);
            this.txb_cpf.TabIndex = 8;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_cpf);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.btn_Cadastro);
            this.Controls.Add(this.txb_ConfSenha);
            this.Controls.Add(this.txb_senha1);
            this.Controls.Add(this.txb_email1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txb_email1;
        private System.Windows.Forms.TextBox txb_senha1;
        private System.Windows.Forms.TextBox txb_ConfSenha;
        private System.Windows.Forms.Button btn_Cadastro;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txb_cpf;
    }
}