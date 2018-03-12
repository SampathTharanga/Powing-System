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
    public partial class frm_TypeOfJewellery : Form
    {
        Jewellery ObjJew = new Jewellery();
        string oldVal, selectU;
        public static  DataGridView dgv;

        public frm_TypeOfJewellery()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void loadData()
        {
            string selectType = "SELECT * FROM tbl_JewelleryType";
            SqlDataAdapter da = new SqlDataAdapter(selectType, ConnectionDB.Connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            da.Update(dt);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_JewelleryType.Text!="" && txt_JewelleryType.Text!=null)
            {
                ObjJew.insertJewType(txt_JewelleryType.Text);
                MessageBox.Show("Added Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                txt_JewelleryType.Clear();
            }
        }

        private void frm_TypeOfJewellery_Load(object sender, EventArgs e)
        {
            dgv = dataGridView1;
            loadData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            frm_jewelleryTypeUp frmedit = new frm_jewelleryTypeUp(dataGridView1.CurrentRow.Cells["typeOfJeweller"].Value.ToString());
            frmedit.ShowDialog();
        }
    }
}
