using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proy_eSports_BL;
using Proy_eSports_BE;
namespace ProyVentas_GUI
{
    public partial class Jugador02 : Form
    {
        TeamBL teamBL = new TeamBL();
        JugadorBE jugadorBE = new JugadorBE();
        JugadorBL JugadorBL = new JugadorBL();
            

        public Jugador02()
        {
            InitializeComponent();
        }

        private void ProveedorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                cboEquipo.DataSource = teamBL.ListTeams();
                cboEquipo.ValueMember = "IdEquipo";
                cboEquipo.DisplayMember = "NomEquipo"; //lo que el usuario verá

                cboRol.ValueMember = cboRol.DisplayMember;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
           

            try
            {
                jugadorBE.IdJugador = 0; //se encarga el store procedure
                jugadorBE.ApeJugador = txtApellido.Text.Trim();
                jugadorBE.NomJugador = txtNombre.Text.Trim();
                jugadorBE.NickJugador = txtNick.Text.Trim();
                jugadorBE.RolJugador = cboRol.SelectedItem.ToString();
                jugadorBE.EdadJugador = Convert.ToInt16(txtEdad.Text.Trim());
                jugadorBE.PaisJugador = txtPais.Text.Trim();

                if (chkCapitan.Checked)
                {
                    jugadorBE.CapJugador = 'C';
                }
                else
                {
                    jugadorBE.CapJugador = 'X';
                }

                jugadorBE.IdEquipo = Convert.ToInt32(cboEquipo.SelectedValue.ToString());

                if (JugadorBL.InsertarJugador(jugadorBE)== true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error: No se inserto el jugador. Contacte con IT.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
