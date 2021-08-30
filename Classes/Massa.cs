using FeTrans.Classes;

namespace FeTrans
{
    public class Massa : Density, IDefaultMethods
    {
        
        public Massa()
        {
            
        }

        override
        public double massa { get; set; }
        

        public Massa(double density, double volume) {

           
            this.density = density;
            this.volume = volume;        

        }

        public double CalculateMass()
        {
            this.massa = density * volume;
            return this.massa;

        }

        public string FormatedValue()
        {
            string mass = CalculateMass().ToString();

            return $"{mass} kg";
        }
    }
}
