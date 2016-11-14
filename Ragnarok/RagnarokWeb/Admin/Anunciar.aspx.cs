using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RagnarokWeb.Admin
{
    public partial class Anunciar : System.Web.UI.Page
    {
        string dbPath = @"C:\ragnarokdb\BancoPortal.mdb";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fazer um select na tabela de jogos cadastrados
        }
        /// <summary>
        /// Botão anunciar, evento de click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonAnunciar_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0;data source=" + dbPath;
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText =
            "insert into Anuncio (Nome, Tempo, Jogo,  Site, link, Descricao) values ('" + TextBoxNomeAn.Text + "','" + DropDownListTempo.SelectedItem + "','"  + DropDownListJogo.SelectedItem + "','" + TextBoxLinkServer.Text + "','" + TextBoxLinkAn.Text + "','" + TextBoxDescricao.Text + "')"; // select dos campos do formulario
            cmd.CommandType = CommandType.Text;
            conn.Close();
            conn.Open();
            cmd.ExecuteScalar();
            Response.Write("<script LANGUAGE='JavaScript'>alert('Cadastro realizado com sucesso')</script>"); // mensagem 
            Response.Redirect("/");
            conn.Close();
            conn.Dispose();
        }
    }
}