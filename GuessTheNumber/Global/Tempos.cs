using GuessTheNumber.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber.Global
{
    public static class Tempos
    {
        public const int TEMPO_FACIL = 60;
        public const int TEMPO_MEDIO = 60;
        public const int TEMPO_DIFICIL = 120;
        public const int TEMPO_INSANO = 120;
        public const int TEMPO_IMPOSSIVEL = 120;

        public static int RetornarTempo(Dificuldades dificuldade)
        {
            int facilidade = Convert.ToInt32(dificuldade);
            switch (facilidade)
            {
                case 0:
                    return TEMPO_FACIL;
                case 1:
                    return TEMPO_MEDIO;
                case 2:
                    return TEMPO_DIFICIL;
                case 3:
                    return TEMPO_INSANO;
                case 4:
                    return TEMPO_IMPOSSIVEL;
                default:
                    throw new Exceptions.DificuldadeInvalidaException();
            }
        }
    }
}
