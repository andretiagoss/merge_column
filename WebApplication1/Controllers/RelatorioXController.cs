using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RelatorioXController : Controller
    {
        // GET: RelatorioX
        public ActionResult Index()
        {
            var relatorioX = this.ObterRelatorioX();
            return View(relatorioX);
        }

        private IEnumerable<RelatorioXModelView> ObterRelatorioX()
        {
            List<RelatorioXModelView> listaRelatorioX = new List<RelatorioXModelView>();

            RelatorioXModelView relatorioX = new RelatorioXModelView();
            relatorioX.Estado = "São Paulo";
            relatorioX.QtdeDias = 4;
            relatorioX.ListaCidades = this.ObterCidades(relatorioX.Estado, relatorioX.QtdeDias);
            listaRelatorioX.Add(relatorioX);

            relatorioX = new RelatorioXModelView();
            relatorioX.Estado = "Rio de Janeiro";
            relatorioX.QtdeDias = 4;
            relatorioX.ListaCidades = this.ObterCidades(relatorioX.Estado, relatorioX.QtdeDias);

            listaRelatorioX.Add(relatorioX);

            return listaRelatorioX;
        }

        private IEnumerable<Cidade> ObterCidades(string estado, int qtdeDias)
        {
            List<Cidade> listaCidades = new List<Cidade>();
            Cidade cidade = new Cidade();

            if (estado == "São Paulo")
            {
                cidade.Nome = "Itupeva";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);

                cidade = new Cidade();
                cidade.Nome = "Jundiai";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);

                cidade = new Cidade();
                cidade.Nome = "Varzea Paulista";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);
            }
            else
            {
                cidade.Nome = "Niteroi";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);

                cidade = new Cidade();
                cidade.Nome = "Arraial do Cabo";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);

                cidade = new Cidade();
                cidade.Nome = "Petropolis";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);
            }

            return listaCidades;
        }

        private IEnumerable<Dias> ObterDias(int qtdeDias)
        {
            List<Dias> listaDias = new List<Dias>();

            for (int i = 1; i <= qtdeDias; i++)
            {
                listaDias.Add(new Dias()
                {
                    Dia = $"Dia {i}",
                    Valor = new decimal(100.00 * i)
                });
            }

            return listaDias;
        }
    }
}
