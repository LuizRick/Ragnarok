using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RagnarokWeb
{
    public partial class ServerError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string err = Server.GetLastError().ToString();
            serverError.Text = err;
        }
    }
}