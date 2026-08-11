using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace Dia_7_AoC_2015_3;

internal class Program
{
    static void Main(string[] args)
    {
        string input = File.ReadAllText("input.txt");

        int x = 0;
        int y = 0;

        HashSet<string> visitadas = new HashSet<string>();

        visitadas.Add($"{x} {y}");

        foreach(char cambio in input)
        {
            switch(cambio)
            {
                case '^':
                    y++;
                    break;

                case 'v':
                    y--;
                    break;

                case '>':
                    x++;
                    break;

                case '<':
                    x--;
                    break;
            }

            visitadas.Add($"{x} {y}");
        }
        WriteLine(visitadas.Count);
    }
}
