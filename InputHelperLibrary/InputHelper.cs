using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputHelperLibrary
{
    public class InputHelper
    {
        public static int ReadInteger()
        {
            while (true)
            {
                string valor = Console.ReadLine();

                if (int.TryParse(valor, out int numero))
                {
                    return numero;
                }
                Console.WriteLine("Invalid value. Please try again.");
            }
        }

        public static double ReadDouble()
        {
            while (true)
            {
                string valor = Console.ReadLine();

                if(double.TryParse(valor,out double numero))
                {
                    return numero;
                }
                Console.WriteLine("Invalid value. Please try again.");
            }

        }

        public static string ReadNonEmptyString()
        {
            while (true)
            {
                string valor = Console.ReadLine();

                if (!string.IsNullOrEmpty(valor))
                {
                    return valor;
                }
                Console.WriteLine("Invalid value. Please try again.");
            }
        }
    }
}
