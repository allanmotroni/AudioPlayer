using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioPlayer
{
    public static class Constantes
    {
        public static string REPRODUZINDO = "reproduzindo";
        public static string PARADO = "parado";
        public static string EM_PAUSA = "em pausa";
        public static string ALTERANDO_MIDIA = "alterando mídia...";
        public static string PRONTO = "pronto";
        public static string CONCLUIDO = "concluído";
        public static string MIDIA_ABERTA = "mídia aberta";
        public static string CONECTANDO_SE = "conectando-se";

        //Velocidades de reprodução Pré-definidas
        public static double VELOCIDADE_LENTA = 0.6;
        public static double VELOCIDADE_NORMAL = 1.0;
        public static double VELOCIDADE_RAPIDA = 1.2;

        public enum TEMPO { INICIAL, FINAL }        
    }
}
