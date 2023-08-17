using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Impresion
{
    public class ImpresionReporteEspanol : IImpresionReporte
    {
        private Dictionary<Type, string> _nombresTraducidos;
        private Dictionary<Type, string> _nombresTraducidosPlural;

        public ImpresionReporteEspanol()
        {
            CultureInfo spanishCulture = new CultureInfo("es-ES");
            CultureInfo.CurrentCulture = spanishCulture;

            _nombresTraducidos = new Dictionary<Type, string>
            {
                { typeof(Circulo), "Círculo" },
                { typeof(Cuadrado), "Cuadrado" },
                { typeof(Rectangulo), "Rectángulo" },
                { typeof(Trapecio), "Trapecio" },
                { typeof(TrapecioRectangulo), "Trapecio Rectángulo" },
                { typeof(TrianguloEquilatero), "Triángulo" }
            };

            _nombresTraducidosPlural = new Dictionary<Type, string>
            {
                { typeof(Circulo), "Círculos" },
                { typeof(Cuadrado), "Cuadrados" },
                { typeof(Rectangulo), "Rectángulos" },
                { typeof(Trapecio), "Trapecios" },
                { typeof(TrapecioRectangulo), "Trapecios Rectángulos" },
                { typeof(TrianguloEquilatero), "Triángulos" }
            };
        }

        public string ObtenerNombreFigura(Type tipo)
        {
            if (_nombresTraducidos.TryGetValue(tipo, out string nombre))
            {
                return nombre;
            }
            return "Unknown";
        }

        public string ObtenerNombreFiguraPlural(Type tipo)
        {
            if (_nombresTraducidosPlural.TryGetValue(tipo, out string nombre))
            {
                return nombre;
            }
            return "Unknown";
        }

        public string ObtenerEncabezado()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipoFiguraGeometrica)
        {
            return $"{cantidad} {tipoFiguraGeometrica} | Área {area:#.##} | Perímetro {perimetro:#.##} <br/>";
        }

        public string ObtenerTotal(int cantidadTotal, decimal areaTotal, decimal perimetroTotal)
        {
            return $"TOTAL:<br/>{cantidadTotal} formas Perímetro {perimetroTotal:#.##} Área {areaTotal:#.##}";
        }

        public string ObtenerLeyendaListaVacia() 
        {
            return "<h1>Lista vacía de formas!</h1>";
        }
    }
}
