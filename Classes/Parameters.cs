using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeTrans.Classes
{
    public abstract class Parameters
    {
        public double density { get; set; } // kg/m^3
        public double mass { get; set; } // kg
        public double volume { get; set; } // m^3
        public double length { get; set; } // m
        public double width { get; set; } // m
        public double height { get; set; } // m
        public double weight { get; set; }

        readonly public double GRAVITY = 9.8;
    }
}
