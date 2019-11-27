using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proy_eSports_ADO;

namespace Proy_eSports_BL
{
    public class JugadorBL
    {
        JugadorADO objJugadorADO = new JugadorADO();

        public DataTable ListarJugador()
        {
            return objJugadorADO.ListarJugador();
        }

        public DataTable ListarCapitanes()
        {
            return objJugadorADO.ListarCapitanes();
        }

        public DataTable ListarCapitanesPorPais(String pais)
        {
            return objJugadorADO.ListarCapitanPorPais(pais);
        }

        public DataTable ListarPaisJugador()
        {
            return objJugadorADO.ListarPaisJugador();
        }

        public DataTable ListarJugadorPorPais(String pais)
        {
            return objJugadorADO.ListarJugadorPorPais(pais);
        }
    }
}
