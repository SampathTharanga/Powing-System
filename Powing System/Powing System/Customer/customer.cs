using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Powing_System
{
    public class customer
    {
        public void addCustomer(int cn,DateTime date, string name,string add1,string add2,string city,int nic,int pass,int tel,string offId,float pay)
        {
            // string addCus = @"INSERT INTO tbl_Customer VALUES cusNo='" + cn + "',date='" + date + "',name='" + name + "',addressLine1='" + add1 + "',addressLine2='" + add2 + "',city='" + city + "',nic='" + nic + "',passport='" + pass + "',tel='" + tel + "',officerID='" + offId + "'";
            //string addCus = @"INSERT INTO tbl_Customer(cusNo,officerID) VALUES ('" + cn + "','" + offId + "')";


            string addCus = @"INSERT INTO tbl_Customer VALUES ('" + cn + "','" + date + "','" + name + "','" + add1 + "','" + add2 + "','" + city + "','" + nic + "','" + pass + "','" + tel + "','" + offId + "','" + pay + "')";
            SqlCommand cmd = new SqlCommand(addCus, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }


        public void updateCustomer(int jn,string JeweTy,float weight,float pay,int cuNo,int caratNo,int rteNo)
        {
            string updateQuery = "UPDATE tbl_tempJewellery SET typeOfJeweller='" + JeweTy + "',weight='" + weight + "',paying='" + pay + "',cusNo='" + cuNo + "',caratNo='" + caratNo + "',RateNo='" + rteNo + "' WHERE jewelleryNo='" + jn + "'";
            SqlCommand cmd = new SqlCommand(updateQuery, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }

        //Auto assign Cutomer Number method
        public int autoAssignCusNo()
        {
            int cNo = 0;
            string selectCusNo = "SELECT MAX(cusNo) FROM tbl_Customer";
            SqlCommand com = new SqlCommand(selectCusNo, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)
            {
                string cn = dr[0].ToString();
                bool result = int.TryParse(cn, out cNo);
                if (result == false)
                    cNo = 1000;
                else
                    cNo += 1;
            }
            return cNo;
        }

        //Auto Assign Jewellery table jewellery Number
        public int autoAssignJewNo()
        {
            int jNo = 0;
            string selectJewNo = "SELECT MAX(jewelleryNo) FROM tbl_Jewellery";
            SqlCommand cmd = new SqlCommand(selectJewNo, ConnectionDB.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                string jn = dr[0].ToString();
                bool result = int.TryParse(jn, out jNo);
                if (result == false)
                    jNo = 1000;
                else
                    jNo += 1;
            }
            return jNo;
        }

        //Add jewellery customer list tempary jewellery table 
        public void TempAddCusJewellery(int jn, string type, float we, float pay, int cusNo,int caratNo, int RateNo)
        {
            string tempJewell = "INSERT INTO tbl_tempJewellery VALUES ('" + jn + "','" + type + "','" + we + "','" + pay + "','" + cusNo + "','" + caratNo + "','" + RateNo + "')";
            SqlCommand cmd = new SqlCommand(tempJewell, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }

        public void UpdateCusQry(string name,string add1,string add2,string city,int nic,int pass,int tel,float pay,int cusNo)
        {
            string updateQuery = "UPDATE tbl_Customer SET name='" + name + "',addressLine1='" + add1 + "',addressLine2='" + add2 + "',city='" + city + "',nic='" + nic + "',passport='" + pass + "',tel='" + tel + "',Pay='" + pay + "' WHERE cusNo='" + cusNo + "'";
            SqlCommand cmd = new SqlCommand(updateQuery, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }

        public DataSet selectCus()
        {
            DataSet ds = new DataSet();
            string selectQu = "SELECT * FROM tbl_Customer";
            SqlDataAdapter da = new SqlDataAdapter(selectQu, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Customer");
            return ds;
        }

    }
}