using static System.Console;
using System;
using System.IO;

namespace AdventOfCode2015_D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lineas = File.ReadAllLines("input.txt");
            int total = 0;

            foreach (string linea in lineas)
            {
                string[] lados = linea.Split('x');

                int l = int.Parse(lados[0]);
                int w = int.Parse(lados[1]);
                int h = int.Parse(lados[2]);

                int[] dimensiones = {l,w,h};
                Array.Sort(dimensiones);

                int lazo = (2 * dimensiones[0])+(2 * dimensiones[1]);

                int arena = l * w * h;

                total += lazo+arena;
                //int lado1 = l * w;
                //int lado2 = w * h;
                //int lado3 = h * l;

                //int area = (2*lado1)+(2*lado2)+(2*lado3);


                //int extra = Math.Min(lado1,Math.Min(lado2,lado3));

                //total += area + extra;
            }
            WriteLine(total);
        }
    }
}
