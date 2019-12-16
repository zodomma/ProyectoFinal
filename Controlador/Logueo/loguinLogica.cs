using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using MySql.Data.MySqlClient;

namespace Controlador.Logueo
{
    public class loguinLogica
    {
        ClsDatos clsDatos = null;
        readonly logueo Logueo = null;
        DataTable table = null; 
        public loguinLogica(logueo LOgueo)
        {
            Logueo = LOgueo;
        }

        

        public void ValidarUsuario()
        {
            try
            {
                clsDatos = new ClsDatos();
                MySqlParameter[] parameters = new MySqlParameter[2];

                parameters[0] = new MySqlParameter();
                parameters[0].ParameterName = "_usuario";
                parameters[0].MySqlDbType = MySqlDbType.VarChar;
                parameters[0].Size = 30;
                parameters[0].Value = Logueo.getUsuario();

                parameters[1] = new MySqlParameter();
                parameters[1].ParameterName = "_pass";
                parameters[1].MySqlDbType = MySqlDbType.VarChar;
                parameters[1].Size = 100;
                parameters[1].Value = Logueo.getPassword();

                clsDatos.EjecutarSP(parameters, "SPLoguin");
            }
            catch(Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }
    }
}
