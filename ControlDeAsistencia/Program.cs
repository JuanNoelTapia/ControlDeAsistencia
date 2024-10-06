using System;

namespace ControlDeAsistencia
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Universidad.Estudiante> estudiantes = new List<Universidad.Estudiante>
        {
            new Universidad.Estudiante("Juan Tapia", 27, 27),
            new Universidad.Estudiante("Daniela Castillo", 27, 16),
            new Universidad.Estudiante("Sara Blandon", 27, 24),
            new Universidad.Estudiante("Erlan Surez", 27, 25),
        };

        foreach (var estudiante in estudiantes)
        {
            estudiante.MostrarInformacion();
        }

        }
    }

}