using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class RelatorioAnuncio
    {
        public RelatorioAnuncio(AnuncioModel anuncio)
        {
            Anuncio = anuncio;

            CalcularValorTotalInvestido();

            Calculadora = new Calculadora(ValorTotalInvestido);
        }

        public double ValorTotalInvestido { get; set; }
        public double QuantidadeMaximaVisualizacoes { get; set; }
        public double QuantidadeMaximaCliques { get; set; }
        public double QuantidadeMaximaCompartilhamentos { get; set; }
        public AnuncioModel Anuncio { get; set; }
        private Calculadora Calculadora { get; set; }

        public void CalcularAlcanceTotal()
        {
            CalcularVisualizacoesPorValorTotalInvestido();

            CalcularQtdMaxCliques();

            CalcularQtdMaxCompartilhamentos();

            CalcularQtdMaxVisualizacoes();
        }

        public void CalcularValorTotalInvestido()
        {
            ValorTotalInvestido = Anuncio != null ? Anuncio.InvestimentoPorDia * Convert.ToInt32(Anuncio.DataTermino.Subtract(Anuncio.DataInicio).Days) : 0;
        }

        public void CalcularVisualizacoesPorValorTotalInvestido()
        {
            Calculadora.CalcularVisualizacoesPorValorInvestido();

            QuantidadeMaximaVisualizacoes = Calculadora.TotalVisualizacoes;
        }

        public void CalcularQtdMaxCliques()
        {
            Calculadora.CalcularCliquesPorVisualizacao();

            QuantidadeMaximaCliques = Calculadora.CliquesPorVisualizacao;
        }

        public void CalcularQtdMaxCompartilhamentos()
        {
            Calculadora.CalcularCompartilhamentos();

            QuantidadeMaximaCompartilhamentos = Calculadora.QtdCompartilhamentos;
        }

        public void CalcularQtdMaxVisualizacoes()
        {
            Calculadora.CalcularTotalVisualizacoes();

            QuantidadeMaximaVisualizacoes = Calculadora.TotalVisualizacoes;
        }
    }
}
