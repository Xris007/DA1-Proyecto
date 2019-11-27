using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_eSports_BL;

namespace SitioWEBeSports.Consultas.Jugador_Consulta
{
    public partial class WebJugadorCapitanPais : System.Web.UI.Page
    {
        JugadorBL objJugadorBL = new JugadorBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    cboPais.DataSource = objJugadorBL.ListarPaisJugador();
                    cboPais.DataTextField = "PaisJugador";                    
                    cboPais.DataValueField = "PaisJugador";
                    cboPais.DataBind();

                    cboPais.Items.Insert(0, new ListItem("Ninguno", "Ninguno"));
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
                if (cboPais.SelectedValue == "Ninguno")
                {
                    if (chkCapitan.Checked)
                    {
                        grvJugador.DataSource = objJugadorBL.ListarCapitanes();
                        grvJugador.DataBind();
                    }
                    else
                    {
                        grvJugador.DataSource = objJugadorBL.ListarJugador();
                        grvJugador.DataBind();
                    }                    
                }
                else
                {
                    if (chkCapitan.Checked)
                    {
                        grvJugador.DataSource = objJugadorBL.ListarCapitanesPorPais(
                            cboPais.SelectedValue.ToString()
                            );
                        grvJugador.DataBind();
                    }
                    else
                    {
                        grvJugador.DataSource = objJugadorBL.ListarJugadorPorPais(
                            cboPais.SelectedValue.ToString()
                            );
                        grvJugador.DataBind();
                    }
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