using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proy_eSports_BL;

namespace ProyVentas_GUI
{
    public partial class Jugador01 : Form
    {

        JugadorBL jugadorBL = new JugadorBL();


        public Jugador01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgJugador.DataSource = jugadorBL.ListarJugador();

        }

        private void ProveedorMan01_Load(object sender, EventArgs e)
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



        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Jugador02 frm02 = new Jugador02();
            frm02.ShowDialog();
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String idJugador;
            idJugador = dtgJugador.CurrentRow.Cells[0].Value.ToString();


            Jugador03 frm03 = new Jugador03();
            frm03.Codigo = idJugador;
            frm03.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Seguro(a) de eliminar este jugador?", "Confirmar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    String idJugador;
                    //obtener el codigo del proveedor sleccionado 
                    idJugador = dtgJugador.CurrentRow.Cells[0].Value.ToString();

                    if (!jugadorBL.EliminarJugador(idJugador))
                    {
                        throw new Exception("Error: No se eliminó el registro correctamente.");
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
