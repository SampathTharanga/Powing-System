using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Powing_System
{
    public class Jewellery
    {
        private int jewelleryNo;
        private int typeOfJewellery;
        private int typeOfCarrot;
        private int weight;

        public void addJewellwery()
        {
            //throw new System.NotImplementedException();
        }

        public void updateJewellery()
        {
           // throw new System.NotImplementedException();
        }

        public void deleteJewellery()
        {
            //throw new System.NotImplementedException();
        }


        public void insertJewType(string jt)
        {
            string addJewType = "INSERT INTO tbl_JewelleryType VALUES ('" + jt + "')";
            SqlCommand cmd = new SqlCommand(addJewType, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }

        public void updateJewType(string jty, string updateJt)
        {
            string UpdateJeType = "UPDATE tbl_JewelleryType SET typeOfJeweller='" + jty + "' WHERE typeOfJeweller='" + updateJt + "'";
            SqlCommand cmd = new SqlCommand(UpdateJeType, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }

        public DataSet loadDgvData()
        {
            DataSet ds = new DataSet();
            string selectQu = "SELECT * FROM tbl_JewelleryType";
            SqlDataAdapter da = new SqlDataAdapter(selectQu, ConnectionDB.Connection());
            da.Fill(ds, "tbl_JewelleryType");
            return ds;
        }
    }
}