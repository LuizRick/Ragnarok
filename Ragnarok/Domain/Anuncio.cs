using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Namespace responsavel pelo domino da aplicação
/// Entidade da aplicação
/// </summary>
namespace Domain
{
    public class Anuncio
    {
        public string codigo { get; set; }

        public string nome { get; set; }

        public string jogo { get; set; }

        public string tempo { get; set; }

        public string descricao { get; set; }

        public string site { get; set; }

        public string link { get; set; }

        public string tamanho { get; set; }
    }
}
