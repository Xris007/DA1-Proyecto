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
        //Proy_eSports_ADO.LoginADO objLoginADO = new Proy_eSports_ADO.LoginADO();


        
        
        public DataTable BL_Login(Proy_eSports_BE.LoginBE loginBE)
        {
            return objLoginADO.D_login(loginBE);
        }
    }
}
