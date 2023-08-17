using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : IFormaGeometrica
    {
        private decimal baseMayor;
        private decimal baseMenor;
        private decimal altura;

        public Trapecio() { }

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.altura = altura;
        }

        public decimal CalcularArea()
        {
            return ((baseMayor + baseMenor) / 2) * altura;
        }

        public decimal CalcularPerimetro()
        {
            return baseMayor + baseMenor + 2 * (decimal)Math.Sqrt(Convert.ToDouble(((baseMayor - baseMenor) / 2) * ((baseMayor - baseMenor) / 2) + altura * altura));
        }

        public string ObtenerNombre()
        {
            return GetType().Name;
        }
    }

}
