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
    public partial class Hero02 : Form
    {
        HeroeBL objHeroeBL = new HeroeBL();
        HeroeBE objHeroeBE = new HeroeBE();
        public Hero02()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                objHeroeBE.NomHeroe = txtNomHeroe.Text.Trim();
                objHeroeBE.Atributo = txtAtributo.Text.Trim();
                objHeroeBE.Tipo = txtTipo.Text.Trim();
                objHeroeBE.Complejidad = txtComplejidad.Text.Trim();
               

                if (objHeroeBL.InsertHero(objHeroeBE) == true)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
