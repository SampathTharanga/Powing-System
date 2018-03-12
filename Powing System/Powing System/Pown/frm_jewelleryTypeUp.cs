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
    public partial class frm_jewelleryTypeUp : Form
    {
        string jewT;
        Jewellery ObjJew = new Jewellery();
        public frm_jewelleryTypeUp(string jt)
        {
            InitializeComponent();
            jewT = jt;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ObjJew.updateJewType(txt_jewelleryName.Text, jewT);
            MessageBox.Show("Update Complete!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataSet ds = ObjJew.loadDgvData();
            frm_TypeOfJewellery.dgv.DataSource = ds.Tables["tbl_JewelleryType"];

            this.Close();
        }

        private void frm_jewelleryTypeUp_Load(object sender, EventArgs e)
        {
            txt_jewelleryName.Text = jewT;
        }
    }
}
