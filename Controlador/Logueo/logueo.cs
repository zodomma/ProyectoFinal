using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Logueo
{
    public class logueo
    {
        private string usuario;
        public string getUsuario()
        {
            return usuario;
        }
        public void SetUsuario(string usu)
        {
            this.usuario = usu;
        }

        private string password;
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string pass)
        {
            this.password = pass;
        }
    }
}
