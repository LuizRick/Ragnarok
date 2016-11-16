using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RagnarokWeb.Codes;
namespace RagnarokWeb
{
    public partial class AdminMasterPage : System.Web.UI.MasterPage
    {
        Autenticacao auth;
        protected void Page_Load(object sender, EventArgs e)
        {
            auth = new Autenticacao(Response, Session);
            if (auth.ExistsInSession("login"))
            {
                login_name.Text = Session["login"].ToString();
                login_usrname.Text = auth.getKey("nome");
                userlogin.Visible = true;
            }else
            {
                Response.Redirect("/Portal/PortalCadastro.aspx");
            }
        }

        protected void btn_sair_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("/Portal/");
        }
    }
}