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
    public partial class Cadastro : System.Web.UI.Page
    {
        string dbPath = @"C:\ragnarokdb\usuarios.mdb";
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
            "insert into usuario (username, email, senha) values ('" + username.Text + "', '" + email.Text + "','" + senha.Text + "')";
            cmd.CommandType = CommandType.Text;
            conn.Close();
            conn.Open();
            cmd.ExecuteScalar();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Cadastro realizado com sucesso')</script>");
            Response.Redirect("/");
            conn.Close();
            conn.Dispose();
        }
    }
}