using FeTrans.Classes;

namespace FeTrans
{
    public class Mass : Density, IDefaultMethods
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

        public string FormatedValue()
        {
            string mass = CalculateMass().ToString();

            return $"{mass} kg";
        }
    }
}
