using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proy_eSports_BL;
using Proy_eSports_BE;

namespace Proy_eSports_GUI
{
    public partial class DetailTournament02 : Form
    {
        TeamBL objTeamBL = new TeamBL();
        TournamentBL objTournamentBL = new TournamentBL();

        DetailTeamBL objDetailTeamBL = new DetailTeamBL();
        DetailTeamBE objDetailTeamBE = new DetailTeamBE();

        public DetailTournament02()
        {
            InitializeComponent();
        }

        private void DetailTournament02_Load(object sender, EventArgs e)
        {
            try
            {

                cboTeam.DataSource = objTeamBL.ListTeams();
                cboTeam.ValueMember = "IdEquipo";
                cboTeam.DisplayMember = "NomEquipo";

                cboTournament.DataSource = objTournamentBL.ListTournaments();
                cboTournament.ValueMember = "IdTorneo";
                cboTournament.DisplayMember = "NomTorneo";

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                objDetailTeamBE.Victorias = Convert.ToInt32(txtVictories.Text.Trim());
                objDetailTeamBE.Derrotas = Convert.ToInt32(txtDefeats.Text.Trim());
                objDetailTeamBE.Puesto = Convert.ToInt32(txtPlacement.Text.Trim());

                if (objDetailTeamBL.InsertDetailTeam(objDetailTeamBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error:");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
