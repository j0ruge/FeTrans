using System;

namespace FeTrans
{
    class Program
    {
        static void Main(string[] args)
        {
            Density density = new Density();
            density.mass = 22.3;
            density.volume = 20.3;

            double result = density.CalculateDensity();

            var mass = new Mass(850.0, 2.0);
            string massResult = mass.FormatedValue();

            var volume = new Volume(4.0, 5.0, 3.0).CalculateVolume();

            var airDensity = density.densityDictionary["air"];


            var ex2Mass = new Mass(airDensity, volume);

            var ex2MassValue = ex2Mass.CalculateMass();

            var ex2AirWeight = new Weight(ex2MassValue);

            var ex2AirWeightValue = ex2AirWeight.CalculateWeight();

            Console.WriteLine(result);
            Console.WriteLine(density.FormatedDensity());
            Console.WriteLine(massResult);
            //Console.WriteLine(volume.FormatedVolume());
            Console.WriteLine(airDensity);
            Console.WriteLine(ex2MassValue);
            Console.WriteLine(ex2AirWeightValue);
            Console.WriteLine(Math.Pow(5,2));
        }
    }
}
