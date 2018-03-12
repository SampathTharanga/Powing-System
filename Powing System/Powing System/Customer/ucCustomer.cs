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
using System.Text.RegularExpressions;

namespace Powing_System
{
    public partial class ucCustomer : UserControl
    {
        customer CusObj = new customer();
        Insterest obj = new Insterest();
        Regex reg_NIC = new Regex(@"^[\d]{9}[v]$");


        float jewelPr = 0.0f;
        int max, rteN = 0;
        int jNo = 0;

        //ucControl open main form for create method and object
        private static ucCustomer Cus_instance;

        public static ucCustomer cusOpen
        {
            get
            {
                Cus_instance = null;

                if (Cus_instance == null)
                    Cus_instance = new ucCustomer();
                return Cus_instance;
            }
        }

        public ucCustomer()
        {
            InitializeComponent();
        }




        private void ucCustomer_Load(object sender, EventArgs e)
        {
            
            //user id
            lbl_UserId.Text = frm_Login.uid;

            //Current Date display
            lbl_Date.Text = DateTime.Now.ToShortDateString();

            //Auto assign Cutomer Number
            lbl_CusNo.Text = (CusObj.autoAssignCusNo()).ToString();

            //Auto assign Jewellery Number
            jNo = CusObj.autoAssignJewNo();
            lbl_JeweNo.Text = jNo.ToString();

            //loading jewellery datagridview
            loadingData();

            //load interest rate for label
            
            lbl_inerestRate.Text = selectRate().ToString();

            //load jewellery type for combobox
            string selectData = "SELECT typeOfJeweller FROM tbl_JewelleryType";
            SqlDataAdapter da = new SqlDataAdapter(selectData, ConnectionDB.Connection());
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbx_Type.Items.Add("--Select--");
            foreach(DataRow row in dt.Rows)
            {
                cbx_Type.Items.Add(row["typeOfJeweller"]);
            }
            cbx_Type.SelectedIndex = 0;

            //load carat for combobox
            string selectCarat = "SELECT DISTINCT caratType FROM tbl_Carat";
            SqlDataAdapter daCarat = new SqlDataAdapter(selectCarat, ConnectionDB.Connection());
            DataTable dtCarat = new DataTable();
            daCarat.Fill(dtCarat);

            cbx_Carat.Items.Add("--Select--");
            foreach(DataRow row in dtCarat.Rows)
            {
                cbx_Carat.Items.Add(row["caratType"]);
            }
            cbx_Carat.SelectedIndex = 0;

        }


        //calculater one by one jewellery prices
        float totAmount = 0.0f;
        public void eachJewePayCal()
        {
            try
            {
                float weight = 0.0f, price = 0.0f;
                int caratType = 0, val = 0;
                max = 0;
                //get jewellery weight
                weight = float.Parse(txt_Weight.Text);

                //get jewellery 1 carat for price
                caratType = int.Parse(cbx_Carat.Text);

                //select max caratno and your carat type
                string selectCarat = "SELECT caratNo FROM tbl_Carat WHERE caratType='" + int.Parse(cbx_Carat.Text) + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectCarat, ConnectionDB.Connection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {

                    val = int.Parse(dt.Rows[i]["caratNo"].ToString());
                    if (val > max)
                    {
                        max = val;
                    }
                }

                //Select current select carat price
                string selectPrice = "SELECT priceOf1Carat FROM tbl_Carat WHERE caratNo='" + max + "'";
                SqlCommand cmd1 = new SqlCommand(selectPrice, ConnectionDB.Connection());
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read() == true)
                {
                    price = float.Parse(dr1["priceOf1Carat"].ToString());
                }


                //calculate price for 1 jewellery 
                jewelPr = price * weight;

                //Rate no get
                rteN = obj.maxInsNo();


                //total amount for display data
                totAmount += jewelPr;
                lbl_amount.Text = totAmount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Loading datagridview for table data
        public void loadingData()
        {
            //string selectQuery = "SELECT jewelleryNo,typeOfJeweller,weight,paying,cusNo FROM tbl_tempJewellery";
            string selectQuery = @"SELECT tbl_tempJewellery.jewelleryNo,tbl_tempJewellery.typeOfJeweller,tbl_tempJewellery.weight,tbl_tempJewellery.paying,tbl_tempJewellery.cusNo,tbl_tempJewellery.RateNo,tbl_Carat.caratType FROM tbl_tempJewellery INNER JOIN tbl_Carat ON tbl_tempJewellery.caratNo=tbl_Carat.caratNo";
            SqlDataAdapter da = new SqlDataAdapter(selectQuery, ConnectionDB.Connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgv_customerAdd.DataSource = bs;
            da.Update(dt);
        }

        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try {
                if ((txt_Name.Text != "" && txt_Name.Text != null) && (txt_AddLine1.Text != "" && txt_AddLine1.Text != null) && (txt_City.Text != "" && txt_City.Text != null) && (txt_NIC.Text != "" && txt_NIC.Text != null))
                {
                    if (txt_Weight.Text != "" && txt_Weight.Text != null && cbx_Carat.SelectedIndex != 0 && cbx_Type.SelectedIndex != 0)
                    {
                        
                        //calculater one by one jewellery prices
                        eachJewePayCal();

                        //Add customer jewellerys list
                        CusObj.TempAddCusJewellery(int.Parse(lbl_JeweNo.Text), cbx_Type.Text, float.Parse(txt_Weight.Text), jewelPr, int.Parse(lbl_CusNo.Text), max, rteN);

                        //Loading datagridview for table data
                        loadingData();

                        //Auto assign Jewellery Number
                        //lbl_JeweNo.Text = CusObj.autoAssignJewNo().ToString();
                        //jNo = CusObj.autoAssignJewNo();
                        jNo++;
                        lbl_JeweNo.Text = jNo.ToString();

                        cbx_Carat.SelectedIndex = 0;
                        cbx_Type.SelectedIndex = 0;
                        txt_Weight.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please enter Correct details!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbx_Carat.SelectedIndex = 0;
                        cbx_Type.SelectedIndex = 0;
                        txt_Weight.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill customer details first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbx_Carat.SelectedIndex = 0;
                    cbx_Type.SelectedIndex = 0;
                    txt_Weight.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }


        //show interest rate method
        public float selectRate()
        {
            float rt = 0.0f;
            string selectQ = "SELECT Rate FROM tbl_interest WHERE RateNo='" + obj.maxInsNo() + "'";
            SqlCommand cmd = new SqlCommand(selectQ, ConnectionDB.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                rt = float.Parse(dr["Rate"].ToString());
            }
            return rt;
        }
        private void dgv_customerAdd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //total amount changing calculate
                int jno, cno, caratNo = 0, val = 0, rate = 0;
                string jType;
                float wg = 0.0f, pay = 0.0f;


                for (int i = 0; i < dgv_customerAdd.Rows.Count - 1; i++)
                {
                    jno = int.Parse(dgv_customerAdd.Rows[i].Cells["jewelleryNo"].Value.ToString());
                    jType = dgv_customerAdd.Rows[i].Cells["typeOfJeweller"].Value.ToString();
                    wg = float.Parse(dgv_customerAdd.Rows[i].Cells["weight"].Value.ToString());
                    pay = float.Parse(dgv_customerAdd.Rows[i].Cells["paying"].Value.ToString());
                    cno = int.Parse(dgv_customerAdd.Rows[i].Cells["cusNo"].Value.ToString());

                    //select caratno | your carat type
                    string selectC = "SELECT caratNo FROM tbl_Carat WHERE caratType='" + int.Parse(dgv_customerAdd.Rows[i].Cells["caratType"].Value.ToString()) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(selectC, ConnectionDB.Connection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int y = 0; y <= dt.Rows.Count - 1; y++)
                    {

                        val = int.Parse(dt.Rows[y]["caratNo"].ToString());
                        if (val > caratNo)
                        {
                            caratNo = val;
                        }
                    }

                    rate = int.Parse(dgv_customerAdd.Rows[i].Cells["RateNo"].Value.ToString());



                    CusObj.updateCustomer(jno, jType, wg, pay, cno, caratNo, rate);

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }

}

        float paying = 0.0f;
        private void txt_Paying_TextChanged(object sender, EventArgs e)
        {
            //auto calculate
            if (txt_Paying.Text != "" && txt_Paying.Text != null && txt_Paying.Text != "0.0")
            {
                paying = float.Parse(txt_Paying.Text);
                float saving = totAmount - paying;
                lbl_saving.Text = saving.ToString();
            }
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar!=8)
            {
                toolTip_Name.Show("Please enter character and number!", txt_Name, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_AddLine1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_Address1.Show("Please enter character and number!", txt_AddLine1, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_AddLine2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_address2.Show("Please enter character and number!", txt_AddLine2, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_city.Show("Please enter character and number!", txt_City, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_tel.Show("Plase enter 10 Number !", txt_Tel, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_NIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_NIC.Show("Plase enter Number and Caractor!", txt_NIC, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_Passport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                toolTip_pasport.Show("Please enter numbers!", txt_Passport, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                toolTip_weight.Show("Plase enter floating point number!", txt_Weight, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void dgv_customerAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try {
                //Insert data for customer data
                if ((txt_Name.Text != "" && txt_Name.Text != null) && (txt_AddLine1.Text != "" && txt_AddLine1.Text != null) && (txt_City.Text != "" && txt_City.Text != null) && (txt_NIC.Text != "" && txt_NIC.Text != null))
                {
                    //if (reg_NIC.IsMatch(txt_NIC.Text))
                    //{
                        CusObj.addCustomer(int.Parse(lbl_CusNo.Text), Convert.ToDateTime(lbl_Date.Text), txt_Name.Text, txt_AddLine1.Text, txt_AddLine2.Text, txt_City.Text, int.Parse(txt_NIC.Text), int.Parse(txt_Passport.Text), int.Parse(txt_Tel.Text), lbl_UserId.Text, float.Parse(txt_Paying.Text));
                        MessageBox.Show("OK");
                    //    }
                    //    else { MessageBox.Show("Please enter valide NIC!", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }


                //pown jewellery details add
                string copyData = "INSERT INTO tbl_Jewellery SELECT * FROM tbl_tempJewellery";
                SqlCommand cmdCopy = new SqlCommand(copyData, ConnectionDB.Connection());
                cmdCopy.ExecuteNonQuery();




                //clear temp jewellery table all data
                jewAllDtaDel();

                //Loading datagridview for table data
                loadingData();

                //Auto assign Cutomer Number
                lbl_CusNo.Text = (CusObj.autoAssignCusNo()).ToString();


                //clear all textbox
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                };
                func(Controls);

                // clear combobox
                cbx_Carat.SelectedIndex = 0;
                cbx_Type.SelectedIndex = 0;


                //clear label
                lbl_amount.Text = "";

            }catch(Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //clear all data tempory jewelery data
        public void jewAllDtaDel()
        {
            string sqlTruncJewe = "TRUNCATE TABLE " + "tbl_tempJewellery";
            SqlCommand cmdB = new SqlCommand(sqlTruncJewe, ConnectionDB.Connection());
            cmdB.ExecuteNonQuery();
        }

        private void txt_Paying_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Paying.Clear();
        }

        private void txt_Paying_MouseLeave(object sender, EventArgs e)
        {
            if(txt_Paying.Text==null && txt_Paying.Text=="")
                txt_Paying.Text = "0.0";
        }

        private void txt_Paying_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                toolTip_Paying.Show("Plase enter floating point number!", txt_Paying, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Reset?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //clear tbl_tempJewellery all data
                jewAllDtaDel();


                //clear all textbox
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                };
                func(Controls);

           

                //clear combobox
                cbx_Carat.SelectedIndex = 0;
                cbx_Type.SelectedIndex = 0;

                //Loading datagridview for table data
                loadingData();

                //clear label
                lbl_amount.Text = "";

                if (txt_Paying.Text == null && txt_Paying.Text == "")
                    txt_Paying.Text = "0.0";
            }
        }
    }
}
