using System;
using System.Security.Cryptography;
using System.Text;
namespace Dia4_AoC_2015;

internal class Program
{
    static void Main(string[] args)
    {
        string puzzleKey = "yzbqklnj";

        using MD5 mD5 = MD5.Create();

        int numero = 1;

        while (true)
        {
            string input = puzzleKey + numero;

            byte[] bytes = Encoding.UTF8.GetBytes(input);

            byte[] hash = mD5.ComputeHash(bytes);

            string hashString = Convert.ToHexString(hash).ToLower();

            if (hashString.StartsWith("000000"))
            {
                Console.WriteLine($"{numero}");
                break;
            }
         numero++;
        }
    }
}
