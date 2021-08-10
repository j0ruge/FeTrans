namespace FeTrans
{
    public class Weight : Classes.Parameters
    {
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
