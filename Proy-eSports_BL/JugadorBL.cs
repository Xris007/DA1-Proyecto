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
    public class JugadorBL
    {
        JugadorADO objJugadorADO = new JugadorADO();

        public DataTable ListarJugador()
        {
            return objJugadorADO.ListarJugador();
        }
        public DataTable ListarJugadorequipo(String idEquipo)
        {
            return objJugadorADO.ListarJugadorEquipo(idEquipo);
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

        public Boolean InsertarJugador(JugadorBE jugadorBE)
        {
            return objJugadorADO.InsertarJugador(jugadorBE);
        }

        public Boolean ActualizarJugador(JugadorBE jugadorBE)
        {
            return objJugadorADO.ActualizarJugador(jugadorBE);
        }

        public Boolean EliminarJugador(String IdJugador)
        {
            return objJugadorADO.EliminarJugador(IdJugador);
        }

        public JugadorBE ConsultarJugador(String IdJugador)
        {
            return objJugadorADO.ConsultarJugador(IdJugador);
        }
    }
}
