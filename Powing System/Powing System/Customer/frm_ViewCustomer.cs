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
    public partial class frm_ViewCustomer : Form
    {
        customer objCus = new customer();
        string name, add1, add2, city, offID;

        SqlDataAdapter da;
        int val = 0, max = 0;
        float price = 0.0f;

        private void dgv_jewel_MouseClick(object sender, MouseEventArgs e)
        {
            string selectRate = "SELECT Rate FROM tbl_interest WHERE RateNo='" + dgv_jewel.CurrentRow.Cells["RateNo"].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(selectRate, ConnectionDB.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read() == true)
            {
                lbl_Rate.Text = dr["Rate"].ToString();
            }

            lbl_paying.Text = dgv_jewel.CurrentRow.Cells["paying"].Value.ToString();

            //calculate interest
            DateTime risiteDate = Convert.ToDateTime(lbl_Date.Text);
            lbl_risitDate.Text = lbl_Date.Text;

            DateTime currentDate = DateTime.Today;
            lbl_CurrentDate.Text = currentDate.ToShortDateString().ToString();

            TimeSpan ts = currentDate.Subtract(risiteDate);

            int numberOfDate = int.Parse(ts.Days.ToString());

            float NowInterest = 0.0f;

            if (numberOfDate <= 31)
            {
                NowInterest = (int.Parse(lbl_paying.Text) * float.Parse(lbl_Rate.Text) * 12) / 1200;
            }
            else
            {
                NowInterest = (int.Parse(lbl_paying.Text) * float.Parse(lbl_Rate.Text) * 12) / 36500;
            }
            lbl_interest.Text = NowInterest.ToString();

            float tot = NowInterest + float.Parse(dgv_jewel.CurrentRow.Cells["paying"].Value.ToString());
            lbl_Total.Text = tot.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ViewCustomer_Load(object sender, EventArgs e)
        {
            lbl_CusNO.Text = cn.ToString();
            lbl_Date.Text = date.ToShortDateString();
            lbl_Name.Text = name;
            lbl_Add1.Text = add1;
            lbl_Add2.Text = add2;
            lbl_City.Text = city;
            lbl_NIC.Text = nic.ToString();
            lbl_Passport.Text = passport.ToString();
            lbl_tel.Text = tel.ToString();
            lbl_OfficerID.Text = offID;
            //txt_Paying.Text = pay.ToString();


            //dgv_jewel.Columns[5].Name = "Carat Type";
            //dgv_jewel.Columns[5].HeaderText = "Carat Type";

            //load data for datagridview
            string selectJewel = "SELECT * FROM tbl_Jewellery WHERE cusNo='" + int.Parse(lbl_CusNO.Text) + "'";
            da = new SqlDataAdapter(selectJewel, ConnectionDB.Connection());
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            dgv_jewel.DataSource = bs;
            da.Update(dt1);

            //convert to carat number to carat type
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string selecttype = "SELECT * FROM tbl_Carat WHERE caratNo='" + int.Parse(dt1.Rows[i][5].ToString()) + "'";
                SqlCommand cmdx = new SqlCommand(selecttype, ConnectionDB.Connection());
                SqlDataReader drx = cmdx.ExecuteReader();
                while (drx.Read() == true)
                {
                    dgv_jewel.Rows[i].Cells[5].Value = drx[1].ToString();
                }

            }

            ////convert rate number to interest rate
            //for (int i = 0; i < dt1.Rows.Count; i++)
            //{
            //    string selectRate = "SELECT * FROM tbl_interest WHERE RateNo='" + int.Parse(dt1.Rows[i][6].ToString()) + "'";
            //    SqlCommand cmdy = new SqlCommand(selectRate, ConnectionDB.Connection());
            //    SqlDataReader dry = cmdy.ExecuteReader();
            //    while (dry.Read() == true)
            //    {
            //        float var= float.Parse(dry[1].ToString());
            //        MessageBox.Show(var.ToString());
            //        dgv_jewel.Rows[i].Cells[6].Value = var;
            //    }

            //}

        }

        int cn, nic, passport, tel;
        DateTime date;
        float pay;


        public frm_ViewCustomer(int cn, DateTime date, string name, string add1, string add2, string city, int nic, int passport, int tel, string offID, float pay)
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
    }
}
