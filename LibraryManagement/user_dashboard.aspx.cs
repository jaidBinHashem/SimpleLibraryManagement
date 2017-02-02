using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class user_dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["userType"] == "admin")
            {
                Response.Redirect("admin_dashboard.aspx");
            }
            else if ((String)Session["userType"] == "Student")
            {
                Label1.Text = (string)Session["userName"];
            }
            else
            {
                Response.Redirect("WebForm.aspx");
            }
        }

        protected void ImageButtonSearch_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/user_book_search.aspx");
        }

        protected void ImageButtonMyIssuedBook_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/my_issued_book.aspx");
        }

        protected void ImageButtonAllBook_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("user_book_list_view.aspx");
        }

        protected void ImageButtonProfile_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("profile.aspx");
        }

      
    }
}