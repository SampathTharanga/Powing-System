using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Powing_System
{
    public partial class ucViewCustomer : UserControl
    {
        //ucViewCustomer open main form create method and object.
        private static ucViewCustomer viewCusInstance;
        public static ucViewCustomer viewCusOpen
        {
            get
            {
                viewCusInstance = null;

                if (viewCusInstance == null)
                    viewCusInstance = new ucViewCustomer();
                return viewCusInstance;
            }
        }
        public ucViewCustomer()
        {
            InitializeComponent();
        }


        public static DataGridView dgvCustomer = new DataGridView();

        public void loadData()
        {
            string selectDB = "SELECT * FROM tbl_Customer";
            SqlDataAdapter da = new SqlDataAdapter(selectDB, ConnectionDB.Connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgvCusView.DataSource = bs;
            da.Update(dt);
        }
        private void ucViewCustomer_Load(object sender, EventArgs e)
        {
            loadData();
            dgvCustomer = dgvCusView;
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Name.Text != null)
            {
                string selectCusUN = "SELECT * FROM tbl_Customer";
                SqlDataAdapter da = new SqlDataAdapter(selectCusUN, ConnectionDB.Connection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dgvCusView.DataSource = bs;
                da.Update(dt);

                DataView dv = new DataView(dt);
                dv.RowFilter = "name LIKE '%" + txt_Name.Text + "%'";
                dgvCusView.DataSource = dv;
            }
        }

        private void txt_Tel_TextChanged(object sender, EventArgs e)
        {
            if (txt_Tel.Text != "" && txt_Tel.Text != null)
            {
                string selectCusTel = "SELECT * FROM tbl_Customer WHERE tel='"+int.Parse(txt_Tel.Text)+"'";
                SqlDataAdapter da = new SqlDataAdapter(selectCusTel, ConnectionDB.Connection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dgvCusView.DataSource = bs;
                da.Update(dt);
            }
        }

        private void txt_NIC_TextChanged(object sender, EventArgs e)
        {
            if (txt_NIC.Text != "" && txt_NIC.Text != null)
            {
                string selectCusTel = "SELECT * FROM tbl_Customer WHERE nic='" + int.Parse(txt_NIC.Text) + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectCusTel, ConnectionDB.Connection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dgvCusView.DataSource = bs;
                da.Update(dt);
            }
        }

        private void txt_CusNo_TextChanged(object sender, EventArgs e)
        {
            if (txt_CusNo.Text != "" && txt_CusNo.Text != null)
            {
                string selectCusTel = "SELECT * FROM tbl_Customer WHERE cusNo='" + int.Parse(txt_CusNo.Text) + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectCusTel, ConnectionDB.Connection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dgvCusView.DataSource = bs;
                da.Update(dt);
            }
        }

        private void txt_Name_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Name.Clear();
            txt_Tel.Clear();
            txt_NIC.Clear();
            txt_CusNo.Clear();
            loadData();
        }

        private void txt_Tel_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Tel.Clear();
            txt_Name.Clear();
            txt_NIC.Clear();
            txt_CusNo.Clear();
            loadData();
        }

        private void txt_NIC_MouseClick(object sender, MouseEventArgs e)
        {
            txt_NIC.Clear();
            txt_Name.Clear();
            txt_Tel.Clear();
            txt_CusNo.Clear();
            loadData();
        }

        private void txt_CusNo_MouseClick(object sender, MouseEventArgs e)
        {
            txt_CusNo.Clear();
            txt_Name.Clear();
            txt_Tel.Clear();
            txt_NIC.Clear();
            loadData();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            frm_EditCusDetails fcusUp = new frm_EditCusDetails(int.Parse(dgvCusView.CurrentRow.Cells["cusNo"].Value.ToString()), DateTime.Parse(dgvCusView.CurrentRow.Cells["date"].Value.ToString()), dgvCusView.CurrentRow.Cells["name"].Value.ToString(), dgvCusView.CurrentRow.Cells["addressLine1"].Value.ToString(), dgvCusView.CurrentRow.Cells["addressLine2"].Value.ToString(), dgvCusView.CurrentRow.Cells["city"].Value.ToString(), int.Parse(dgvCusView.CurrentRow.Cells["nic"].Value.ToString()), int.Parse(dgvCusView.CurrentRow.Cells["passport"].Value.ToString()), int.Parse(dgvCusView.CurrentRow.Cells["tel"].Value.ToString()), dgvCusView.CurrentRow.Cells["officerID"].Value.ToString(), float.Parse(dgvCusView.CurrentRow.Cells["Pay"].Value.ToString()));
            fcusUp.ShowDialog();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            frm_ViewCustomer frmVC = new frm_ViewCustomer(int.Parse(dgvCusView.CurrentRow.Cells["cusNo"].Value.ToString()), DateTime.Parse(dgvCusView.CurrentRow.Cells["date"].Value.ToString()), dgvCusView.CurrentRow.Cells["name"].Value.ToString(), dgvCusView.CurrentRow.Cells["addressLine1"].Value.ToString(), dgvCusView.CurrentRow.Cells["addressLine2"].Value.ToString(), dgvCusView.CurrentRow.Cells["city"].Value.ToString(), int.Parse(dgvCusView.CurrentRow.Cells["nic"].Value.ToString()), int.Parse(dgvCusView.CurrentRow.Cells["passport"].Value.ToString()), int.Parse(dgvCusView.CurrentRow.Cells["tel"].Value.ToString()), dgvCusView.CurrentRow.Cells["officerID"].Value.ToString(), float.Parse(dgvCusView.CurrentRow.Cells["Pay"].Value.ToString()));
            frmVC.ShowDialog();
        }
    }
}
