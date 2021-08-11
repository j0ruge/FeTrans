using FeTrans.Classes;

namespace FeTrans
{
    public class Weight : IMass, IWeight
    {
        public Weight() { }

        public Weight(double mass)
        {
            this.mass = mass;
        }

        public double GRAVITY = 9.8;

        public double mass { get; set; }
        public double weight { get; set; }

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
