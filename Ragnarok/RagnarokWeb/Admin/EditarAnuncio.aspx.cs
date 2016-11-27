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
    public partial class EditarAnuncio : System.Web.UI.Page
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
                TextBoxNomeAn.Text = list.First().nome;
                TextBoxDescricao.Text = list.First().descricao;
                TextBoxLinkServer.Text = list.First().site;
                TextBoxLinkAn.Text = list.First().link;
                txtNomeJogo.Text = list.First().jogo;

            }
            catch(Exception)
            {
                Response.Redirect("/Admin/");
            }
        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.open();
            string sql = string.Format("UPDATE Anuncio SET Nome = '{0}', Jogo = '{1}' , Tempo = '{2}' , Descricao = '{3}', Site = '{4}', Link = '{5}'" +
                 " WHERE Codigo = {6}", TextBoxNomeAn.Text, txtNomeJogo.Text, DropDownListTempo.SelectedValue, TextBoxDescricao.Text, TextBoxLinkServer.Text,
                 TextBoxLinkAn.Text, Request.QueryString["id"]);
            int rowAffecteds = db.ExecuteCmd(sql);
            db.close();
            if (rowAffecteds > 0)
            {
                Response.Write("<script LANGUAGE='JavaScript'>alert('Editado com sucesso')</script>"); // mensagem 
                Response.Redirect("/");
            }
            Response.Write("<script LANGUAGE='JavaScript'>alert('Não foi possivel editar')</script>"); // mensagem 
            Response.Redirect("/");
           
        }
    }
}