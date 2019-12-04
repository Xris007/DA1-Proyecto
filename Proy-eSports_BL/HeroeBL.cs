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
    public class HeroeBL
    {
        HeroeADO objHeroeADO = new HeroeADO();

        public Boolean InsertHero(HeroeBE objHeroBE)
        {
            return objHeroeADO.InsertHero(objHeroBE);
        }
        public Boolean UpdateHero(HeroeBE objHeroBE)
        {
            return objHeroeADO.UpdateHero(objHeroBE);
        }
        public Boolean DeleteHero(String HeroeId)
        {
            return objHeroeADO.DeleteHero(HeroeId);
        }
        public HeroeBE ConsultHero(String HeroeId)
        {
            return objHeroeADO.ConsultHero(HeroeId);
        }
        public DataTable ListarHeroes()
        {
            return objHeroeADO.ListarHeroes();
        }
        public DataTable ListarHeroePorComplejidadAtributo(String complejidad, String atributo)
        {
            return objHeroeADO.ListarHeroePorComplejidadAtributo(complejidad, atributo);
        }
    }
}
