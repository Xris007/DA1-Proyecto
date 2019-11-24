using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_eSports_BL;

namespace SitioWEBeSports.Consultas.Team_Consulta
{
    public partial class WebEquiposDetalle : System.Web.UI.Page
    {
        TeamBL objTeamBL = new TeamBL();
        TournamentBL objTournamentBL = new TournamentBL();
        DetailTeamBL objDetailTeamBL = new DetailTeamBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    //Combo Cliente
                    cboTeam.DataSource      = objTeamBL.ListTeams();
                    cboTeam.DataTextField   = "NomEquipo";
                    cboTeam.DataValueField  = "IdEquipo";
                    cboTeam.DataBind();

                    //Combo Torneo
                    cboTmnt1.DataSource     = objTournamentBL.ListTournaments();
                    cboTmnt1.DataTextField  = "NomTorneo";
                    cboTmnt1.DataValueField = "IdTorneo";
                    cboTmnt1.DataBind();

                    cboTmnt2.DataSource = objTournamentBL.ListTournaments();
                    cboTmnt2.DataTextField = "NomTorneo";
                    cboTmnt2.DataValueField = "IdTorneo";
                    cboTmnt2.DataBind();



                }
            }
            catch (Exception ex)
            {
                lblMensaje1.Text = ex.Message;
            }
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                grvDetailTeam.DataSource = objDetailTeamBL.ListDetailTeambyTournaments(
                    cboTeam.SelectedValue.ToString(),
                    cboTmnt1.SelectedValue.ToString(),
                    cboTmnt2.SelectedValue.ToString()
                    );
                grvDetailTeam.DataBind();
                
                if (grvDetailTeam.Rows.Count == 0)
                {
                    throw new Exception("El equipo " + (cboTeam.DataTextField = "NomEquipo") + " no ha participado entre los torneos " + cboTmnt1.DataTextField + " y " + cboTmnt2.DataTextField);
                }
            }
            catch (Exception ex)
            {
                lblMensaje1.Text = ex.Message;
            }
        }
    }
}