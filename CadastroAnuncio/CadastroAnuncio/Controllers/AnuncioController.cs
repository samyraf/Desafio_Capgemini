using CadastroAnuncio.Repositories;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAnuncio.Controllers
{
    public class AnuncioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            return Json(new AnuncioRepository().Get(id));
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Json(new AnuncioRepository().GetAll());
        }

        [HttpPost]
        public ActionResult Insert(AnuncioModel anuncio)
        {
            return Json(new AnuncioRepository().Insert(anuncio));
        }

        [HttpGet]
        public ActionResult GetAllRelatorio()
        {
            List<AnuncioModel> anunciosModel = new AnuncioRepository().GetAll();

            List<RelatorioAnuncio> relatorioAnuncios = new List<RelatorioAnuncio>();

            RelatorioAnuncio relatorio;

            foreach (var anuncio in anunciosModel)
            {
                relatorio = new RelatorioAnuncio(anuncio);

                relatorio.CalcularAlcanceTotal();

                relatorioAnuncios.Add(relatorio);
            }
            return Json(relatorioAnuncios);
        }

        [HttpGet]
        public ActionResult GetAllRelatorioByFilter(string cliente, DateTime dataInicio, DateTime dataTermino)
        {
            List<AnuncioModel> anunciosModel = new AnuncioRepository().GetAllByFilter(cliente, dataInicio, dataTermino);

            List<RelatorioAnuncio> relatorioAnuncios = new List<RelatorioAnuncio>();

            RelatorioAnuncio relatorio;

            foreach (var anuncio in anunciosModel)
            {
                relatorio = new RelatorioAnuncio(anuncio);

                relatorio.CalcularAlcanceTotal();

                relatorioAnuncios.Add(relatorio);
            }
            return Json(relatorioAnuncios);
        }
    }
}
