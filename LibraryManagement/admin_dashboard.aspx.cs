using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class admin_deshboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["userType"] == "admin")
            {
                Label1.Text = (string)Session["userName"];
            }
            else if ((String)Session["userType"] == "Student")
            {
                Response.Redirect("user_dashboard.aspx");
            }
            else
            {
                Response.Redirect("WebForm.aspx");
            }
            
        }

        protected void ImageButtonSearch_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/book_search.aspx");
        }

        protected void ImageButtonUserList_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/UserList.aspx");
        }

        protected void ImageButtonAllBooks_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/admin_book_list_view.aspx");
        }

        protected void ImageButtonBookEntry_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/book_entry.aspx");
        }

        protected void ImageButtonIssuedView_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("all_issued_book.aspx");
        }

       

        protected void ImageButtonProfile_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("profile.aspx");
        }

       
        
    }
}