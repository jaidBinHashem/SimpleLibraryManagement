using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class book_search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Under construction");
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BookListView.aspx");
        }

      
    }
}