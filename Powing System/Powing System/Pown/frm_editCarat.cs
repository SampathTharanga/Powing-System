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
    public partial class frm_editCarat : Form
    {
        carat ObjCarat = new carat();

        private int crtNum;

        public frm_editCarat(string c, string p, int cn)
        {
            InitializeComponent();

            txt_caratType.Text = c;
            txt_price1Carat.Text = p;
            crtNum = cn;
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try {
                ObjCarat.updateCarat(int.Parse(txt_caratType.Text), float.Parse(txt_price1Carat.Text), crtNum);
                MessageBox.Show("Update complete!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataSet ds = ObjCarat.selectData();
                ucPowingDetails.dtagvCa.DataSource = ds.Tables["tbl_Carat"];

                txt_caratType.Clear();
                txt_price1Carat.Clear();

                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
