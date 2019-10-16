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
    public partial class Team01 : Form
    {
        public Team01()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Team02 frm02 = new Team02();
            frm02.ShowDialog();
        }
    }
}
