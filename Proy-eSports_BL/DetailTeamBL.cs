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
    public class DetailTeamBL
    {
        DetailTeamADO objDetailADO = new DetailTeamADO();

        

        public Boolean InsertDetailTeam(DetailTeamBE objDetailBE)
        {
            return objDetailADO.InsertDetailTeam(objDetailBE);
        }
        public Boolean UpdateDetailTeam(DetailTeamBE objDetailBE)
        {
            return objDetailADO.UpdateDetailTeam(objDetailBE);
        }
        public Boolean DeleteDetailTeam(String TeamId, String TounId)
        {
            return objDetailADO.DeleteDetailTeam(TeamId, TounId);
        }
        public DetailTeamBE ConsultDetailTeam(String TeamId, String TounId)
        {
            return objDetailADO.ConsultDetailTeam(TeamId, TounId);
        }
        public DataTable ListDetailTeam()
        {
            return objDetailADO.ListDetailTeam();
        }
        public DataTable ListDetailTeambyTournaments(String TeamId, String TounId1, String TounId2)
        {
            return objDetailADO.ListDetailTeambyTournaments(TeamId,TounId1,TounId2);
        }
       

    }
}
