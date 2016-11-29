using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using RagnarokWeb.Codes;
using System.Web.Services;
using Domain;
namespace RagnarokWeb.Admin
{
    public partial class CadastroJogos : System.Web.UI.Page
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
            "insert into Jogo (Nome, Site, Descricao) values ('" + txtNomeJogo.Text + "','" + txtSiteJogo.Text + "','" + txtDescricaoJogo.Text  + "')"; // select dos campos do formulario
            cmd.CommandType = CommandType.Text;
            conn.Close();
            conn.Open();
            cmd.ExecuteScalar();
            Response.Write("<script LANGUAGE='JavaScript'>alert('Cadastro realizado com sucesso')</script>"); // mensagem 
            txtNomeJogo.Text = "";              //Limpando campos
            txtSiteJogo.Text = "";
            txtDescricaoJogo.Text = "";
            conn.Close();
            conn.Dispose();
        }
    }
}