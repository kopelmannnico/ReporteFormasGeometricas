using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        private decimal lado;

        public Circulo()
        {

        }

        public Circulo(decimal lado)
        {
            this.lado = lado;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (lado / 2) * (lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * lado;
        }

        public string ObtenerNombre()
        {
            return GetType().Name;
        }
    }

}
