using static System.Console;
using System.Reflection.PortableExecutable;

namespace Practica2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Analizador De Notas");
        Console.WriteLine();

        Console.Write("Ingrese su nombre: ");
        string nombreEstudiante = Console.ReadLine();

        double[] calificaciones = LeerCalificaciones();

        Console.WriteLine();
        Console.WriteLine($"Estudiante: {nombreEstudiante}");
        Console.WriteLine("Calificaciones");

        ImprimirCalificaciones( calificaciones );
        double calificacionMaxima = ObtenerMaximo(calificaciones);
        double calificacionMinimo = ObtenerMinimo(calificaciones);
        double promedio = ObtenerPromedio(calificaciones);

        Console.WriteLine();
        Console.WriteLine($"La calificacion maxima: {calificacionMaxima}");
        Console.WriteLine($"La calificacion minima: {calificacionMinimo}");
        Console.WriteLine($"Promedio: {promedio:F2}");

        if (promedio >= 71)
        {
            Console.WriteLine("EL estudiante aprobado");
        }
        else
        {
            Console.WriteLine("EL estudiante reprobo");
        }
    }

    static double[] LeerCalificaciones()
    {
        double[] calificaciones = new double[5];

        for (int posicion = 0; posicion < calificaciones.Length; posicion++)
        {
            Console.Write($"Ingrese su calificacion {posicion + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out calificaciones[posicion]))
            {
                Console.Write("Ingrese un numero valido: ");
            }
        }
        return calificaciones;
    }

    static void ImprimirCalificaciones(double[] calificaciones)
    {
        for (int posicion = 0; posicion < calificaciones.Length; posicion++)
        {
            Console.WriteLine(calificaciones[posicion]);
        }
    }

    static double ObtenerMaximo(double[] calificaciones)
    {
        double maximo = calificaciones[0];

        for (int posicion = 1; posicion < calificaciones.Length; posicion++)
        {
            if (calificaciones[posicion] > maximo)
            {
                maximo = calificaciones[posicion];
            }
        }
        return maximo;
    }

    static double ObtenerMinimo(double[] calificaciones)
    {
        double minimo = calificaciones[0];

        for (int posicion = 1; posicion < calificaciones.Length; posicion++)
        {
            if (calificaciones[posicion] < minimo)
            {
                minimo = calificaciones[posicion];
            }
        }
        return minimo;
    }

    static double ObtenerPromedio(double[] calificaciones)
    {
        double suma = 0;

        for (int posicion = 0; posicion < calificaciones.Length; posicion++)
        {
            suma += calificaciones[posicion];
        }
        return suma / calificaciones.Length;
    }
}
