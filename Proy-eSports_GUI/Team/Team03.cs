using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proy_eSports_BL;
using Proy_eSports_BE;

namespace Proy_eSports_GUI
{
    public partial class Team03 : Form
    {
        TeamBL objTeamBL = new TeamBL();
        TeamBE objTeamBE = new TeamBE();
        public Team03()
        {
            InitializeComponent();
        }
        String idEquipo;
        public String Codigo
        {
            get { return idEquipo; }
            set { idEquipo = value; }
        }

        private void Team03_Load(object sender, EventArgs e)
        {
            try
            {
                objTeamBE = objTeamBL.ConsultTeam(Codigo);
                txtTeamName.Text = objTeamBE.NomEquipo;
                txtCountry.Text = objTeamBE.PaisEquipo;
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
                objTeamBE.NomEquipo = txtTeamName.Text.Trim();
                objTeamBE.PaisEquipo = txtCountry.Text.Trim();

                if (objTeamBL.UpdateTeam(objTeamBE) == true)
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
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
