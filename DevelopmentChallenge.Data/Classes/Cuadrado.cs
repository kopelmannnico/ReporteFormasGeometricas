using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : IFormaGeometrica
    {
        private decimal lado;

        public Cuadrado() { }

        public Cuadrado(decimal lado)
        {
            this.lado = lado;
        }

        public decimal CalcularArea()
        {
            return lado * lado;
        }

        public decimal CalcularPerimetro()
        {
            return 4 * lado;
        }

        public string ObtenerNombre()
        {
            return GetType().Name;
        }
    }
}
