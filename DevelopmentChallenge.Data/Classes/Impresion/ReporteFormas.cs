using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Impresion
{
    public class ReporteFormas
    {
        private List<IFormaGeometrica> formas;

        public ReporteFormas(List<IFormaGeometrica> formas)
        {
            this.formas = formas;
        }

        public string Imprimir(IImpresionReporte impresionReporte)
        {
            var sb = new StringBuilder();

            

            if (!formas.Any())
            {
                sb.Append(impresionReporte.ObtenerLeyendaListaVacia());
            }
            else
            {
                sb.Append(impresionReporte.ObtenerEncabezado());
                var resumenPorTipo = formas
                    .GroupBy(forma => forma.ObtenerNombre())
                    .Select(group => new
                    {
                        Tipo = group.Key,
                        Cantidad = group.Count(),
                        AreaTotal = group.Sum(forma => forma.CalcularArea()),
                        PerimetroTotal = group.Sum(forma => forma.CalcularPerimetro())
                    });

                foreach (var resumen in resumenPorTipo)
                {
                    sb.Append(impresionReporte.ObtenerLinea(resumen.Cantidad, resumen.AreaTotal, resumen.PerimetroTotal, 
                                                            resumen.Cantidad == 1 ? impresionReporte.ObtenerNombreFigura(Type.GetType($"DevelopmentChallenge.Data.Classes.{resumen.Tipo}")) : impresionReporte.ObtenerNombreFiguraPlural(Type.GetType($"DevelopmentChallenge.Data.Classes.{resumen.Tipo}"))));
                }

                sb.Append(impresionReporte.ObtenerTotal(formas.Count, formas.Sum(forma => forma.CalcularArea()), formas.Sum(forma => forma.CalcularPerimetro())));
            }

            return sb.ToString();
        }
    }
}
