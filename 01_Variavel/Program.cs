using System;
using System.Text;

namespace _01_Variavel
{
    class Program
    {
        static void Main(string[] args)
        {
            byte meuByte;
            System.Byte meuByte2;

            meuByte = 1;
            meuByte2 = meuByte;
            sbyte meuSByte = -10;

            Console.WriteLine("Digite um numero");

            string meuByteLido = Console.ReadLine();

            Console.WriteLine(meuByte2 + "  " + meuByteLido + "  " +meuSByte);
            
        }
    }
}
