using FeTrans.Classes;
using System;

namespace FeTrans
{
    class Program
    {
        static void Main(string[] args)
        {
            var peso = new Peso(3.0);

            peso.CalcularPeso();

            var patm = new Pressao();

            var result = peso.CalcularPeso(); ;

            Console.WriteLine(result);
           
        }
    }
}
