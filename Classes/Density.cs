using FeTrans.Classes;
using System;
using System.Collections.Generic;

namespace FeTrans
{
    public class Density : IDensity, IVolume, IMassa
    {
        /// <summary>
        /// Return double value of material<br/>
        /// Ex.: densityDictionary["water"] will return tabelated value of 1000 in kg/m^3 unit
        /// </summary>
        public IDictionary<string, double> densityDictionary = new Dictionary<string, double>();

        public double density { get; set; }
        public double volume { get; set; }
        public virtual double massa { get; set; }

        private double tabulatedDensity { get; set; }

        public Density()
        {
            UseDensityDictionary();
        }

        public Density(double mass, double volume)
        {
            this.massa = mass;
            this.volume = volume;
        }

        /// <summary>
        /// Return the density by name of material in English
        /// </summary>
        private void UseDensityDictionary()
        {
            densityDictionary.Add("water", 1.00 * Math.Pow(10, 3));
            densityDictionary.Add("air", 1.2);
            densityDictionary.Add("ice", 0.92 * Math.Pow(10, 3));
            densityDictionary.Add("silver", 10.5 * Math.Pow(10, 3));
            densityDictionary.Add("mercury", 13.63 * Math.Pow(10, 3));
        }

        //public double ReturnTabulatedDensity(string materialName)
        //{
        //    if (densityDictionary.TryGetValue(materialName, out))
        //    {
        //        this.densityDictionary[materialName];
        //    }
            
        //}

        public double CalculateDensity()
        {
            this.density = massa / volume;

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
