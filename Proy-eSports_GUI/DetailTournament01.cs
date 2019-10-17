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

namespace Proy_eSports_GUI
{
    public partial class DetailTournament01 : Form
    {

        DetailTeamBL objDetailTeamBL = new DetailTeamBL();

        public DetailTournament01()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            dtgDeatilTeam.DataSource = objDetailTeamBL.ListDetailTeam();

        }

        private void DetailTournament01_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DetailTournament02 frm02 = new DetailTournament02();
            frm02.ShowDialog();
            CargarDatos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String idDetailTeam;
            idDetailTeam = dtgDeatilTeam.CurrentRow.Cells[0].Value.ToString();
            DetailTournament03 frm03 = new DetailTournament03();
            frm03.Codigo1 = idDetailTeam;
            frm03.Codigo2 = idDetailTeam;
            frm03.ShowDialog();
            CargarDatos();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
