﻿namespace FeTrans
{
    public class Mass : Density
    {
        
        public Mass()
        {
            
        }

        public Mass(double density, double volume) {

           
            this.density = density;
            this.volume = volume;        

        }

        public double CalculateMass()
        {
            mass = density * volume;
            return mass;

        }

        public string FormatedMass()
        {
            string mass = CalculateMass().ToString();

            return $"{mass} kg";
        }
    }
}