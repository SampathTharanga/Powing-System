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

namespace Powing_System
{
    public partial class ucPowingDetails : UserControl
    {
        Insterest ObjIns = new Insterest();
        carat objCa = new carat();

        DataTable dt;
        SqlDataAdapter da;
        BindingSource bs;

        public static DataGridView dtagvCa = new DataGridView();
        public static DataGridView dtagvIn = new DataGridView();

        //ucPowingDetails open main form for create method and object
        private static ucPowingDetails Powing_instance;


        public static ucPowingDetails powing_open
        {
            get
            {
                Powing_instance = null;

                if (Powing_instance == null)
                    Powing_instance = new ucPowingDetails();
                return Powing_instance;
            }
        }
        public ucPowingDetails()
        {
            InitializeComponent();
        }

        public void loadingDgvCarat()
        {
            //load carat details
            string selectDetails = "SELECT * FROM tbl_Carat";
            da = new SqlDataAdapter(selectDetails, ConnectionDB.Connection());
            dt = new DataTable();
            da.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dgv_CaratDetails.DataSource = bs;
            da.Update(dt);
        }
        public void loadingDgvInterest()
        {

            //load insterest details
            string selectInData = "SELECT * FROM tbl_interest";
            da = new SqlDataAdapter(selectInData, ConnectionDB.Connection());
            dt = new DataTable();
            da.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dgv_insterestRate.DataSource = bs;
            da.Update(dt);
        }

        private void ucPowingDetails_Load(object sender, EventArgs e)
        {
            dtagvCa = dgv_CaratDetails;
            dtagvIn = dgv_insterestRate;

            //Auto asssign number for interest Rate
            lbl_Rate.Text = ObjIns.autoNointerest().ToString();

            loadingDgvCarat();
            loadingDgvInterest();
        }

        private void btn_AddRate_Click(object sender, EventArgs e)
        {
            try {
                //Add Insterest Rate details
                if (txt_NewRate.Text == "" || txt_NewRate.Text == null)
                {
                    MessageBox.Show("Please enter Data!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ObjIns.addInsterest(int.Parse(lbl_Rate.Text), float.Parse(txt_NewRate.Text));
                    MessageBox.Show("Added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_NewRate.Clear();
                    lbl_Rate.Text = ObjIns.autoNointerest().ToString();
                    loadingDgvInterest();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try {
                if (txt_CaratPrice.Text == "" || txt_CaratType.Text == null)
                {
                    MessageBox.Show("Please enter data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    objCa.addCarat(int.Parse(txt_CaratType.Text), float.Parse(txt_CaratPrice.Text));
                    MessageBox.Show("Added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_CaratPrice.Clear();
                    txt_CaratType.Clear();
                    loadingDgvCarat();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            //Edit data in carat table.
            #region Edit data in carat table
            try
            {
                int cno = int.Parse(dgv_CaratDetails.CurrentRow.Cells["caratNo"].Value.ToString());
                string ct = dgv_CaratDetails.CurrentRow.Cells["caratType"].Value.ToString();
                string pr = dgv_CaratDetails.CurrentRow.Cells["priceOf1Carat"].Value.ToString();

                if (ct == "" || ct == null)
                {
                    MessageBox.Show("Please select row!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frm_editCarat fe = new frm_editCarat(ct, pr, cno);
                    fe.ShowDialog();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void btn_EditRate_Click(object sender, EventArgs e)
        {
            //Edit data in interest table.
            #region Edit data in interest table
            try
            {

                int inum = int.Parse(dgv_insterestRate.CurrentRow.Cells["RateNo"].Value.ToString());
                float rt = float.Parse(dgv_insterestRate.CurrentRow.Cells["Rate"].Value.ToString());


                frm_editInsterest fi = new frm_editInsterest(inum, rt);
                fi.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void txt_NewRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                toolTip1.Show("Plase enter floating point number!", txt_NewRate, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_CaratType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip2.Show("Please enter numbers!", txt_CaratType, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_CaratPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                toolTip3.Show("Plase enter floating point number!", txt_CaratPrice, 0, -50, 700);
                e.Handled = true;
            }
        }
    }
}
