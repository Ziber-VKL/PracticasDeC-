using System;
namespace AdvenOfCode2015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string instrucciones = File.ReadAllText("input.txt");
            int piso = 0;

           for (int i =0; i < instrucciones.Length; i++)
            {
                if (instrucciones[i] == '(')
                    piso++;

                else if (instrucciones[i] == ')')
                    piso--;

                if (piso == -1)
                {
                    Console.WriteLine(i + 1);
                    break;
                }

            }
        }
    }
}
