using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proy_eSports_BE;
using Proy_eSports_BL;

namespace Proy_eSports_GUI
{
    public partial class Tournament03 : Form
    {
        TournamentBL objTournamentBL = new TournamentBL();
        TournamentBE objTournamentBE = new TournamentBE();
        public Tournament03()
        {
            InitializeComponent();
        }
        String idTournament;
        public String Codigo
        {
            get { return idTournament; }
            set { idTournament = value; }
        }

        private void Tournament03_Load(object sender, EventArgs e)
        {
            try
            {
                objTournamentBE = objTournamentBL.ConsultTournament(Codigo);
                txtTourName.Text = objTournamentBE.NomTorneo;
                txtOrgTour.Text = objTournamentBE.OrgTorneo;
                txtCountry.Text = objTournamentBE.PaisTorneo;
                txtLocation.Text = objTournamentBE.LugarTorneo;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                objTournamentBE.NomTorneo = txtTourName.Text.Trim();
                objTournamentBE.OrgTorneo = txtOrgTour.Text.Trim();
                objTournamentBE.PaisTorneo = txtCountry.Text.Trim();
                objTournamentBE.LugarTorneo = txtLocation.Text.Trim();
                objTournamentBE.FechaInicioTorneo = dtpStart.Value;
                objTournamentBE.FechaFinTorneo = dtpEnd.Value;

                if (objTournamentBL.UpdateTournament(objTournamentBE) == true)
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
    }
}
