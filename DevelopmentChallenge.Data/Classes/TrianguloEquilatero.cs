using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        private decimal lado;

        public TrianguloEquilatero() { }

        public TrianguloEquilatero(decimal lado)
        {
            this.lado = lado;
        }

        public decimal CalcularArea()
        {
            return (decimal)(Math.Sqrt(3) / 4) * lado * lado;
        }

        public decimal CalcularPerimetro()
        {
            return 3 * lado;
        }

        public string ObtenerNombre()
        {
            return GetType().Name;
        }
    }

}
