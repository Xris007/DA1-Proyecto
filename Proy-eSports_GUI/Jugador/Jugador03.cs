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
    public partial class Jugador03 : Form
    {
        TeamBL teamBL = new TeamBL();
        JugadorBE jugadorBE = new JugadorBE();
        JugadorBL JugadorBL = new JugadorBL();


        public Jugador03()
        {
            InitializeComponent();
        }

        String idJugador;
        public String Codigo
        {
            get { return idJugador; }
            set { idJugador = value; }
        }
         private void ProveedorMan03_Load(object sender, EventArgs e)
        {
           try
            {


                cboEquipo.DataSource = teamBL.ListTeams();
                cboEquipo.ValueMember = "IdEquipo";
                cboEquipo.DisplayMember = "NomEquipo";

                jugadorBE = JugadorBL.ConsultarJugador(Codigo);

                txtApellido.Text = jugadorBE.ApeJugador;
                txtNombre.Text = jugadorBE.NomJugador;
                txtNick.Text = jugadorBE.NickJugador;
                txtEdad.Text = jugadorBE.EdadJugador.ToString();
                txtPais.Text = jugadorBE.PaisJugador;

                if (jugadorBE.CapJugador == 'C')
                {
                    chkCapitan.Checked = true;
                }

                cboRol.SelectedText = jugadorBE.RolJugador.ToString();
                cboEquipo.SelectedValue = jugadorBE.IdEquipo;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            try
             {                
                jugadorBE.ApeJugador = txtApellido.Text.Trim();
                jugadorBE.NomJugador = txtNombre.Text.Trim();
                jugadorBE.NickJugador = txtNick.Text.Trim();

                if (cboRol.SelectedItem != null)
                {
                    jugadorBE.RolJugador = cboRol.SelectedItem.ToString();
                }

                
                jugadorBE.EdadJugador = Convert.ToInt16(txtEdad.Text.Trim());
                jugadorBE.PaisJugador = txtPais.Text.Trim();

                if (chkCapitan.Checked)
                {
                    jugadorBE.CapJugador = 'C';
                }
                else if (!chkCapitan.Checked)
                {
                    jugadorBE.CapJugador = 'X';
                }

                jugadorBE.IdEquipo = Convert.ToInt32(cboEquipo.SelectedValue.ToString());

                if (JugadorBL.ActualizarJugador(jugadorBE) == true)
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
