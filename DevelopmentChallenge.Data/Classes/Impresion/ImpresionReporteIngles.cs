using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Impresion
{
    public class ImpresionReporteIngles : IImpresionReporte
    {
        
        private Dictionary<Type, string> _nombresTraducidos;
        private Dictionary<Type, string> _nombresTraducidosPlural;

        public ImpresionReporteIngles()
        {
            CultureInfo spanishCulture = new CultureInfo("es-ES");
            CultureInfo.CurrentCulture = spanishCulture;

            _nombresTraducidos = new Dictionary<Type, string>
            {
                { typeof(Circulo), "Circle" },
                { typeof(Cuadrado), "Square" },
                { typeof(Rectangulo), "Rectangle" },
                { typeof(Trapecio), "Trapeze" },
                { typeof(TrapecioRectangulo), "TrapezoidRectangle" },
                { typeof(TrianguloEquilatero), "Triangle" }
            };

            _nombresTraducidosPlural = new Dictionary<Type, string>
            {
                { typeof(Circulo), "Circles" },
                { typeof(Cuadrado), "Squares" },
                { typeof(Rectangulo), "Rectangles" },
                { typeof(Trapecio), "Trapezes" },
                { typeof(TrapecioRectangulo), "TrapezoidRectangles" },
                { typeof(TrianguloEquilatero), "Triangles" }
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
            return "<h1>Shapes report</h1>";
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipoFiguraGeometrica)
        {
            //return $"{cantidad} {tipoFiguraGeometrica} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            return $"{cantidad} {tipoFiguraGeometrica} | Area {area.ToString("#.##")} | Perimeter {perimetro.ToString("#.##")} <br/>";
        }

        public string ObtenerTotal(int cantidadTotal, decimal areaTotal, decimal perimetroTotal)
        {
            //return $"TOTAL:<br/>{cantidadTotal} shapes Perimeter {perimetroTotal:#.##} Area {areaTotal:#.##}";
            return $"TOTAL:<br/>{cantidadTotal} shapes Perimeter {perimetroTotal.ToString("#.##")} Area {areaTotal.ToString("#.##")}";
            
        }

        public string ObtenerLeyendaListaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }
    }
}
