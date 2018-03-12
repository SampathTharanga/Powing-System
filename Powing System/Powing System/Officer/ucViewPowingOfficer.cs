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
    public partial class ucViewPowingOfficer : UserControl
    {
        Officer ObjOfficer = new Officer();

        //ucViewPowingOfficer open main form for create method and object
        private static ucViewPowingOfficer ViewpowingOff_instance;
        public static ucViewPowingOfficer ViewpowingOffOpen
        {
            get
            {
                ViewpowingOff_instance = null;

                if (ViewpowingOff_instance == null)
                    ViewpowingOff_instance = new ucViewPowingOfficer();
                return ViewpowingOff_instance;
            }
        }

        public ucViewPowingOfficer()
        {
            InitializeComponent();
        }

        private void ucViewPowingOfficer_Load(object sender, EventArgs e)
        {
            //DataSet ds = ObjOfficer.viewOfficer();
            //dgv_ViewOfficer.DataSource = ds.Tables["tbl_Officer"];


            string selectDB = "SELECT * FROM tbl_Officer";
            SqlDataAdapter da = new SqlDataAdapter(selectDB, ConnectionDB.Connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgv_ViewOfficer.DataSource = bs;
            da.Update(dt);
        }

        private void txt_searchOffi_TextChanged(object sender, EventArgs e)
        {
            string selectDB = "SELECT * FROM tbl_Officer";
            SqlDataAdapter da = new SqlDataAdapter(selectDB, ConnectionDB.Connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgv_ViewOfficer.DataSource = bs;
            da.Update(dt);

            DataView dv = new DataView(dt);
            dv.RowFilter = "officerID LIKE '%" + txt_searchOffi.Text + "%'";
            dgv_ViewOfficer.DataSource = dv;
        }
    }
}
