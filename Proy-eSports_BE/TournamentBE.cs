using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_eSports_BE
{
    public class TournamentBE
    {
        private int mvarid_torneo;
        public int IdTorneo
        {
            get { return mvarid_torneo; }
            set { mvarid_torneo = value; }
        }
        private String mvarnom_torneo;
        public String NomTorneo
        {
            get { return mvarnom_torneo; }
            set { mvarnom_torneo = value; }
        }
        private String mvarorg_torneo;
        public String OrgTorneo
        {
            get { return mvarorg_torneo; }
            set { mvarorg_torneo = value; }
        }
        private String mvarpais_torneo;
        public String PaisTorneo
        {
            get { return mvarpais_torneo; }
            set { mvarpais_torneo = value; }
        }
        private String mvarlugar_torneo;
        public String LugarTorneo
        {
            get { return mvarlugar_torneo; }
            set { mvarlugar_torneo = value; }
        }
        private DateTime mvarfechainicio_torneo;
        public DateTime FechaInicioTorneo
        {
            get { return mvarfechainicio_torneo; }
            set { mvarfechainicio_torneo = value; }
        }
        private DateTime mvarfechafin_torneo;
        public DateTime FechaFinTorneo
        {
            get { return mvarfechafin_torneo; }
            set { mvarfechafin_torneo = value; }
        }
        private int mvarid_juego;
        public int IdJuego
        {
            get { return mvarid_juego; }
            set { mvarid_juego = value; }
        }
    }
}
