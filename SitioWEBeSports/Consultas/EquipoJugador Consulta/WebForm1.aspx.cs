using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_eSports_BL;

namespace SitioWEBeSports.Consultas.EquipoJugador_Consulta
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        JugadorBL objJugadorBL = new JugadorBL();
        TeamBL objTeamBL = new TeamBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    cboEquipos.DataSource = objTeamBL.ListTeams();
                    cboEquipos.DataTextField = "NomEquipo";
                    cboEquipos.DataValueField = "IdEquipo";
                    cboEquipos.DataBind();

                    cboEquipos.Items.Insert(0, new ListItem("Ninguno", "Ninguno"));


                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                grvJugadores.DataSource = objJugadorBL.ListarJugadorequipo(
                    cboEquipos.SelectedValue.ToString()
                    );
                grvJugadores.DataBind();

                if (grvJugadores.Rows.Count == 0)
                {
                    throw new Exception("No hay jugadores en este equipo");
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}