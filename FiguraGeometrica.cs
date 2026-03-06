using System.Text.RegularExpressions;

namespace FiguraGeometrica
{
    /// <summary>This class defines a base for Figuras Geométricas</summary>
    public class FiguraGeometrica
    {
        private readonly string NomeDaFigura;

        public FiguraGeometrica(string nomeDaFigura)
        {
            string sanitizedNomeDaFigura = SanitizeNomeDaFigura(nomeDaFigura: nomeDaFigura);

            if (!IsNomeDaFiguraValid(nomeDaFigura: sanitizedNomeDaFigura))
            {
                throw new ArgumentException($"Argumento '{nameof(nomeDaFigura)}'='{nomeDaFigura}' inválido!");
            }

            NomeDaFigura = nomeDaFigura;
        }

        private bool IsNomeDaFiguraValid(string nomeDaFigura)
        {
            if (string.IsNullOrEmpty(nomeDaFigura) ||
                string.IsNullOrWhiteSpace(nomeDaFigura))
            {
                return false;
            }

            return true;
        }

        private string SanitizeNomeDaFigura(string nomeDaFigura)
        {
            string pattern = @"[^\p{L}\s]";

            // Use Regex.Replace to remove the characters
            string sanitizedNomeDaFigura = Regex.Replace(nomeDaFigura, pattern, string.Empty);

            return sanitizedNomeDaFigura;
        }

        public string GetNomeDaFigura()
        {
            return NomeDaFigura;
        }

    }
}
