using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Impresion;
using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //List<IFormaGeometrica> formas = new List<IFormaGeometrica>
                //{
                //    FormaGeometricaFactory.CrearForma("circulo", 5m),                 //Círculo con radio 5
                //    FormaGeometricaFactory.CrearForma("trianguloequilatero", 6m),    //Triángulo equilátero con lado 6
                //    FormaGeometricaFactory.CrearForma("trapecio", 8m, 5m, 4m),         //Trapecio con bases 8 y 5, y altura 4
                //    FormaGeometricaFactory.CrearForma("rectangulo", 7m, 3m),          //Rectángulo con lados 7 y 3
                //    FormaGeometricaFactory.CrearForma("circulo", 6m),                 //Círculo con radio 5
                //    FormaGeometricaFactory.CrearForma("trapecio", 9m, 6m, 5m),         //Trapecio con bases 8 y 5, y altura 4
                //    FormaGeometricaFactory.CrearForma("trapeciorectangulo", 10m, 7m, 5m) //Trapecio rectángulo con bases 10 y 7, y altura 5
                //};

                var formas = new List<IFormaGeometrica>
                {
                    FormaGeometricaFactory.CrearForma("cuadrado", 5m),
                    FormaGeometricaFactory.CrearForma("circulo", 3m),
                    FormaGeometricaFactory.CrearForma("trianguloEquilatero", 4m),
                    FormaGeometricaFactory.CrearForma("cuadrado", 2m),
                    FormaGeometricaFactory.CrearForma("trianguloEquilatero", 9m),
                    FormaGeometricaFactory.CrearForma("circulo", 2.75m),
                    FormaGeometricaFactory.CrearForma("trianguloEquilatero", 4.2m)
                };

                //List<IFormaGeometrica> formas = new List<IFormaGeometrica>();

                ReporteFormas reporte = new ReporteFormas(formas);

                //Imprimir en diferentes idiomas
                IImpresionReporte impresionEspanol = new ImpresionReporteEspanol();
                IImpresionReporte impresionIngles = new ImpresionReporteIngles();
                IImpresionReporte impresionItaliano = new ImpresionReporteItaliano();

                Console.WriteLine(reporte.Imprimir(impresionEspanol));

                Console.WriteLine(string.Empty);

                Console.WriteLine(reporte.Imprimir(impresionIngles));

                Console.WriteLine(string.Empty);

                Console.WriteLine(reporte.Imprimir(impresionItaliano));

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
