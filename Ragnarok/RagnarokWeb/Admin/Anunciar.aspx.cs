using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RagnarokWeb.Codes;
using System.Web.Services;
using Domain;
namespace RagnarokWeb.Admin
{
    public partial class Anunciar : System.Web.UI.Page
    {
        string dbPath = @"C:\ragnarokdb\BancoPortal.mdb";
        protected void Page_Load(object sender, EventArgs e)
        {
            Autenticacao auth = new Autenticacao(Response,Session);
            string id = auth.getKey("id");
            idsession.Value = id;
        }
        /// <summary>
        /// Botão anunciar, evento de click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonAnunciar_Click(object sender, EventArgs e)
        {
            Autenticacao auth = new Autenticacao(Response,Session);
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0;data source=" + dbPath;
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText =
            string.Format("INSERT INTO Anuncio (Nome, Tempo, Jogo,  Site, link, Descricao,fk_usuario) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}',{6})",
            TextBoxNomeAn.Text, DropDownListTempo.SelectedItem, txtNomeJogo.Text,TextBoxLinkServer.Text,
            TextBoxLinkAn.Text, TextBoxDescricao.Text, auth.getKey("id")); // select dos campos do formulario
            cmd.CommandType = CommandType.Text;
            conn.Close();
            conn.Open();
            cmd.ExecuteScalar();
            Response.Write("<script LANGUAGE='JavaScript'>alert('Cadastro realizado com sucesso')</script>"); // mensagem 
            Response.Redirect("/Admin/Anunciar.aspx");
            conn.Close();
            conn.Dispose();
        }

        [WebMethod]
        public static Object Lista_Anuncios(string id)
        {
            List<Anuncio> list = new List<Anuncio>();
            DataBase db = new DataBase();
            db.open();
            IDataReader dr = (IDataReader) db.ReturnQuery("SELECT * FROM Anuncio WHERE fk_usuario = " + id);
            //pega as colunas
            int cod = dr.GetOrdinal("Codigo");
            int nome = dr.GetOrdinal("Nome");
            int jogo = dr.GetOrdinal("Jogo");
            int tempo = dr.GetOrdinal("Tempo");
            int descricao = dr.GetOrdinal("Descricao");
            int link = dr.GetOrdinal("link");
            int site = dr.GetOrdinal("site");
            //itera pelos resultados e adiciona a lista
            while(dr.Read())
            {
                //adiciona um anuncio das linhas retornada pelo data reader
                list.Add(new Anuncio()
                {
                    codigo = dr.GetInt32(cod).ToString(),
                    nome = dr.GetString(nome),
                    jogo = dr.GetString(jogo),
                    descricao = dr.GetString(descricao),
                    link = dr.GetString(link),
                    site = dr.GetString(site),
                    tempo = dr.GetString(tempo)
                });
            }
            db.close();
            return list;
        }
    }
}