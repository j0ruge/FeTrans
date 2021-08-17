using FeTrans.Classes;
using System;

namespace FeTrans
{
    class Program
    {
        static void Main(string[] args)
        {
            var pabs = new Pressure();

            string resultado = pabs.PressaoAbsolutaValorFormatado(14.5, -5.8);

            Console.WriteLine(resultado);
        }
    }
}
