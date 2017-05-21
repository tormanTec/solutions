using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mercado_do_Aco.Models
{
    public class Produto
    {
        public int Cod { set; get; }
        public int CodBarra { set; get; }
        public string Grupo { set; get; }
        public string Nome { set; get; }
        public string Descricao { set; get; }

    }
}