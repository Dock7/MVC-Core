using System.Collections.Generic;

namespace HolaMundo.Services
{
    public class PaisRepositorioEnMemoria : IPaisRepositorioEnMemoria
    {
        public List<string> Obtenertodos()
        {
            List<string> paises = new List<string> { "España", "Portugal", "Francia", "Italia", "Alemania", "Inglaterra", "Grecia" };
            return paises;
        }
    }
}
