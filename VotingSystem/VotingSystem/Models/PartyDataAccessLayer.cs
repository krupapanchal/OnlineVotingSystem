using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace VotingSystem.Models
{
    public class PartyDataAccessLayer
    {
        public SqlConnection con;
        public void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);
        }
        public bool AddParty(PartyModel v)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddParty", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Party_Name", v.Party_Name);
            cmd.Parameters.AddWithValue("@Vid", v.Vid);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
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