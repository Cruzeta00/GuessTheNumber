using GuessTheNumber.Enuns;
using GuessTheNumber.JogoIniciado;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber.Logicas
{
    public class Funcionalidades
    {
        internal static void DificuldadeSelecionada(int dificuldade)
        {

            switch (dificuldade)
            {
                case 0:
                    JogoRodando.NovoJogo(Dificuldades.Facil);
                    break;
                case 1:
                    JogoRodando.NovoJogo(Dificuldades.Medio);
                    break;
                case 2:
                    JogoRodando.NovoJogo(Dificuldades.Dificil);
                    break;
                case 3:
                    JogoRodando.NovoJogo(Dificuldades.Insano);
                    break;
                case 4:
                    JogoRodando.NovoJogo(Dificuldades.IMPOSSIVEL);
                    break;
                default:
                    Console.WriteLine("Escolha a dificuldade aqui.");
                    break;
            }
        }
    }
}