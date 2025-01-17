﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using ProyVentas_GUI;

namespace Proy_eSports_GUI
{
    public partial class MDIPrincipal : Form
    {
        TimeSpan timeenter = new TimeSpan();
        Computer myComputer = new Computer();
        String myRed = "";
        Boolean reiniciar = false;
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Team01 frm01 = new Team01();
            frm01.MdiParent = this;
            frm01.Show();
        }

        private void torneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tournament01 frm02 = new Tournament01();
            frm02.MdiParent = this;
            frm02.Show();
        }

        private void detailTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jugador01 frm03 = new Jugador01();
            frm03.MdiParent = this;
            frm03.Show();

        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reiniciar = false;
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reiniciar = false;
            this.Close();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Are you sure to exit the application?", "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void heroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hero01 frm04 = new Hero01();
            frm04.MdiParent = this;
            frm04.Show();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
