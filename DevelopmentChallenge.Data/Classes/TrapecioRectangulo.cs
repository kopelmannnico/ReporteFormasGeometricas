using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrapecioRectangulo : IFormaGeometrica
    {
        private decimal baseMayor;
        private decimal baseMenor;
        private decimal altura;

        public TrapecioRectangulo() { }

        public TrapecioRectangulo(decimal baseMayor, decimal baseMenor, decimal altura)
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
            decimal ladoA = Math.Abs(baseMayor - baseMenor) / 2;
            decimal ladoB = altura;
            decimal ladoC = (decimal)Math.Sqrt(Convert.ToDouble(ladoA * ladoA + ladoB * ladoB));

            return baseMayor + baseMenor + ladoC * 2;
        }

        public string ObtenerNombre()
        {
            return GetType().Name;
        }
    }

}
