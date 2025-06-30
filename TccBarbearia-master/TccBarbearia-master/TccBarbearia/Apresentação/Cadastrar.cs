using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TccBarbearia.Modelo;

namespace TccBarbearia.Apresentação
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            controle controle = new controle();
            String mensagem = controle.cadastrar(txb_nome.Text, txb_email1.Text,txb_cpf.Text, txb_senha1.Text, txb_ConfSenha.Text);
            if (controle.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);//mensagem de erro 
            }
        }

        private void txb_email1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_senha1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_cell_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
