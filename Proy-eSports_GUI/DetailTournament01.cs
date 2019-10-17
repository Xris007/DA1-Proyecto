using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy_eSports_GUI
{
    public partial class DetailTournament01 : Form
    {
        public DetailTournament01()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DetailTournament02 frm02 = new DetailTournament02();
            frm02.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DetailTournament03 frm03 = new DetailTournament03();
            frm03.ShowDialog();
        }
    }
}
