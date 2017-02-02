using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class user_registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

  

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            lab_password.Text = txt_password.Text;
            lab_password.Visible = false;
            lab_designation.Visible = false;

      
            //string connStr = "Data Source=ASUS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = "INSERT INTO User_info VALUES ('" + txt_id.Text + "','" + txt_first_name.Text + txt_last_name.Text + "','" + txt_email.Text + "','" + radiobtn_gender.Text + "','" + txt_address.Text + "','" + lab_password.Text + "','" + lab_designation.Text + "','" + DateTime.Now.ToString("dd-MM-yyyy") + "')";
            
            SqlCommand cmd = new SqlCommand(sql, conn);
            

            SqlDataReader reader = cmd.ExecuteReader();
          
            conn.Close();
            conn.Open();
            string sqlpass = "INSERT INTO Password_info VALUES ('" + txt_id.Text + "','" + txt_first_name.Text + "','" + lab_password.Text + "','" + lab_designation.Text + "')";

            SqlCommand cmd1 = new SqlCommand(sqlpass, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            conn.Close();

            Response.Redirect("~/WebForm.aspx");
        }

        private void Redirect(string p)
        {
            throw new NotImplementedException();
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm.aspx");
        }

    }
}