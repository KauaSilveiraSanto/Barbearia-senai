namespace TccBarbearia.Apresentação
{
    partial class TelaBarbeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBarbeiro));
            this.Pn_TelaBarbeiro = new System.Windows.Forms.Panel();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_ag = new System.Windows.Forms.Button();
            this.calendar_m = new System.Windows.Forms.DateTimePicker();
            this.dg_mostra = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Pn_TelaBarbeiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pn_TelaBarbeiro
            // 
            this.Pn_TelaBarbeiro.AutoSize = true;
            this.Pn_TelaBarbeiro.Controls.Add(this.btn_atualizar);
            this.Pn_TelaBarbeiro.Controls.Add(this.btn_ag);
            this.Pn_TelaBarbeiro.Controls.Add(this.calendar_m);
            this.Pn_TelaBarbeiro.Controls.Add(this.dg_mostra);
            this.Pn_TelaBarbeiro.Controls.Add(this.pictureBox1);
            this.Pn_TelaBarbeiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_TelaBarbeiro.Location = new System.Drawing.Point(0, 0);
            this.Pn_TelaBarbeiro.Name = "Pn_TelaBarbeiro";
            this.Pn_TelaBarbeiro.Size = new System.Drawing.Size(1902, 1033);
            this.Pn_TelaBarbeiro.TabIndex = 0;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_atualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_atualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.Location = new System.Drawing.Point(1155, 5);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(177, 36);
            this.btn_atualizar.TabIndex = 5;
            this.btn_atualizar.Text = "Carregar data";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_ag
            // 
            this.btn_ag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ag.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ag.Location = new System.Drawing.Point(1652, 5);
            this.btn_ag.Name = "btn_ag";
            this.btn_ag.Size = new System.Drawing.Size(200, 36);
            this.btn_ag.TabIndex = 3;
            this.btn_ag.Text = "Agendar";
            this.btn_ag.UseVisualStyleBackColor = false;
            this.btn_ag.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendar_m
            // 
            this.calendar_m.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar_m.Location = new System.Drawing.Point(1349, 12);
            this.calendar_m.Name = "calendar_m";
            this.calendar_m.Size = new System.Drawing.Size(281, 22);
            this.calendar_m.TabIndex = 2;
            this.calendar_m.ValueChanged += new System.EventHandler(this.calendar_m_ValueChanged);
            // 
            // dg_mostra
            // 
            this.dg_mostra.AllowUserToAddRows = false;
            this.dg_mostra.AllowUserToDeleteRows = false;
            this.dg_mostra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_mostra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_mostra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostra.Location = new System.Drawing.Point(31, 169);
            this.dg_mostra.Name = "dg_mostra";
            this.dg_mostra.ReadOnly = true;
            this.dg_mostra.RowHeadersWidth = 51;
            this.dg_mostra.Size = new System.Drawing.Size(1844, 850);
            this.dg_mostra.TabIndex = 1;
            this.dg_mostra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_mostra_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1902, 1033);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TelaBarbeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Pn_TelaBarbeiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaBarbeiro";
            this.Text = "TelaBarbeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaBarbeiro_Load);
            this.Pn_TelaBarbeiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pn_TelaBarbeiro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dg_mostra;
        private System.Windows.Forms.DateTimePicker calendar_m;
        private System.Windows.Forms.Button btn_ag;
        private System.Windows.Forms.Button btn_atualizar;
    }
}