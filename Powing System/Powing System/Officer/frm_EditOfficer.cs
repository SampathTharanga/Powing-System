using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Powing_System
{
    public partial class frm_EditOfficer : Form
    {

        Officer objOffice = new Officer();

        public frm_EditOfficer(string id)
        {
            InitializeComponent();

            lbl_OfficerID.Text = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if ((lbl_OfficerID.Text != "" && lbl_OfficerID.Text != null) && (txt_curPass.Text != "" && txt_curPass.Text != null))
                {
                    string password;
                    SqlDataReader dr = objOffice.selectUser(lbl_OfficerID.Text);
                    if (dr.Read() == true)
                    {
                        password = dr["password"].ToString();
                        if (txt_curPass.Text == password)
                        {
                            txt_ReEnterNewPass.Enabled = true;
                            txt_newPass.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter current password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_curPass.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not Avalable!");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter current password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if ((txt_newPass.Text != "" && txt_newPass.Text != null) && (txt_ReEnterNewPass.Text != "" && txt_ReEnterNewPass.Text != null))
            {
                if (txt_newPass.Text == txt_ReEnterNewPass.Text)
                {
                    objOffice.updateOfficer(txt_newPass.Text, lbl_OfficerID.Text);
                    MessageBox.Show("Update Complete!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataSet ds = objOffice.selectData();
                    ucPowingOfficer.dgvOfficer.DataSource = ds.Tables["tbl_Officer"];

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter valide password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_newPass.Clear();
                    txt_ReEnterNewPass.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Enter valid new password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_newPass.Clear();
                txt_ReEnterNewPass.Clear();
            }
        }
    }
}
