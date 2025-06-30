namespace TccBarbearia.Apresentação
{
    partial class agendamento
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
            this.cb_agendar = new System.Windows.Forms.ComboBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.cb_profissionais = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_agendar
            // 
            this.cb_agendar.FormattingEnabled = true;
            this.cb_agendar.Location = new System.Drawing.Point(12, 69);
            this.cb_agendar.Name = "cb_agendar";
            this.cb_agendar.Size = new System.Drawing.Size(479, 24);
            this.cb_agendar.TabIndex = 0;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(560, 177);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(128, 36);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // cb_horario
            // 
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(501, 69);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(263, 24);
            this.cb_horario.TabIndex = 4;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.Location = new System.Drawing.Point(560, 228);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(128, 36);
            this.btn_finalizar.TabIndex = 5;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // txb_nome
            // 
            this.txb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nome.Location = new System.Drawing.Point(501, 122);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(263, 28);
            this.txb_nome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome cliente";
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(501, 13);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(263, 22);
            this.dtp_data.TabIndex = 8;
            this.dtp_data.ValueChanged += new System.EventHandler(this.dtp_data_ValueChanged);
            // 
            // cb_profissionais
            // 
            this.cb_profissionais.FormattingEnabled = true;
            this.cb_profissionais.Location = new System.Drawing.Point(13, 10);
            this.cb_profissionais.Name = "cb_profissionais";
            this.cb_profissionais.Size = new System.Drawing.Size(217, 24);
            this.cb_profissionais.TabIndex = 9;
            // 
            // agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_profissionais);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.cb_agendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agendamento";
            this.Text = "agendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_agendar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.ComboBox cb_profissionais;
    }
}