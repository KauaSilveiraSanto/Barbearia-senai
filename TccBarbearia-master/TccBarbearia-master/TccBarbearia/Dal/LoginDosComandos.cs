using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccBarbearia.Dal
{
    class LoginDosComandos
    {
        public bool tem = false;
        public string mensagem = ""; //tudo ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String email, String senha)
        {
            //procurar no banco esse email e senha  
            cmd.CommandText = "select * from logins where email = @email and senha = @senha";
                cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //se foi encontrado 
                {
                    tem = true; 
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem  = "Erro com Banco de Dados!";
            }
            return tem; 
        }




        public String cadastrar(String nome,String email, String cpf, String senha, String confSenha)
        {
            tem = false; 
            //comandos para inserir  
            if (senha.Equals(confSenha))
            {

                cmd.CommandText = "insert into logins values (@n,@e, @c, @s)";
                
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@n", nome);
                cmd.Parameters.AddWithValue("@c", cpf);
                cmd.Parameters.AddWithValue("@s", senha);
                
                try
                {
                    cmd.Connection=con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com Sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de dados!";
                }

            }else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem; 
        }

        
        


    }
}
