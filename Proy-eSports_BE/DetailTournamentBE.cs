using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_eSports_BE
{
    public class DetailTournamentBE
    {
        private int mvarid_equipo;
        public int IdEquipo
        {
            get { return mvarid_equipo; }
            set { mvarid_equipo = value; }
        }
        private int mvarid_torneo;
        public int IdTorneo
        {
            get { return mvarid_torneo; }
            set { mvarid_torneo = value; }
        }
        private int mvarvic_detalle;
        public int Victorias
        {
            get { return mvarvic_detalle; }
            set { mvarvic_detalle = value; }
        }
        private int mvarder_detalle;
        public int Derrotas
        {
            get { return mvarder_detalle; }
            set { mvarder_detalle = value; }
        }
        private int mvarpuesto_detalle;
        public int Puesto
        {
            get { return mvarpuesto_detalle; }
            set { mvarpuesto_detalle = value; }
        }
    }
}
