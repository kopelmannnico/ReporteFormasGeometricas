using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Services
{
    public interface IImpresionReporte
    {
        string ObtenerNombreFigura(Type tipo);
        string ObtenerNombreFiguraPlural(Type tipo);
        string ObtenerEncabezado();
        string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipoFiguraGeometrica);
        string ObtenerTotal(int cantidadTotal, decimal areaTotal, decimal perimetroTotal);
        string ObtenerLeyendaListaVacia();
    }
}
