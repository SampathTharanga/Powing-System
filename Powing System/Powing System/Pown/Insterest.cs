using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Powing_System
{
    public class Insterest
    {
        private int insterestNo;
        private int Rate;

        public void addInsterest(int no,float rte)
        {
            string insertRate = @"INSERT INTO tbl_interest VALUES ('" + no + "','" + rte + "')";
            SqlCommand cmd = new SqlCommand(insertRate, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }

        public void updateOnsterest(float rt,int ino)
        {
            string updateQuery = "UPDATE tbl_interest SET Rate='" + rt + "' WHERE RateNo='" + ino + "'";
            SqlCommand cmd = new SqlCommand(updateQuery, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }

        //Auto asssign number for interest Rate
        public int autoNointerest()
        {
            int RN=0;
            string selectIRateNo = "SELECT MAX(RateNo) FROM tbl_interest";
            SqlCommand cmd = new SqlCommand(selectIRateNo, ConnectionDB.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read()==true)
            {
                string val = dr[0].ToString();
                bool result = int.TryParse(val, out RN);
                if (result == false)
                    RN = 1;
                else
                    RN += 1;
            }
            return RN;
        }

        //maximum interest number selected
        public int maxInsNo()
        {
            int max, newVal = 0;
            string maxNo = "SELECT MAX(RateNo) FROM tbl_interest";
            SqlCommand cmd = new SqlCommand(maxNo, ConnectionDB.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                string val = dr[0].ToString();
                bool result = int.TryParse(val, out max);
                if (result == true)
                    newVal = max;

            }
            return newVal;
        }

        public DataSet selectInData()
        {
            DataSet ds = new DataSet();
            string selectQu = "SELECT * FROM tbl_interest";
            SqlDataAdapter da = new SqlDataAdapter(selectQu, ConnectionDB.Connection());
            da.Fill(ds, "tbl_interest");
            return ds;
        }
        
    }
}