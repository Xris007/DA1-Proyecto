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
    public class TournamentBL
    {
        TournamentADO objTournamentADO = new TournamentADO();

        public Boolean InsertTournament(TournamentBE objTournamentBE)
        {
            return objTournamentADO.InsertTournament(objTournamentBE);
        }
        public Boolean UpdateTournament(TournamentBE objTournamentBE)
        {
            return objTournamentADO.UpdateTournament(objTournamentBE);
        }
        public Boolean DeleteTournament (String TournId)
        {
            return objTournamentADO.DeleteTournament(TournId);
        }
        public TournamentBE ConsultTournament(String TournId)
        {
            return objTournamentADO.ConsultTournament(TournId);
        }
        public DataTable ListTournaments()
        {
            return objTournamentADO.ListTournaments();
        }
    }
}
