using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Musica.DB
{
    public class LoginBusiness
    {
        LoginDatabase db = new LoginDatabase();

        public bool Logar(string usuario, string senha)
        {
            bool logou = db.Logar(usuario, senha);
            return logou;
        }
    }
}
