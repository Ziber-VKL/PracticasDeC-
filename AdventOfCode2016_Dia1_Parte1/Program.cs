using System;
namespace AdventOfCode2016_Dia1_Parte1;

internal class Program
{
    static void Main(string[] args)
    {
        string input = File.ReadAllText("input.txt");
        string[] instrucciones = input.Split(", ");

        int x = 0;
        int y = 0;
        int direccion = 0;

        foreach (string instruccion in instrucciones)
        {
            char giro = instruccion[0];
            int distancia = int.Parse(instruccion.Substring(1));

            if (giro == 'R')
            {
                direccion = (direccion + 1) % 4;
            }
            else if (giro == 'L')
            {
                direccion = (direccion + 3) % 4;
            }

            switch (direccion)
            {
                case 0:
                    y += distancia;
                    break;

                case 1:
                    x += distancia;
                    break;

                case 2:
                    y -= distancia;
                    break;

                case 3:
                    x -= distancia;
                    break;
            }
        }

        int respuesta = Math.Abs(x) + Math.Abs(y);

        Console.WriteLine(respuesta);

    }
}
