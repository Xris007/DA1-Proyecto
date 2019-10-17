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
    public partial class Team01 : Form
    {
        TeamBL objTeamBL = new TeamBL();
        public Team01()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            dtgTeam.DataSource = objTeamBL.ListTeams();
        }

   

        private void Team01_Load(object sender, EventArgs e)
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
            Team02 frm02 = new Team02();
            frm02.ShowDialog();
            CargarDatos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String idEquipo;
            idEquipo = dtgTeam.CurrentRow.Cells[0].Value.ToString();


            Team03 frm03 = new Team03();
            frm03.Codigo = idEquipo;
            frm03.ShowDialog();
            CargarDatos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Seguro(a) de eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    String idEquipo;
                    //obtener el codigo del proveedor sleccionado 
                    idEquipo = dtgTeam.CurrentRow.Cells[0].Value.ToString();

                    if (!objTeamBL.DeleteTeam(idEquipo))
                    {
                        throw new Exception("Error: No se actualizó el registro correctamente.");
                    }
                    CargarDatos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
