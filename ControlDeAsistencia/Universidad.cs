using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControlDeAsistencia
{
    public class Universidad //clase contenedora
    {
        public class Estudiante//clase anidada
        {
            public Estudiante(string nombreEstudiante, int sesionesTotales, int sesionesAsistidas)
            {
                NombreEstudiante = nombreEstudiante;
                SesionesTotales = sesionesTotales;
                SesionesAsistidas = sesionesAsistidas;
            }

            public string NombreEstudiante { get; set; }
            public int SesionesTotales { get; set; }
            public int SesionesAsistidas { get; set; }

            internal class Asistencia
            {
                public static double CalcularPorcentaje(Estudiante estudiante)
                {
                    return (double)estudiante.SesionesAsistidas / estudiante.SesionesTotales * 100;
                }

                public static bool MinimoAsistenciasCumplidas(Estudiante estudiante, double porcentajeMinimo = 75)
                {
                    double porcentaje = CalcularPorcentaje(estudiante);
                    return porcentaje >= porcentajeMinimo;
                }
            }
            public void MostrarInformacion()
            {
                double porcentaje = Asistencia.CalcularPorcentaje(this);
                bool minimoAsistenciasCumplidas = Asistencia.MinimoAsistenciasCumplidas(this);

                Console.WriteLine($"Estudiante: {NombreEstudiante}");
                Console.WriteLine($"Porcentaje de asistencia: {porcentaje:F2}%");
                if (minimoAsistenciasCumplidas)
                {
                    Console.WriteLine("Cumple con el requisito de asistencia.");
                }
                else
                {
                    Console.WriteLine("No cumple con el requisito de asistencia.");
                }
                Console.WriteLine();
            }



        }

    }
}
