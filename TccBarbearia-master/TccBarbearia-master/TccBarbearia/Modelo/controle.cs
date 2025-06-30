using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TccBarbearia.Dal;

namespace TccBarbearia.Modelo
{
    public class controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String email, String senha)
        {
            LoginDosComandos logindos = new LoginDosComandos();
            tem = logindos.verificarLogin(email, senha);
            if (!logindos.mensagem.Equals(""))
            {
                this.mensagem = logindos.mensagem;
            }
            return tem;
        }
        public String cadastrar(String nome, String email,String cpf, String senha, String confSenha)
        {
            LoginDosComandos logindos = new LoginDosComandos();
            this.mensagem = logindos.cadastrar(nome, email, cpf, senha, confSenha);
            if (logindos.tem)//a mensagem que vai vir é de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }

        

        
    }

}

        

