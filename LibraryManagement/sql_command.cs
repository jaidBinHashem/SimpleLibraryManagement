using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagement
{
    public class sql_command
    {

        private void add_book() {
            string connStr = @"server = SHAHRIAR\SQLEXPRESS; database=LibraryManagementSystem; Integrated Security=SSPI ";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
           // string sqlpass = "INSERT INTO Password_info VALUES ('" + txt_id.Text + "','" + txt_first_name.Text + "','" + lab_password.Text + "','" + lab_designation.Text + "')";

            //SqlCommand cmd1 = new SqlCommand(sqlpass, conn);
            //SqlDataReader reader1 = cmd1.ExecuteReader();
            conn.Close();
        }
    }
}