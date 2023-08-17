using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DevelopmentChallenge.Data.Classes.Impresion
{
    public class ImpresionReporteItaliano : IImpresionReporte
    {
        private Dictionary<Type, string> _nombresTraducidos;
        private Dictionary<Type, string> _nombresTraducidosPlural;

        public ImpresionReporteItaliano()
        {
            CultureInfo spanishCulture = new CultureInfo("es-ES");
            CultureInfo.CurrentCulture = spanishCulture;

            _nombresTraducidos = new Dictionary<Type, string>
            {
                { typeof(Circulo), "Cerchio" },
                { typeof(Cuadrado), "Piazza" },
                { typeof(Rectangulo), "Rettangolo" },
                { typeof(Trapecio), "Trapezio" },
                { typeof(TrapecioRectangulo), "Trapezio Rettangolo" },
                { typeof(TrianguloEquilatero), "Triangolo" }
            };

            _nombresTraducidosPlural = new Dictionary<Type, string>
            {
                { typeof(Circulo), "Cerchi" },
                { typeof(Cuadrado), "Piazze" },
                { typeof(Rectangulo), "Rettangoli" },
                { typeof(Trapecio), "Trapezi" },
                { typeof(TrapecioRectangulo), "Trapezi Rettangolari" },
                { typeof(TrianguloEquilatero), "Triangoli" }
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
            return "<h1>Relazione sulle forme</h1>";
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipoFiguraGeometrica)
        {
            return $"{cantidad} {tipoFiguraGeometrica} | Zona {area:#.##} | Perimetro {perimetro:#.##} <br/>";
        }

        public string ObtenerTotal(int cantidadTotal, decimal areaTotal, decimal perimetroTotal)
        {
            return $"TOTAL:<br/>{cantidadTotal} forme Perimetro {perimetroTotal:#.##} Zona {areaTotal:#.##}";
        }

        public string ObtenerLeyendaListaVacia()
        {
            return "<h1>Elenco vuoto di forme!</h1>";
        }
    }
}
