using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RagnarokWeb.Codes;
namespace RagnarokWeb
{
    public partial class PortalMasterPage : System.Web.UI.MasterPage
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
                loginform.Visible = false;  
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            
            DataBase db = new DataBase();
            string sql = string.Format("SELECT Codigo,Email,Login,Nome FROM Usuario WHERE Email = '{0}' AND Senha = '{1}'", email_login.Text, senha_login.Text);
            IDataReader dr = (IDataReader) db.ReturnQuery(sql);
            if(dr.Read())
            {
                int email = dr.GetOrdinal("Email");
                int nome = dr.GetOrdinal("Nome");
                int cod = dr.GetOrdinal("Codigo");
                auth.SaveSession("login", dr.GetString(email));
                if (!dr.IsDBNull(nome))
                {
                    auth.SaveSession("nome", dr.GetString(nome));       //salva na seção o nome de ususario
                }else
                {
                    auth.SaveSession("nome", "anonimo");            //salva na seção usuario sem nome
                }
                auth.SaveSession("id", dr.GetInt32(cod).ToString());        //salva na seção o id do usuario para futuras consultas
            }
            dr.Close();
            dr.Dispose();
            db.close();
            Response.Redirect("/Portal/");
        }

        protected void btn_sair_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();    //remove todas as chaves da sessão
            Response.Redirect("/Portal/");  //redireciona para home
        }
    }
}