using System;
using System.Data.OleDb;
using System.Text;
using System.Collections.Generic;
using System.Web.Services;
using RagnarokWeb.Codes;
using System.Data;
using Domain;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    /// <summary>
    /// Validar o email no lado do servidor - WebMethod
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    [WebMethod]
    public static Object Validar_Login(string email)
    {
        DataBase db = new DataBase();
        db.open();
        IDataReader reader = (IDataReader) db.ReturnQuery("SELECT * FROM Usuario WHERE Email = '" + email + "'");
        int count = 0;
        while (reader.Read())
        {
            count++;
        }
        reader.Close();
        reader.Dispose();
        db.close();
        return count > 0;
    }
}