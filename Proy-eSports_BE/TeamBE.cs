using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_eSports_BE
{
    public class TeamBE
    {
        private int mvarid_equipo;
        public int IdEquipo
        {
            get { return mvarid_equipo; }
            set { mvarid_equipo = value; }
        }
        private String mvarnom_equipo;
        public String NomEquipo
        {
            get { return mvarnom_equipo; }
            set { mvarnom_equipo = value; }
        }
        private String mvarpais_equipo;
        public String PaisEquipo
        {
            get { return mvarpais_equipo; }
            set { mvarpais_equipo = value; }
        }
    }
}
