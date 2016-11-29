using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.OleDb;
using System.Web.UI.WebControls;
using System.Data;

namespace RagnarokWeb
{
    public partial class PortalCadastro : System.Web.UI.Page
    {
        string dbPath = @"C:\ragnarokdb\BancoPortal.mdb";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0;data source=" + dbPath;
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText =
            "insert into usuario (login, senha, email,nome) values ('" + username.Text + "', '" + senha.Text + "','" + email.Text + "' , '" + usernamecp.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Cadastro realizado com sucesso')</script>");
            Response.Redirect("/Portal/");
            conn.Close();
            conn.Dispose();
        }
    }
}