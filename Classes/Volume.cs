using FeTrans.Classes;

namespace FeTrans
{
    public class Volume : IVolume, IParameters
    {


        public Volume() { }

        public Volume(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double volume { get; set; }
        public double length { get; set; }
        public double width { get; set; }
        public double height { get; set; }

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
