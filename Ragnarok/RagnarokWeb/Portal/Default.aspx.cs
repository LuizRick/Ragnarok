using System;
using System.Data.OleDb;
using System.Text;
using System.Collections.Generic;
using Domain;

namespace RagnarokWeb.Portal
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Anuncio> anuncios;
        string dbPath = @"C:\ragnarokdb\BancoPortal.mdb";
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0;data source=" + dbPath;
            cmd.Connection = conn;
            conn.Open();
            //para conter o comando sql a ser executado
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT Codigo,Nome,Tempo,Jogo,Descricao,Site,link FROM Anuncio");
            cmd.CommandText = sb.ToString();
            cmd.CommandType = System.Data.CommandType.Text;
            OleDbDataReader reader = cmd.ExecuteReader();
            int nome = reader.GetOrdinal("Nome");
            int tempo = reader.GetOrdinal("Tempo");
            int jogo = reader.GetOrdinal("Jogo");
            int descricao = reader.GetOrdinal("Descricao");
            int site = reader.GetOrdinal("Site");
            int link = reader.GetOrdinal("link");
            int cod = reader.GetOrdinal("Codigo");
            List<Anuncio> anuncios = new List<Anuncio>();

            while (reader.Read())
            {
                int tempoint = Convert.ToInt32(reader.GetString(tempo).Split(' ')[0]);
                string tamanho = "";
                if(tempoint > 1 && tempoint < 7)
                {
                    tamanho = "width:400px;heigth:150px";
                }else
                {
                    tamanho = "width:800px;height:150px";
                }
                anuncios.Add(new Anuncio()
                {
                    codigo = reader.GetInt32(cod).ToString(),
                    tempo = reader.GetString(tempo),
                    jogo = reader.GetString(jogo),
                    descricao = reader.GetString(descricao),
                    site = reader.GetString(site),
                    link = reader.GetString(link),
                    nome = reader.GetString(nome),
                    tamanho = tamanho,
                });
            }
            ResultAnuncios.DataSource = anuncios;
            ResultAnuncios.DataBind();
            conn.Close();
            conn.Dispose();
        }
    }
}