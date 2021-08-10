using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeTrans
{
    public class Density : Volume
    {
        public double density { get; set; } // kg/m^3
        public double mass { get; set; } // kg

        public IDictionary<string, double> densityDictionary = new Dictionary<string, double>();

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
