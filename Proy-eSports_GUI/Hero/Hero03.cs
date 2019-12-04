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
    public partial class Hero03 : Form
    {
        HeroeBL objHeroeBL = new HeroeBL();
        HeroeBE objHeroeBE = new HeroeBE();
        public Hero03()
        {
            InitializeComponent();
        }
        String idHeroe;
        public String Codigo
        {
            get { return idHeroe; }
            set { idHeroe = value; }
        }

        private void Hero03_Load(object sender, EventArgs e)
        {
            try
            {
                objHeroeBE = objHeroeBL.ConsultHero(Codigo);
                txtNomHeroe.Text = objHeroeBE.NomHeroe;
                txtAtributo.Text = objHeroeBE.Atributo;
                txtTipo.Text = objHeroeBE.Tipo;
                txtComplejidad.Text = objHeroeBE.Complejidad;
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
                objHeroeBE.NomHeroe = txtNomHeroe.Text.Trim();
                objHeroeBE.Atributo = txtAtributo.Text.Trim();
                objHeroeBE.Tipo = txtTipo.Text.Trim();

                if(objHeroeBL.UpdateHero(objHeroeBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error: ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
