using System;
using InputHelperLibrary;
namespace PracticaLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre su nombre: ");
            string nombre = InputHelper.ReadNonEmptyString();

            Console.Write("Entre su edad: ");
            int edad = InputHelper.ReadInteger();

            Console.Write("Entre su pais: ");
            string pais = InputHelper.ReadNonEmptyString();

            ReporterBuilder construir = new ReporterBuilder();

            string repote = construir.BuildReport(nombre, edad, pais);

            Console.WriteLine();
            Console.WriteLine(repote);
        }
    }
}
