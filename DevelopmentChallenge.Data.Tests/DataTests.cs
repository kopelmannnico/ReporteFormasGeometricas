using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Impresion;
using DevelopmentChallenge.Data.Services;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>();
            ReporteFormas reporte = new ReporteFormas(formas);
            IImpresionReporte impresion = new ImpresionReporteEspanol();
            
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                            reporte.Imprimir(impresion));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>();
            ReporteFormas reporte = new ReporteFormas(formas);
            IImpresionReporte impresion = new ImpresionReporteIngles();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                            reporte.Imprimir(impresion));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>();
            ReporteFormas reporte = new ReporteFormas(formas);
            IImpresionReporte impresion = new ImpresionReporteItaliano();
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                            reporte.Imprimir(impresion));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Área 25", 
                            new ReporteFormas(new List<IFormaGeometrica>(){ FormaGeometricaFactory.CrearForma("cuadrado", 5m) }).Imprimir(new ImpresionReporteEspanol()));
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                FormaGeometricaFactory.CrearForma("cuadrado", 5m),
                FormaGeometricaFactory.CrearForma("cuadrado", 1m),
                FormaGeometricaFactory.CrearForma("cuadrado", 3m)
            };

            ReporteFormas reporte = new ReporteFormas(cuadrados);
            IImpresionReporte impresion = new ImpresionReporteIngles();

            var resumen = reporte.Imprimir(impresion);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
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

            ReporteFormas reporte = new ReporteFormas(formas);
            IImpresionReporte impresion = new ImpresionReporteIngles();

            var resumen = reporte.Imprimir(impresion);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
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

            ReporteFormas reporte = new ReporteFormas(formas);
            IImpresionReporte impresion = new ImpresionReporteEspanol();

            var resumen = reporte.Imprimir(impresion);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 97,66 Área 91,65",
                resumen);
        }

        [Test]
        public void TestTipoDeFormaGeomtricaNoValido()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FormaGeometricaFactory.CrearForma("circunferencia", 3m);
            });
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
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

            ReporteFormas reporte = new ReporteFormas(formas);
            IImpresionReporte impresion = new ImpresionReporteItaliano();

            var resumen = reporte.Imprimir(impresion);

            Assert.AreEqual(
                "<h1>Relazione sulle forme</h1>2 Piazze | Zona 29 | Perimetro 28 <br/>2 Cerchi | Zona 13,01 | Perimetro 18,06 <br/>3 Triangoli | Zona 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 forme Perimetro 97,66 Zona 91,65",
                resumen);
        }
    }
}
