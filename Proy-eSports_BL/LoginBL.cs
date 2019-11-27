using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proy_eSports_ADO;
using Proy_eSports_BE;

namespace Proy_eSports_BL
{
    public class LoginBL
    {
        LoginADO objLoginADO = new LoginADO();
        
        public DataTable IngresarUsuario(String user1, String pass)
        {
            return objLoginADO.D_login(user1, pass);
        }
    }
}
