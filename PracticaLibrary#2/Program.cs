using UlilityLibrary;
namespace PracticaLibrary_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathUtilities math = new MathUtilities();
            DateUtilities date = new DateUtilities();

            Console.WriteLine("MathUtilities");
            int resultado0 = math.Add(50, 50);
            Console.WriteLine(resultado0);

            double resultado1 = math.AddDouble(15.5, 15.5);
            Console.WriteLine(resultado1);

            int resultado2 = math.AddTriple(10,20,30);
            Console.WriteLine(resultado2);

            double resultado3 = math.Average(10,20,30,40,50);
            Console.WriteLine(resultado3);

            Console.WriteLine("DateUtilities");
            DateTime fechaHoy = new DateTime(2026, 8, 1);
            DateTime fechaDespues = new DateTime(2026, 8, 8);
            
            int diasEnMedio = date.DaysBetween(fechaHoy, fechaDespues);
            Console.WriteLine(diasEnMedio);

            bool EsFinDeSemana = date.IsWeekend(fechaHoy);
            Console.WriteLine(EsFinDeSemana);
        }
    }
}
