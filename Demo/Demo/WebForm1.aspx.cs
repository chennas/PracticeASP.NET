using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spInsertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramFirstName = new SqlParameter("@FirstName", txtFirstName.Text);
                SqlParameter paramLastName = new SqlParameter("@LastName", txtLastName.Text);
                SqlParameter paramEmail = new SqlParameter("@Email", txtEmail.Text);

                cmd.Parameters.Add(paramFirstName);
                cmd.Parameters.Add(paramLastName);
                cmd.Parameters.Add(paramEmail);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}