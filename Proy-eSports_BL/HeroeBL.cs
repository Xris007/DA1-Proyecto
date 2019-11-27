using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proy_eSports_ADO;

namespace Proy_eSports_BL
{
    public class HeroeBL
    {
        HeroeADO objHeroeADO = new HeroeADO();

        public DataTable ListarHeroes()
        {
            return objHeroeADO.ListarHeroes();
        }
    }
}
