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
    public class PartidaJugadorBL
    {
        PartidaJugadorADO objPartidaJugadorADO = new PartidaJugadorADO();

        public DataTable ListarHeroeRol(String idheroe, String roljugador)
        {
            return objPartidaJugadorADO.ListarHeroeRol(idheroe, roljugador);
        }
    }
}
