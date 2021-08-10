namespace FeTrans
{
    public class Volume : Classes.Parameters
    {


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
