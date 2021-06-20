using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocketpowers.Dal
{
    class LoginDalComandos
    {

        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from logins where email=@login and senha= @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);


            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            //con.desconectar();
            //dr.Close();
            catch (SqlException)
            {

                this.mensagem = "erro com o banco";
            }

            return tem;

        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            tem = false;
            if (senha.Equals(confSenha)  ) 
            {
                cmd.CommandText = "insert into logins values(@log, @passw);";
                cmd.Parameters.AddWithValue("@log", email);
                cmd.Parameters.AddWithValue("@passw", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "resgistered successfully";
                    tem = true;

                }
                catch (SqlException)
                {
                    this.mensagem = "error with bank";
                }
            }
            else
            {
                this.mensagem = "credentials invalids";
            }
            return mensagem;


        }
    }
}
    

