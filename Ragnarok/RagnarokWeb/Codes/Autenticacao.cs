using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
namespace RagnarokWeb.Codes
{
    public class Autenticacao
    {
        private HttpResponse response;
        private HttpSessionState session;
        public Autenticacao(HttpResponse resp,HttpSessionState session)
        {
            this.response = resp;
            this.session = session;
        }

        /// <summary>
        /// Salva uma informação na sessão atual
        /// </summary>
        /// <param name="name">Nome do campo da sessão</param>
        /// <param name="value">Valor da sesão</param>
        /// <returns>Bool se falso - foi passado parametros invalidos</returns>
        public bool SaveSession(string name,string value)
        {
            if(name.Length > 0 && value.Length > 0)
            {
                session[name] = value;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna se um certo dado esta na sessão
        /// </summary>
        /// <param name="name"></param>
        /// <returns>falso caso não exista e true caso exista</returns>
        public bool ExistsInSession(string name)
        {
            //se este campo da sessao não for nulo
            return !Object.Equals(session[name], null);
        }

        /// <summary>
        /// Se achave existir na seção retorna string senão retorna string  - empty(vazio)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string getKey(string key)
        {
            if(!Object.Equals(session[key], null))
            {
                return session[key].ToString();
            }
            return "";
        }
    }
}