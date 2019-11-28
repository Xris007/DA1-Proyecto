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
                    cboTorneo.DataSource     = objTournamentBL.ListTournaments();
                    cboTorneo.DataTextField  = "NomTorneo";
                    cboTorneo.DataValueField = "IdTorneo";
                    cboTorneo.DataBind();

                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                grvDetailTeam.DataSource = objDetailTeamBL.ListDetailTeambyTournaments(
                    cboTeam.SelectedValue.ToString(),
                    cboTorneo.SelectedValue.ToString());
                grvDetailTeam.DataBind();

                lblResultado.Text = "El Equipo seleccionado ha participado en: " + grvDetailTeam.Rows.Count.ToString() + " Torneo";

                if (grvDetailTeam.Rows.Count == 0)
                {
                    throw new Exception("El equipo seleccionado no registra participacion en el torneo seleccionado");
                }
                
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
        }
    }
}