using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
namespace Dia_7_AoC_2015_3_P2;

internal class Program
{
    static void Main(string[] args)
    {
        string input = File.ReadAllText("input.txt");

        int santaX = 0;
        int santaY = 0;

        int robotX = 0;
        int robotY = 0;

        HashSet<string> visitadas = new HashSet<string>();

        visitadas.Add("0,0");

        for(int i = 0; i < input.Length; i++)
        {
            char cambio = input[i];

            if(i % 2 == 0)
            {
                switch (cambio)
                {
                    case '^':
                        santaY++;
                        break;

                    case 'v':
                        santaY--;
                        break;

                    case '>':
                        santaX++;
                        break;

                    case '<':
                        santaX--;
                        break;
                }
                visitadas.Add($"{santaX},{santaY}");
            }
            else
            {
                switch (cambio)
                {
                    case '^':
                        robotY++;
                        break;

                    case 'v':
                        robotY--;
                        break;

                    case '>':
                        robotX++;
                        break;

                    case '<':
                        robotX--;
                        break;
                }
                visitadas.Add($"{robotX},{robotY}");
            }
        }
        WriteLine(visitadas.Count);
    }
}
