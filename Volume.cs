using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeTrans
{
    public class Volume 
    {
        public double volume { get; set; } // m^3
        public double length { get; set; } // m
        public double width { get; set; } // m
        public double height { get; set; } // m

        public Volume() { }

        public Volume(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double CalculateVolume()
        {
            return this.volume = this.length * this.width * this.height;
        }

        public string FormatedVolume()
        {
            string volume = CalculateVolume().ToString();

            return $"{volume} m^3";
        }


    }
}
