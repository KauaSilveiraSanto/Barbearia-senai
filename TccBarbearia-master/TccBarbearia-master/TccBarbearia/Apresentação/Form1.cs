using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TccBarbearia.Apresentação;
using TccBarbearia.Modelo;

namespace TccBarbearia
{
    public partial class Form1 : Form
    {
        public object Controle { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_senha1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            // Quando o botão "Cadastrar-se" é clicado, alternamos a visibilidade dos painéis.
           
        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            controle controle = new controle();
            controle.acessar(txb_email.Text, txb_senha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso!", "Entrando!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TelaBarbeiro tb = new TelaBarbeiro();
                    tb.Show();
                }

                else
                {
                    MessageBox.Show("Login não encontrado, verifique email e senha!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btn_EsqueciSenha_Click(object sender, EventArgs e)
        {

            // Criar uma instância do formulário de recuperação de senha
            esqueciSenha esqueciSenha = new esqueciSenha();

            // Exibir o formulário de recuperação de senha
            esqueciSenha.Show();

            // Opcional: Ocultar o formulário atual se desejar
            this.Hide();
        }
    }
}
