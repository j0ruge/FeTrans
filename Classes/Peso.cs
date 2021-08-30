using FeTrans.Classes;

namespace FeTrans
{
    public class Peso : IMassa, IPeso
    {
        public Peso() { }

        /// <summary>
        /// Define o peso de um elemento, informando sua massa em kg ao usar CalcularPeso().<br/>
        /// Resultado em Newton, N.
        /// </summary>
        /// <param name="massa"></param>
        public Peso(double massa)
        {
            this.massa = massa;
        }

        public const double GRAVITY = 9.81;

        public double massa { get; set; }
        public double peso { get; set; }

        public double CalcularPeso()
        {
            return this.peso = this.massa * GRAVITY;
        }

        public double CalcularPeso(double massa)
        {
            return this.peso = massa * GRAVITY;
        }

        public string PesoFormatado()
        {
            string peso = CalcularPeso().ToString();

            return $"{peso} N";
        }

    }
}
