using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AnuncioModel
    {
        public int Id { get; set; }
        public double InvestimentoPorDia { get; set; }
        public string NomeAnuncio { get; set; }
        public string Cliente { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
    }
}
