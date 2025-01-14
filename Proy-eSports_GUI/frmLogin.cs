﻿using System;
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
    public partial class frmLogin : Form
    {

        

        int intentos = 0;
        int tiempo = 20;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {


            DataTable dataTable = new DataTable();
            LoginBE loginBE = new LoginBE();
            LoginBL loginBL = new LoginBL();

            loginBE.user1 = txtUser.Text.Trim();
            loginBE.pass = txtPassword.Text.Trim();

            dataTable = loginBL.IngresarUsuario(loginBE.user1,loginBE.pass);



            if (txtUser.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {

               

                if (dataTable.Rows.Count == 1)
                {
                    loginBE.user1 = dataTable.Rows[0][0].ToString();
                    loginBE.pass = dataTable.Rows[0][1].ToString();

                    this.Hide();
                    timer1.Enabled = false;
                    MDIPrincipal mdi = new MDIPrincipal();
                    mdi.ShowDialog();

                    this.Visible = true;
                    tiempo = 20;
                    txtUser.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                    txtUser.Focus();
                    timer1.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Wrong username or password",
                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    if (intentos == 3)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Username or Password required",
                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
            }
            if (intentos == 3)
            {
                MessageBox.Show("We're sorry,  number of attemps exceeded",
                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Enter your username and password. You have left..." + tiempo;
            if(tiempo == 0)
            {
                MessageBox.Show("Sorry, timeout",
                   "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnIngresar.PerformClick();
            }
        }
    }
}
