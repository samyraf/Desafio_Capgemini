using DesafioCalculadora;
using NUnit.Framework;
using System;

namespace DesafioCalculadoraTest
{
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void CalcularVisualizacoesPorValorInvestido_ComValorValido()
        {
            var calculadora = new Calculadora(1.0);
            calculadora.CalcularVisualizacoesPorValorInvestido();
            Assert.AreEqual(30.0, calculadora.TotalVisualizacoes);
        }

        [Test]
        public void CalcularVisualizacoesPorValorInvestido_ComValorInvalido()
        {
            var calculadora = new Calculadora(-1.0);
            calculadora.CalcularVisualizacoesPorValorInvestido();
            Assert.AreEqual(0, calculadora.TotalVisualizacoes);
        }

        [Test]
        public void CalcularCliquesPorVisualizacao_ComValorValido()
        {
            var calculadora = new Calculadora(4.0);
            calculadora.TotalVisualizacoes = 120;
            calculadora.CalcularCliquesPorVizualizacao();
            Assert.AreEqual(14.4, Convert.ToDecimal(calculadora.CliquesPorVisualizacao));
        }

        [Test]
        public void CalcularCliquesPorVisualizacao_ComValorInvalido()
        {
            var calculadora = new Calculadora(-4.0);
            calculadora.TotalVisualizacoes = -120;
            calculadora.CalcularCliquesPorVizualizacao();
            Assert.AreEqual(0, Convert.ToDecimal(calculadora.CliquesPorVisualizacao));
        }

        [Test]
        public void CalcularCompartilhamentos_ComValorValido()
        {
            var calculadora = new Calculadora(1.0);
            calculadora.CliquesPorVisualizacao = 20;
            calculadora.CalcularCompartilhamentos();
            Assert.AreEqual(3.0, Convert.ToDecimal(calculadora.QtdCompartilhamentos));
        }

        [Test]
        public void CalcularCompartilhamentos_ComValorInvalido()
        {
            var calculadora = new Calculadora(1.0);
            calculadora.CliquesPorVisualizacao = -20;
            calculadora.CalcularCompartilhamentos();
            Assert.AreEqual(0, Convert.ToDecimal(calculadora.QtdCompartilhamentos));
        }

        [Test]
        public void CalcularCompartilhamentos_ComValorMaiorQueQuatro()
        {
            var calculadora = new Calculadora(1.0);
            calculadora.CliquesPorVisualizacao = 40;
            calculadora.CalcularCompartilhamentos();
            Assert.AreEqual(4.0, Convert.ToDecimal(calculadora.QtdCompartilhamentos));
        }

        [Test]
        public void CalcularTotalVisualizacoes_ComValorValido()
        {
            var calculadora = new Calculadora(1.0);
            calculadora.QtdCompartilhamentos = 1;
            calculadora.CalcularTotalVizualizacoes();
            Assert.AreEqual(40, Convert.ToDecimal(calculadora.TotalVisualizacoes));
        }

        [Test]
        public void CalcularTotalVisualizacoes_ComValorInvalido()
        {
            var calculadora = new Calculadora(1.0);
            calculadora.QtdCompartilhamentos = -1;
            calculadora.CalcularTotalVizualizacoes();
            Assert.AreEqual(0, Convert.ToDecimal(calculadora.TotalVisualizacoes));
        }

        [Test]
        public void CalcularAlcanceTotal_ComValorValido()
        {
            var calculadora = new Calculadora(1.0);
            calculadora.CalcularAlcanceTotal();
            Assert.AreEqual(51.6, Convert.ToDecimal(calculadora.TotalVisualizacoes));
        }

        [Test]
        public void CalcularAlcanceTotal_ComValorInvalido()
        {
            var calculadora = new Calculadora(-1.0);
            calculadora.CalcularAlcanceTotal();
            Assert.AreEqual(0, Convert.ToDecimal(calculadora.TotalVisualizacoes));
        }
    }
}
