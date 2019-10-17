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
    public class TeamBL
    {
        TeamADO objTeamADO = new TeamADO();
        public Boolean InsertTeam(TeamBE objTeamBE)
        {
            return objTeamADO.InsertTeam(objTeamBE);
        }
        public Boolean UpdateTeam(TeamBE objTeamBE)
        {
            return objTeamADO.UpdateTeam(objTeamBE);
        }
        public Boolean DeleteTeam(String TeamId)
        {
            return objTeamADO.DeleteTeam(TeamId);
        }
        public TeamBE ConsultTeam(String TeamId)
        {
            return objTeamADO.ConsultTeam(TeamId);
        }
        public DataTable ListTeams()
        {
            return objTeamADO.ListTeams();
        }
    }
}
