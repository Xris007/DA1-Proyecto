using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_eSports_BE;
using Proy_eSports_BL;

namespace SitioWEBeSports.Mantenimento
{
    public partial class WebJugadorCRUD : System.Web.UI.Page
    {
        JugadorBE jugadorBE = new JugadorBE();
        JugadorBL jugadorBL = new JugadorBL();
        TeamBL teamBL = new TeamBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    CargarDatos();

                    //insertar
                    dropEquipo.DataSource = teamBL.ListTeams();
                    dropEquipo.DataTextField = "NomEquipo";
                    dropEquipo.DataValueField = "IdEquipo";
                    dropEquipo.DataBind();

                    //actualizar
                    dropEquipo0.DataSource = teamBL.ListTeams();
                    dropEquipo0.DataTextField = "NomEquipo";
                    dropEquipo0.DataValueField = "IdEquipo";
                    dropEquipo0.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
        }

        private void CargarDatos()
        {
            GridView1.DataSource = jugadorBL.ListarJugador();
            GridView1.DataBind();


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtNick.Text = "";
            txtNombre.Text = "";
            chkCapitan.Checked = false;
            dropEquipo.SelectedIndex = 0;

            lblMensaje2.Text = "";

            txtNombre.Focus();
            PopMant.Show();
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                jugadorBE.IdJugador= 0;
                jugadorBE.NomJugador = txtNombre.Text.Trim();
                jugadorBE.ApeJugador= txtApellido.Text.Trim();
                jugadorBE.EdadJugador= Convert.ToInt16(txtEdad.Text.Trim());
                jugadorBE.NickJugador = txtNick.Text.Trim();
                jugadorBE.PaisJugador = txtPais.Text.Trim();
                jugadorBE.RolJugador = dropRol.SelectedValue.ToString();

                if (chkCapitan.Checked)
                {
                    jugadorBE.CapJugador = 'C';
                }
                else
                {
                    jugadorBE.CapJugador = 'X';
                }

                jugadorBE.IdEquipo = Convert.ToInt32(dropEquipo.SelectedValue);

                if (jugadorBL.InsertarJugador(jugadorBE))
                {
                    CargarDatos();
                }
                else
                {
                    throw new Exception("No se insertó correctamente el nuevo jugador.");
                }
            }
            catch (Exception ex)
            {
                lblMensaje2.Text = ex.Message;
                PopMant.Show();
            }
        }

        protected void btnGrabar2_Click(object sender, EventArgs e)
        {
            try
            {
                jugadorBE.IdJugador = Convert.ToInt32(lblJugador.Text);
                jugadorBE.NomJugador = txtNombre0.Text.Trim();
                jugadorBE.ApeJugador = txtApellido0.Text.Trim();
                jugadorBE.EdadJugador = Convert.ToInt16(txtEdad0.Text.Trim());
                jugadorBE.NickJugador = txtNick0.Text.Trim();
                jugadorBE.PaisJugador = txtPais0.Text.Trim();
                jugadorBE.RolJugador = dropRol0.SelectedValue.ToString();

                if (chkCapitan0.Checked)
                {
                    jugadorBE.CapJugador = 'C';
                }
                else
                {
                    jugadorBE.CapJugador = 'X';
                }

                jugadorBE.IdEquipo = Convert.ToInt32(dropEquipo0.SelectedValue);

                if (jugadorBL.ActualizarJugador(jugadorBE))
                {
                    CargarDatos();
                }
                else
                {
                    throw new Exception("No se actualizó correctamente el nuevo jugador.");
                }
            }
            catch (Exception ex)
            {
                lblMensaje3.Text = ex.Message;
                PopMant2.Show();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int row = Convert.ToInt16(e.CommandArgument);
                //chequea si se ha dado clic al buttonimage con el commando Editar
                if (e.CommandName == "Editar")
                {
                    String IdJugador = GridView1.Rows[row].Cells[1].Text;

                    jugadorBE = jugadorBL.ConsultarJugador(IdJugador);

                    lblJugador.Text = jugadorBE.IdJugador.ToString();
                    txtNombre0.Text = jugadorBE.NomJugador;
                    txtApellido0.Text = jugadorBE.ApeJugador;
                    txtEdad0.Text = jugadorBE.EdadJugador.ToString();
                    txtNick0.Text = jugadorBE.NickJugador;
                    txtPais0.Text = jugadorBE.PaisJugador;

                    if (jugadorBE.CapJugador == 'X')
                    {
                        chkCapitan0.Checked = false;
                    }
                    else chkCapitan0.Checked = true;

                    dropRol0.SelectedValue = jugadorBE.RolJugador;
                    dropEquipo0.SelectedValue = jugadorBE.IdEquipo.ToString();

                    lblMensaje3.Text = "";
                    PopMant2.Show();
                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String idJugador = lblJugador.Text;


                if (jugadorBL.EliminarJugador(idJugador))
                {
                    CargarDatos();
                }
                else
                {
                    throw new Exception("No se eliminó correctamente el jugador.");
                }
            }
            catch (Exception ex)
            {
                lblMensaje3.Text = ex.Message;
                PopMant2.Show();
            }
        }
    }
}