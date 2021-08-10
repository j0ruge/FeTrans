using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeTrans
{
    public class Weight : Density
    {
        public double weight { get; set; }
        readonly public double GRAVITY = 9.8;

        public Weight()
        {

        }

        public Weight(double mass)
        {
            this.mass = mass;
        }

        public double CalculateWeight()
        {
            return this.weight = this.mass * GRAVITY;
        }

        public string FormatedWeight()
        {
            string weight = CalculateWeight().ToString();

            return $"{weight} N";
        }

    }
}
