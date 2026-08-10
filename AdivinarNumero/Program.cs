using System;
namespace AdivinarNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            String respuesta = "S";

            while (respuesta.ToUpper() == "S")
            {
                int numeroRamdon = aleatorio.Next(1, 101);
                bool adivino = false;
                int intentos = 0;

                while(intentos < 10 && !adivino)
                {
                    Console.Write("Ingrese un numero: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    intentos++;

                    if (numero > numeroRamdon)
                    {
                        Console.WriteLine("Demasiado alto");
                    }
                    else if (numero < numeroRamdon)
                    {
                        Console.WriteLine("Demasiado bajo");
                    }
                    else
                    {
                        Console.WriteLine("Felicidades, adivinaste el numero");

                        Console.WriteLine($"Cantidad de intentos: {intentos}");
                        adivino = true;
                    }
                }

                if (!adivino)
                {
                    Console.WriteLine("Game Over");
                    Console.WriteLine($"El numero correcto era: {numeroRamdon}");
                }
                Console.Write("Desea jugar de nuevo? (Y/N): ");
                respuesta = Console.ReadLine();
            }
            Console.WriteLine("Gracias por jugar");
        }
        
    }
}
