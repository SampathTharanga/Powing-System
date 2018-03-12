using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Powing_System
{
    public partial class ucPowingOfficer : UserControl
    {

        Officer ObjOff = new Officer();

        public static DataGridView dgvOfficer = new DataGridView();

        //ucPowingOfficer open main form for create method and object
        private static ucPowingOfficer powingOff_instance;
        public static ucPowingOfficer powingOffOpen
        {
            get
            {
                powingOff_instance = null;

                if (powingOff_instance == null)
                    powingOff_instance = new ucPowingOfficer();
                return powingOff_instance;
            }
        }
        public ucPowingOfficer()
        {
            InitializeComponent();
        }

        private void ucPowingOfficer_Load(object sender, EventArgs e)
        {
            try {
                dgvOfficer = dgv_PowingOfficer;

                //display date
                lbl_Date.Text = DateTime.Today.ToShortDateString();

                //textbox clear
                txt_ConfirmPass.Clear();
                txt_OfficerID.Clear();
                txt_Password.Clear();

                //load data for datagridview
                string selectOffi = "SELECT * FROM tbl_Officer";
                SqlDataAdapter da = new SqlDataAdapter(selectOffi, ConnectionDB.Connection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dgv_PowingOfficer.DataSource = bs;
                da.Update(dt);


                //Avalable user details

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ConfirmPass.Clear();
            txt_OfficerID.Clear();
            txt_Password.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Password.Text == txt_ConfirmPass.Text) && (txt_Password.Text != "" && txt_Password.Text != null) && (txt_ConfirmPass.Text != "" && txt_ConfirmPass.Text != null) && (txt_OfficerID.Text != "" && txt_OfficerID.Text != null))
                {
                    ObjOff.addOfficer(lbl_Date.Text, txt_OfficerID.Text, txt_Password.Text);
                    MessageBox.Show("User added complete!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ConfirmPass.Clear();
                    txt_OfficerID.Clear();
                    txt_Password.Clear();

                    //Reload table officer data for datagridview
                    string selectTab = "SELECT * FROM tbl_Officer";
                    SqlDataAdapter da = new SqlDataAdapter(selectTab, ConnectionDB.Connection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_PowingOfficer.DataSource = dt;

                }
                else
                    MessageBox.Show("Your detail Wrrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string offID = dgv_PowingOfficer.CurrentRow.Cells["officerID"].Value.ToString();
            //string pass = dgv_PowingOfficer.CurrentRow.Cells["password"].Value.ToString();

            frm_EditOfficer feo = new frm_EditOfficer(offID);
            feo.ShowDialog();
        }

        private void txt_OfficerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip1.Show("Plase enter Number and Caractor!", txt_OfficerID, 0, -50, 700);
                e.Handled = true;
            }
        }
    }
}
