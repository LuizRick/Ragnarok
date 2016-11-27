using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RagnarokWeb.Codes;
using System.Data;
using Domain;

namespace RagnarokWeb.Admin
{
    public partial class ExcluirAnuncio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Request.QueryString["id"];
                List<Anuncio> list = new List<Anuncio>();
                DataBase db = new DataBase();
                db.open();
                IDataReader dr = (IDataReader)db.ReturnQuery("SELECT * FROM Anuncio WHERE Codigo = " + id + " AND fk_usuario = " + Session["id"]);
                //pega as colunas
                int cod = dr.GetOrdinal("Codigo");
                int nome = dr.GetOrdinal("Nome");
                int jogo = dr.GetOrdinal("Jogo");
                int tempo = dr.GetOrdinal("Tempo");
                int descricao = dr.GetOrdinal("Descricao");
                int link = dr.GetOrdinal("link");
                int site = dr.GetOrdinal("site");
                //itera pelos resultados e adiciona a lista
                while (dr.Read())
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
                dr.Close();
                db.close();
                lblNomeAnuncio.Text = list.First().nome;
                lblDescricaoAnuncio.Text = list.First().descricao;
                lbllinkSite.Text = list.First().site;
                lblLInkImagem.Text = list.First().link;
                lblNomeJogo.Text = list.First().jogo;
                lblTempoAnuncio.Text = list.First().tempo;
            }
            catch (Exception)
            {
                Response.Redirect("/Admin/");
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btnExcluirAnuncio_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.open();
            string sql = string.Format("DELETE FROM Anuncio WHERE Codigo = {0}", Request.QueryString["id"]);
            int rowsAffected = db.ExecuteCmd(sql);
            db.close();
            if (rowsAffected > 0)
            {
                Response.Redirect("/Admin/Anunciar.aspx");
            }
            else
            {
                status.Text = "Não foi possivel excluir";
            }
        }

        protected void btnCancelarExcluir_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Anunciar.aspx");
        }
    }
}