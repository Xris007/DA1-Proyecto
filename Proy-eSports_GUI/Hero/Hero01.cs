using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Proy_eSports_BL;

namespace Proy_eSports_GUI
{
    public partial class Hero01 : Form
    {
        HeroeBL objHeroeBL = new HeroeBL();
        public Hero01()
        {
            InitializeComponent();
            //MaterialSkinManager m = MaterialSkinManager.Instance;
            //m.AddFormToManage(this);
            //m.Theme = MaterialSkinManager.Themes.LIGHT;
            //m.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green700,Primary.Green500,Accent.LightGreen200,TextShade.WHITE);
            
        }
        public void CargarDatos()
        {
            dtgHero.DataSource = objHeroeBL.ListarHeroes();

        }

        private void Hero01_Load(object sender, EventArgs e)
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
            Hero02 frm02 = new Hero02();
            frm02.ShowDialog();
            CargarDatos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String idHeroe;

            idHeroe = dtgHero.CurrentRow.Cells[0].Value.ToString();

            Hero03 frm03 = new Hero03();
            frm03.Codigo = idHeroe;
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
                    String idHeoe;
                    //obtener el codigo del proveedor sleccionado 
                    idHeoe = dtgHero.CurrentRow.Cells[0].Value.ToString();

                    if (!objHeroeBL.DeleteHero(idHeoe))
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
