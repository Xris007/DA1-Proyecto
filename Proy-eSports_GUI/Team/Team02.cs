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
    public partial class Team02 : Form
    {
        TeamBL objTeamBL = new TeamBL();
        TeamBE objTeamBE = new TeamBE();
        public Team02()
        {
            InitializeComponent();
        }

        private void Team02_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objTeamBE.NomEquipo = txtTeamName.Text.Trim();
                objTeamBE.PaisEquipo = txtCountry.Text.Trim();

                if (objTeamBL.InsertTeam(objTeamBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error: No se inserto el registro. Contacte con IT.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }
    }
}
