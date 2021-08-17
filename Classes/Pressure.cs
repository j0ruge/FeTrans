using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeTrans.Classes
{
    public class Pressure
    {
        public double PressaoAbsoluta { get; set; }
        public double PressaoAtmosferica { get; set; }
        public double PressaoManometrica { get; set; }

        // O valor sendo vácou devemos usar sinal negativo. 
        public double CalcularPressaoAbsoluta(double PressaoAtmosferica, double PressaoManometrica)
        {
            return PressaoAtmosferica + PressaoManometrica;
        }

        public string PressaoAbsolutaValorFormatado(double PressaoAtmosferica, double PressaoManometrica)
        {
            string result = CalcularPressaoAbsoluta(PressaoAtmosferica, PressaoManometrica).ToString();

            return $"{result} psi";
        }

    }
}
