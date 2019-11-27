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
    public partial class Tournament01 : Form
    {

        TournamentBL objTournamentBL = new TournamentBL();

        public Tournament01()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            dtgTournament.DataSource = objTournamentBL.ListTournaments();

        }

        private void Tournament01_Load(object sender, EventArgs e)
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
            Tournament02 frm02 = new Tournament02();
            frm02.ShowDialog();
            CargarDatos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String idTournament;

            idTournament = dtgTournament.CurrentRow.Cells[0].Value.ToString();

            Tournament03 frm03 = new Tournament03();
            frm03.Codigo = idTournament;
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
                    String idTournament;
                    //obtener el codigo del proveedor sleccionado 
                    idTournament = dtgTournament.CurrentRow.Cells[0].Value.ToString();

                    if (!objTournamentBL.DeleteTournament(idTournament))
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
