
namespace FiguraGeometrica
{
    /// <summary>This class defines the area calculations for a circle of radius r</summary>
    public class Circulo : FiguraGeometrica
    {
        private readonly float RaioDoCirculoEmUM;

        public Circulo(string nomeDaFigura,
                        float raio) : base(nomeDaFigura)
        {
            if(raio <= 0)
            {
                throw new ArgumentException($"Argumento '{nameof(raio)}'={raio} inválido!");
            }
            RaioDoCirculoEmUM = raio;
        }

        public float CalcularArea()
        {
            return (float)Math.PI * (RaioDoCirculoEmUM * RaioDoCirculoEmUM);
        }
    }
}
