using System;

namespace DesafioCalculadora
{
    public class Calculadora
    {
        public Calculadora(double valorInvestido)
        {
            ValorInvestido = valorInvestido;
        }

        public double ValorInvestido { get; set; }
        public double CliquesPorVisualizacao { get; set; }
        public double QtdCompartilhamentos { get; set; }
        public double TotalVisualizacoes { get; set; }

        public void CalcularAlcanceTotal()
        {
            CalcularVisualizacoesPorValorInvestido();

            CalcularCliquesPorVizualizacao();

            CalcularCompartilhamentos();

            CalcularTotalVizualizacoes();
        }

        public void CalcularVisualizacoesPorValorInvestido()
        {
            TotalVisualizacoes = ValorInvestido > 0 ? (ValorInvestido * 30) : 0;
        }

        public void CalcularCliquesPorVizualizacao()
        {
            CliquesPorVisualizacao = TotalVisualizacoes > 0 ? (TotalVisualizacoes / 100) * 12 : 0;
        }

        public void CalcularCompartilhamentos()
        {
            QtdCompartilhamentos = CliquesPorVisualizacao > 0 ? (CliquesPorVisualizacao / 20) * 3 : 0;
            QtdCompartilhamentos = QtdCompartilhamentos > 4.0 ? 4.0 : QtdCompartilhamentos;
        }

        public void CalcularTotalVizualizacoes()
        {
            TotalVisualizacoes += QtdCompartilhamentos > 0 ? (QtdCompartilhamentos * 40) : 0;
        }
    }
}