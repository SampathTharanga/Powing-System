using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Powing_System
{
   

    public partial class frm_EditCusDetails : Form
    {

        customer objCus = new customer();
        string name, add1, add2, city, offID;
        int cn, nic, passport, tel;
        DateTime date;
        float pay;

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if((txt_Name.Text!="" && txt_Name.Text!=null) && (txt_NIC.Text!="" && txt_NIC.Text!=null) && (txt_City.Text!="" && txt_City.Text!=null) && (txt_Add1.Text!="" && txt_Add1.Text!=null) && (txt_Paying.Text!="" && txt_Paying.Text!=null))
            {
                float tot = 0.0f;
                string checkPay = "SELECT paying FROM tbl_Jewellery WHERE cusNo='" + int.Parse(txt_CusNo.Text) + "'";
                SqlDataAdapter da = new SqlDataAdapter(checkPay, ConnectionDB.Connection());
                DataTable dt = new DataTable();
                da.Fill(dt);

                for(int x=0;x<dt.Rows.Count;x++)
                {
                    tot += float.Parse(dt.Rows[x]["paying"].ToString());
                }
                if (float.Parse(txt_Paying.Text) < tot)
                {
                    objCus.UpdateCusQry(txt_Name.Text, txt_Add1.Text, txt_Add2.Text, txt_City.Text, int.Parse(txt_NIC.Text), int.Parse(txt_Passport.Text), int.Parse(txt_Tel.Text), float.Parse(txt_Paying.Text), int.Parse(txt_CusNo.Text));
                    MessageBox.Show("Update complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataSet ds = objCus.selectCus();
                    ucViewCustomer.dgvCustomer.DataSource = ds.Tables["tbl_Customer"];

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Can't Paying!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Paying.Clear();
                }
            }
        }


        private void frm_EditCusDetails_Load(object sender, EventArgs e)
        {
            txt_CusNo.Text = cn.ToString();
            txt_Date.Text = date.ToShortDateString();
            txt_Name.Text = name;
            txt_Add1.Text = add1;
            txt_Add2.Text = add2;
            txt_City.Text = city;
            txt_NIC.Text = nic.ToString();
            txt_Passport.Text = passport.ToString();
            txt_Tel.Text = tel.ToString();
            txt_OfficerID.Text = offID;
            txt_Paying.Text = pay.ToString();
        }



        public frm_EditCusDetails(int cn,DateTime date,string name,string add1,string add2,string city,int nic,int passport,int tel,string offID,float pay)
        {
            InitializeComponent();
            this.cn = cn;
            this.date = date;
            this.name = name;
            this.add1 = add1;
            this.add2 = add2;
            this.city = city;
            this.nic = nic;
            this.passport = passport;
            this.tel = tel;
            this.offID = offID;
            this.pay = pay;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
