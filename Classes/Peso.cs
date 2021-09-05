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
        public double pesoAparente { get; set; }
        public double pesoReal { get; set; }
        public double empuxo { get; set; }

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

        /// <summary>
        /// P_A = P_r - E<br/>
        /// P_A é o peso aparente do corpo sólido, quando imerso no líquido.<br/>
        /// P_r é peso real apresentado pelo corpo sólido quando não está imerso no líquido;<br/>
        /// E é o empuxo;<br/>
        /// Resultado em Newton, N
        /// </summary>
        /// <param name="pesoReal"></param>
        /// <param name="empuxo"></param>
        /// <returns></returns>
        public double PesoAparente(double pesoReal, double empuxo)
        {
            return this.pesoAparente = pesoReal - empuxo;
        }


        /// <summary>
        /// E = P_r - P_A<br/>
        /// E é o empuxo;<br/>
        /// P_r é peso real apresentado pelo corpo sólido quando não está imerso no líquido;<br/>
        /// P_A é o peso aparente do corpo sólido, quando imerso no líquido.<br/>
        /// Resultado em Newton, N
        /// </summary>
        /// <param name="pesoReal"></param>
        /// <param name="pesoAparente"></param>
        /// <returns></returns>
        public double Empuxo(double pesoReal, double pesoAparente)
        {
            return this.empuxo = pesoReal - pesoAparente;
        }

        /// <summary>
        /// P_r = P_A - E<br/>
        /// P_r é peso real apresentado pelo corpo sólido quando não está imerso no líquido;<br/>
        /// P_A é o peso aparente do corpo sólido, quando imerso no líquido.<br/>
        /// E é o empuxo;<br/>
        /// Resultado em Newton, N
        /// </summary>
        /// <param name="pesoAparente"></param>
        /// <param name="empuxo"></param>
        /// <returns></returns>
        public double PesoReal(double pesoAparente, double empuxo )
        {
            return this.pesoReal = pesoAparente + empuxo;
        }


    }
}
