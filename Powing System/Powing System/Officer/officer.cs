using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Powing_System
{
    public class Officer
    {

        public void updateOfficer(string pass,string id)
        {
            string updateUser = "UPDATE tbl_Officer SET password='" + pass + "' WHERE officerID='" + id + "'";
            SqlCommand cmd = new SqlCommand(updateUser, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }

        public void deleteOfficer()
        {
            
        }

        public void addOfficer(string tDay,string offId,string passw)
        {
            string insertQuery = @"INSERT INTO tbl_Officer VALUES ('" + tDay + "','" + offId + "','" + passw + "')";
            SqlCommand cmd = new SqlCommand(insertQuery, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader selectUser(string uid)
        {
            string uidQuery = "SELECT password FROM tbl_Officer WHERE officerID='" + uid + "'";
            SqlCommand cmd = new SqlCommand(uidQuery, ConnectionDB.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public DataSet selectData()
        {
            DataSet ds = new DataSet();
            string selectQu = "SELECT * FROM tbl_Officer";
            SqlDataAdapter da = new SqlDataAdapter(selectQu, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Officer");
            return ds;
        }
    }
}