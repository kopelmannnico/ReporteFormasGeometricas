using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometricaFactory
    {
        private static Dictionary<string, Type> formaTipos = new Dictionary<string, Type>();

        static FormaGeometricaFactory()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(IFormaGeometrica).IsAssignableFrom(type) && !type.IsInterface)
                {
                    IFormaGeometrica forma = (IFormaGeometrica)Activator.CreateInstance(type);
                    formaTipos.Add(forma.ObtenerNombre().ToLower(), type);
                }
            }
        }

        public static IFormaGeometrica CrearForma(string tipo, params object[] parametros)
        {
            if (formaTipos.TryGetValue(tipo.ToLower(), out Type formaType))
            {
                return (IFormaGeometrica)Activator.CreateInstance(formaType, parametros);
            }
            throw new ArgumentException("Tipo de forma geométrica no válido.");
        }
    }

}
