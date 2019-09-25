using System;
using System.Collections.Generic;
using System.Text;

namespace NovidadesCSharp73_80
{
    struct GeoLocalizacao
    {
        public double latitude;
        public double longitude;
    }

    public class ReadtribuicaoEmRefs
    {
		public long DistanciaDeSaoPauloParaRioDeJaneiro()
        {
            var saoPaulo = new GeoLocalizacao() { latitude = 1, longitude = 2 };
            var rioDeJaneiro = new GeoLocalizacao() { latitude = 1, longitude = 2 };

            return CalculaDistancia(ref saoPaulo, ref rioDeJaneiro);
        }

        long CalculaDistancia(ref string partida, ref GeoLocalizacao destino)
        {
            var a = "asdjhaskdjhakjsdhasd";
            
            // partida = ref destino;
            return 1;
        }
    }
}
