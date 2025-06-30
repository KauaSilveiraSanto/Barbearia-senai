
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TccBarbearia.Dal;



namespace TccBarbearia.Apresentação
{
    public partial class esqueciSenha : Form
    {
        private Conexao conexao;
        private string cpfRecuperar;

        public esqueciSenha()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            string email = txtEmail.Text;

            cpfRecuperar = cpf;

            bool credenciaisSaoValidas = VerificarCredenciais(cpf, email);

            if (credenciaisSaoValidas)
            {
                labelNovaSenha.Visible = true;
                txbNovaSenha.Visible = true;
                labelConfirmarSenha.Visible = true;
                txbConfirmarSenha.Visible = true;
                btnAlterarSenha.Visible = true;
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Verifique seu cpf e e-mail.");
            }
        }

        private bool VerificarCredenciais(string cpf, string email)
        {
            using (SqlConnection conexaoSql = new SqlConnection(@"Data Source=G15EDUARDO\SQLEXPRESS;Initial Catalog=TccBarbearia;User ID=root;Password=123456"))
            {
                try
                {
                    string consulta = "SELECT COUNT(*) FROM logins WHERE CPF = @cpf AND Email = @email";

                    using (SqlCommand comando = new SqlCommand(consulta, conexaoSql))
                    {
                        conexaoSql.Open();
                        comando.Parameters.AddWithValue("@cpf", cpf);
                        comando.Parameters.AddWithValue("@email", email);

                        int resultado = (int)comando.ExecuteScalar();

                        return resultado > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao verificar credenciais: " + ex.Message);
                    return false;
                }
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            string novaSenha = txbNovaSenha.Text;
            AlterarSenhaNoBancoDeDados(cpfRecuperar, novaSenha);
        }

        private void AlterarSenhaNoBancoDeDados(string cpf, string novaSenha)
        {
            using (SqlConnection conexaoSql = new SqlConnection(@"Data Source=G15EDUARDO\SQLEXPRESS;Initial Catalog=TccBarbearia;Integrated Security=True"))
            {
                try
                {
                    string consulta = "UPDATE logins SET senha = @senha WHERE CPF = @cpf";

                    using (SqlCommand comando = new SqlCommand(consulta, conexaoSql))
                    {
                        conexaoSql.Open();
                        comando.Parameters.AddWithValue("@cpf", cpf);
                        comando.Parameters.AddWithValue("@senha", novaSenha);

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Senha alterada com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao alterar a senha. Tente novamente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao alterar senha: " + ex.Message);
                }
            }
        }
    }
}

