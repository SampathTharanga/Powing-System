using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Powing_System
{
    public class carat
    {
        Insterest inObj = new Insterest();

        private int caratType;
        private int caratNo;

        public void addCarat(int cType,float price1C)
        {
            int maxInterestNo = inObj.maxInsNo();
            string insertCarat = @"INSERT INTO tbl_Carat VALUES ('" + autoCaratNo() + "','" + cType + "','" + price1C + "','" + maxInterestNo + "')";
            SqlCommand cmd = new SqlCommand(insertCarat, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }

        public void updateCarat(int ctype,float priceOf1C,int cn)
        {
            string updateQuery = "UPDATE tbl_Carat SET caratType='" + ctype + "',priceOf1Carat='" + priceOf1C + "' WHERE caratNo='" + cn + "'";
            SqlCommand cmd = new SqlCommand(updateQuery, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }

        public int autoCaratNo()
        {
            int No = 0;
            string autoNum = "SELECT MAX(caratNo) FROM tbl_Carat";
            SqlCommand cmd = new SqlCommand(autoNum, ConnectionDB.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read()==true)
            {
                string val = dr[0].ToString();
                bool result = int.TryParse(val, out No);
                if (result == false)
                    No = 1;
                else
                    No += 1;
            }
            return No;
        }

        public DataSet selectData()
        {
            DataSet ds = new DataSet();
            string selectQuer = "SELECT caratNo,caratType,priceOf1Carat FROM tbl_Carat";
            SqlDataAdapter da = new SqlDataAdapter(selectQuer, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Carat");
            return ds;
        }
    }
}