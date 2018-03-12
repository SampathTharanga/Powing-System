using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powing_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();

            //loading ucControl for main form panel.
            if (!pnlMain.Controls.Contains(ucCustomer.cusOpen))
            {
                pnlMain.Controls.Add(ucCustomer.cusOpen);
                ucCustomer.cusOpen.Dock = DockStyle.Fill;
                ucCustomer.cusOpen.BringToFront();
            }
            else
                ucCustomer.cusOpen.BringToFront();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                pnlMain.Controls.Clear();

            //close old open forms
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[1].Name == "frm_Login")
                    Application.OpenForms[1].Close();
            }


            //loading ucCustomer for main panel.
            if (!pnlMain.Controls.Contains(ucCustomer.cusOpen))
                {
                    pnlMain.Controls.Add(ucCustomer.cusOpen);
                    ucCustomer.cusOpen.Dock = DockStyle.Fill;
                    ucCustomer.cusOpen.BringToFront();
                }
                else
                    ucCustomer.cusOpen.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();

            //loading ucViewCustomer for main panel
            if (!pnlMain.Controls.Contains(ucViewCustomer.viewCusOpen))
            {
                pnlMain.Controls.Add(ucViewCustomer.viewCusOpen);
                ucViewCustomer.viewCusOpen.Dock = DockStyle.Fill;
                ucViewCustomer.viewCusOpen.BringToFront();
            }
            else
                ucViewCustomer.viewCusOpen.BringToFront();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();

            //loading ucViewCustomer for main panel
            if (!pnlMain.Controls.Contains(ucPowingDetails.powing_open))
            {
                pnlMain.Controls.Add(ucPowingDetails.powing_open);
                ucPowingDetails.powing_open.Dock = DockStyle.Fill;
                ucPowingDetails.powing_open.BringToFront();
            }
            else
            {
                ucPowingDetails.powing_open.BringToFront();
                ucPowingDetails.powing_open.Refresh();
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();

            //loading ucPowingOfficer for main panel
            if (!pnlMain.Controls.Contains(ucPowingOfficer.powingOffOpen))
            {
                pnlMain.Controls.Add(ucPowingOfficer.powingOffOpen);
                ucPowingOfficer.powingOffOpen.Dock = DockStyle.Fill;
                ucPowingOfficer.powingOffOpen.BringToFront();
            }
            else
            {
                ucPowingOfficer.powingOffOpen.BringToFront();
               // ucPowingOfficer.powingOffOpen.Refresh();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();

            //loading ucViewPowingOfficer for main panel
            if (!pnlMain.Controls.Contains(ucViewPowingOfficer.ViewpowingOffOpen))
            {
                pnlMain.Controls.Add(ucViewPowingOfficer.ViewpowingOffOpen);
                ucViewPowingOfficer.ViewpowingOffOpen.Dock = DockStyle.Fill;
                ucViewPowingOfficer.ViewpowingOffOpen.BringToFront();
            }
            else
                ucViewPowingOfficer.ViewpowingOffOpen.BringToFront();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login fl = new frm_Login();
            fl.Show();
            this.Hide();
        }

        private void jewelleryTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TypeOfJewellery toj = new frm_TypeOfJewellery();
            toj.ShowDialog();
        }
    }
}
