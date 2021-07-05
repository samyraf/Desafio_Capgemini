using Entities.Models;
using NUnit.Framework;
using System;

namespace CadastroAnuncioTest
{
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void CalcularAlcanceTotal_ComValorValido()
        {
            AnuncioModel anuncio = new AnuncioModel
            {
                InvestimentoPorDia = 1,
                DataInicio = new DateTime(2021, 01, 01),
                DataTermino = new DateTime(2021, 01, 02),
            };

            var relatorio = new RelatorioAnuncio(anuncio);

            relatorio.CalcularAlcanceTotal();

            Assert.AreEqual(51.6, relatorio.QuantidadeMaximaVisualizacoes);
        }

        [Test]
        public void CalcularAlcanceTotal_ComValorInvalido()
        {
            AnuncioModel anuncio = new AnuncioModel();

            var relatorio = new RelatorioAnuncio(anuncio);

            relatorio.CalcularAlcanceTotal();

            Assert.AreEqual(0, relatorio.QuantidadeMaximaVisualizacoes);
        }

        [Test]
        public void CalcularVisualizacoesPorValorTotalInvestido_ComValorValido()
        {
            AnuncioModel anuncio = new AnuncioModel
            {
                InvestimentoPorDia = 1,
                DataInicio = new DateTime(2021, 01, 01),
                DataTermino = new DateTime(2021, 01, 02),
            };

            var relatorio = new RelatorioAnuncio(anuncio);

            relatorio.CalcularVisualizacoesPorValorTotalInvestido();

            Assert.AreEqual(30.0, relatorio.QuantidadeMaximaVisualizacoes);
        }

        [Test]
        public void CalcularVisualizacoesPorValorTotalInvestido_ComValorInvalido()
        {
            AnuncioModel anuncio = new AnuncioModel
            {
                InvestimentoPorDia = 1,
                DataInicio = new DateTime(2021, 01, 01),
                DataTermino = new DateTime(2021, 01, 01),
            };

            var relatorio = new RelatorioAnuncio(anuncio);

            relatorio.CalcularAlcanceTotal();

            Assert.AreEqual(0, relatorio.QuantidadeMaximaVisualizacoes);
        }

        [Test]
        public void CalcularQtdMaxCliques_ComValorValido()
        {
            AnuncioModel anuncio = new AnuncioModel
            {
                InvestimentoPorDia = 1,
                DataInicio = new DateTime(2021, 01, 01),
                DataTermino = new DateTime(2021, 01, 02),
            };

            var relatorio = new RelatorioAnuncio(anuncio);

            relatorio.CalcularVisualizacoesPorValorTotalInvestido();

            relatorio.CalcularQtdMaxCliques();

            Assert.AreEqual(3.6, Convert.ToDecimal(relatorio.QuantidadeMaximaCliques));
        }

        [Test]
        public void CalcularQtdMaxCliques_ComValorInvalido()
        {
            AnuncioModel anuncio = new AnuncioModel();

            var relatorio = new RelatorioAnuncio(anuncio);

            relatorio.CalcularQtdMaxCliques();

            Assert.AreEqual(0, relatorio.QuantidadeMaximaCliques);
        }

        [Test]
        public void CalcularQtdMaxCompartilhamentos_ComValorValido()
        {
            AnuncioModel anuncio = new AnuncioModel
            {
                InvestimentoPorDia = 1,
                DataInicio = new DateTime(2021, 01, 01),
                DataTermino = new DateTime(2021, 01, 02),
            };

            var relatorio = new RelatorioAnuncio(anuncio);

            relatorio.CalcularVisualizacoesPorValorTotalInvestido();

            relatorio.CalcularQtdMaxCliques();

            relatorio.CalcularQtdMaxCompartilhamentos();

            Assert.AreEqual(0.54, relatorio.QuantidadeMaximaCompartilhamentos);
        }

        [Test]
        public void CalcularQtdMaxCompartilhamentos_ComValorInvalido()
        {
            AnuncioModel anuncio = new AnuncioModel();

            var relatorio = new RelatorioAnuncio(anuncio);

            relatorio.QuantidadeMaximaCliques = 0;

            relatorio.CalcularQtdMaxCompartilhamentos();

            Assert.AreEqual(0, relatorio.QuantidadeMaximaCompartilhamentos);
        }
    }
}