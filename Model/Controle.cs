using rocketpowers.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocketpowers.Model
{
    class Controle
    {

        public bool tem;
        public String mensagem = "";
        public bool acessar(String Login, String senha)
        {
            LoginDalComandos LoginDal = new LoginDalComandos();
            tem = LoginDal.verificarLogin(Login, senha);
            if (!LoginDal.mensagem.Equals(""))
            {

                this.mensagem = LoginDal.mensagem;

            }

            return tem;
        }

        public String cadastrar(String email, String senha, string confSenha)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            this.mensagem = loginDal.cadastrar(email, senha, confSenha);
            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}

    

