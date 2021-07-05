using System;

namespace Entities.Models
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

            CalcularCliquesPorVisualizacao();

            CalcularCompartilhamentos();

            CalcularTotalVisualizacoes();
        }

        public void CalcularVisualizacoesPorValorInvestido()
        {
            TotalVisualizacoes = ValorInvestido > 0 ? ValorInvestido * 30 : 0;
        }

        public void CalcularCliquesPorVisualizacao()
        {
            CliquesPorVisualizacao = TotalVisualizacoes * 0.12;
        }

        public void CalcularCompartilhamentos()
        {
            QtdCompartilhamentos = (CliquesPorVisualizacao / 20) * 3;
            QtdCompartilhamentos = QtdCompartilhamentos > 4.0 ? 4.0 : QtdCompartilhamentos;
        }

        public void CalcularTotalVisualizacoes()
        {
            TotalVisualizacoes += (QtdCompartilhamentos * 40);
        }
    }
}
