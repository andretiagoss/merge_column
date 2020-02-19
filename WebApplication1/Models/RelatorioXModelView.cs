using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class RelatorioXModelView
    {
        public string Estado { get; set; }
        public IEnumerable<Cidade> ListaCidades { get; set; }
        public int QtdeDias { get; set; }
    }

    public class Cidade
    {
        public string Nome { get; set; }
        public decimal Total { get; set; }
        public IEnumerable<Dias> ListaDias { get; set; }
    }

    public class Dias
    {
        public string Dia { get; set; }
        public decimal Valor { get; set; }
    }
}