using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_eSports_BE
{
    public class JugadorBE
    {
        private int idJugador;

        private String apeJugador;

        private String nomJugador;

        private String nickJugador;

        private int edadJugador;

        private String paisJugador;

        private Char capJugador;

        private String rolJugador;

        private int idEquipo;

        public int IdJugador { get => idJugador; set => idJugador = value; }
        public string ApeJugador { get => apeJugador; set => apeJugador = value; }
        public string NomJugador { get => nomJugador; set => nomJugador = value; }
        public string NickJugador { get => nickJugador; set => nickJugador = value; }
        public int EdadJugador { get => edadJugador; set => edadJugador = value; }
        public string PaisJugador { get => paisJugador; set => paisJugador = value; }
        public char CapJugador { get => capJugador; set => capJugador = value; }
        public string RolJugador { get => rolJugador; set => rolJugador = value; }
        public int IdEquipo { get => idEquipo; set => idEquipo = value; }
    }
}
