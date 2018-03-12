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
    public partial class frm_editInsterest : Form
    {

        Insterest ObjIns = new Insterest();

        private int inum;

        public frm_editInsterest(int ino,float rate)
        {
            InitializeComponent();

            txt_newInsRate.Text = rate.ToString();
            inum = ino;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try {
                ObjIns.updateOnsterest(float.Parse(txt_newInsRate.Text), inum);
                MessageBox.Show("Update Complete!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataSet ds = ObjIns.selectInData();
                ucPowingDetails.dtagvIn.DataSource = ds.Tables["tbl_interest"];

                txt_newInsRate.Clear();

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
