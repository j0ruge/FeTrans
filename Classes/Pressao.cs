
namespace FeTrans.Classes
{
    public class Pressao
    {
        public double PressaoAbsoluta { get; set; }
        public double PressaoAtmosferica { get; set; }
        public double PressaoManometrica { get; set; }

        Density density = new Density();
        

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

        public double CalcularPressaoAtmosferica(double PressaoManometrica, double PressaoAbsoluta)
        {
            return PressaoManometrica - PressaoAbsoluta;

        }



        public double CalcularPressaoAtmosferica(string nomeMaterialComDensidadeTabelada, double alturaFornecida)
        {
            double GRAVIDADE = Peso.GRAVITY;

            return  density.densityDictionary[nomeMaterialComDensidadeTabelada] * GRAVIDADE * alturaFornecida;

        }

    }
}
