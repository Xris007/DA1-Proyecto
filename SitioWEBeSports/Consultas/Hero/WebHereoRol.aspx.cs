using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_eSports_BL;

namespace SitioWEBeSports.Consultas.Hero_Consulta
{
    public partial class WebHereoRol : System.Web.UI.Page
    {
        JugadorBL objJugadorBL = new JugadorBL();
        HeroeBL objHeroeBL = new HeroeBL();
        PartidaJugadorBL objPartidaJugadorBL = new PartidaJugadorBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                   
                    cboHeroe.DataSource = objHeroeBL.ListarHeroes();
                    cboHeroe.DataTextField = "NomHeroe";
                    cboHeroe.DataValueField = "NomHeroe";
                    cboHeroe.DataBind();

                    
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
        }

        protected void IdMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                grvHereoRolDetalle.DataSource = objPartidaJugadorBL.ListarHeroeRol(
                    cboHeroe.SelectedValue.ToString(),
                    cboRol.SelectedValue.ToString().Trim());
                grvHereoRolDetalle.DataBind();

                lblResultado.Text = "Se han encontrado: " + grvHereoRolDetalle.Rows.Count.ToString() + " resultados";

                if (grvHereoRolDetalle.Rows.Count == 0)
                {
                    throw new Exception("No se ha encontrado resultados");
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