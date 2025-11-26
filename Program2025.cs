
using System;

class Program
{
    static void Main()
    {
        Console.Write("ponga la cantidad de estudiantes: ");
        int numEstudiantes = int.Parse(Console.ReadLine());

        for (int i = 0; i < numEstudiantes; i++)
        {
            Console.WriteLine("\n");

            Console.Write($"Noombre del estudiante #{i + 1}: ");
            string nombreEst = Console.ReadLine();

            Console.Write($"pongaa la cantidad de asignaturas de {nombreEst}: ");
            int numAsignaturas = int.Parse(Console.ReadLine());

            double sumaPromedios = 0;

            Console.WriteLine("\nresultados del estudiante");
            Console.WriteLine("Estudiante: " + nombreEst);

            for (int j = 0; j < numAsignaturas; j++)
            {
                Console.WriteLine($"\n--- Asignatura {j + 1} ---");

                Console.Write("Nombre de la asignatura: ");
                string nombreAsig = Console.ReadLine();

                double[] calificaciones = new double[4];

                for (int k = 0; k < 4; k++)
                {
                    Console.Write($"Calificación fimal #{k + 1}: ");
                    calificaciones[k] = double.Parse(Console.ReadLine());
                }

                double suma = 0;
                foreach (double nota in calificaciones)
                {
                    suma += nota;
                }
                double promedio = suma / 4;

                sumaPromedios += promedio;

                Console.WriteLine("\nAsignatura: " + nombreAsig);
                Console.WriteLine("Calificaciones: " + string.Join(", ", calificaciones));
                Console.WriteLine("Promedio: " + Math.Round(promedio, 2));
            }

            double promedioGeneral = sumaPromedios / numAsignaturas;

            Console.WriteLine("\n=======================================");
            Console.WriteLine($"Promedio general de {nombreEst}: {Math.Round(promedioGeneral, 2)}");
            Console.WriteLine("=======================================\n");
        }
    }
}
