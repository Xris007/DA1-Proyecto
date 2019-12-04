using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_eSports_BL;

namespace SitioWEBeSports.Consultas.Complejidad
{
    public partial class WebAtributoComplejidad : System.Web.UI.Page
    {
        HeroeBL objHeroeBL = new HeroeBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    grvAtributo.DataSource = objHeroeBL.ListarHeroes();
                    grvAtributo.DataBind();
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
                grvAtributo.DataSource = objHeroeBL.ListarHeroePorComplejidadAtributo(
                    cboComplejidad.SelectedValue.ToString(),
                    cboAtributo.SelectedValue.ToString());
                grvAtributo.DataBind();

                

                if (grvAtributo.Rows.Count == 0)
                {
                    throw new Exception("No se ha encontrado resultados");
                }
                else
                {
                    lblResultado.Text = "Se ha encontrado: " + grvAtributo.Rows.Count.ToString() + "heroes con atributo " + grvAtributo.SelectedValue.ToString();
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