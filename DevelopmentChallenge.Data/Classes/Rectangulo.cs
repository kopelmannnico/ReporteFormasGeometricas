using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : IFormaGeometrica
    {
        private decimal ladoA;
        private decimal ladoB;

        public Rectangulo() { }

        public Rectangulo(decimal ladoA, decimal ladoB)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
        }

        public decimal CalcularArea()
        {
            return ladoA * ladoB;
        }

        public decimal CalcularPerimetro()
        {
            return 2 * (ladoA + ladoB);
        }

        public string ObtenerNombre()
        {
            return GetType().Name;
        }
    }

}
