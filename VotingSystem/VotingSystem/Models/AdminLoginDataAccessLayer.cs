using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace VotingSystem.Models
{
    public class AdminLoginDataAccessLayer
    {
        public SqlConnection con;
        public void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);
        }
        public bool AdminLogin(AdminLoginModel al)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AdminLogin", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AEmail", al.AEmail);
            cmd.Parameters.AddWithValue("@APassword", al.APassward);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}