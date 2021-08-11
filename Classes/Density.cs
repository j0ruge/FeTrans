using FeTrans.Classes;
using System.Collections.Generic;

namespace FeTrans
{
    public class Density : IDensity, IVolume, IMass
    {

        public IDictionary<string, double> densityDictionary = new Dictionary<string, double>();

        public double density { get; set; }
        public double volume { get; set; }
        public double mass { get; set; }

        public Density()
        {
            UseDensityDictionary();
        }

        public Density(double mass, double volume)
        {
            this.mass = mass;
            this.volume = volume;
        }

        public void UseDensityDictionary()
        {
            densityDictionary.Add("water", 1000);
            densityDictionary.Add("air", 1.2);
        }

        public double CalculateDensity()
        {
            this.density = mass / volume;

            return density;
        }

        public string FormatedDensity()
        {
            string density = CalculateDensity().ToString();

            return $"{density} kg/m^3";
        }

        /// TODO: ρ = dm/dV

    }
}
