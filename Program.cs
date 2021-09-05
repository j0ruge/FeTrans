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


            //var pesoRealLido = 0.9091;
            var pesoRealLido = 1.3884;
            //var pesoAparenteLido = 0.4184;
            var pesoAparenteLido = 0.8977;
            

            //var result = peso.CalcularPeso();
            var empuxoCalculado = peso.Empuxo(pesoRealLido, pesoAparenteLido);
            var pesoAparenteCalculado = peso.PesoAparente(pesoRealLido, empuxoCalculado);
            var pesoRealCalculado = peso.PesoReal(pesoAparenteLido, empuxoCalculado);

            Console.WriteLine($"Empuxo Cálculado: {empuxoCalculado} N");
            Console.WriteLine($"Peso Aparente Cálculado: {pesoAparenteCalculado} N");
            Console.WriteLine($"Peso Real Cálculado: {pesoRealCalculado} N");

           
        }
    }
}
