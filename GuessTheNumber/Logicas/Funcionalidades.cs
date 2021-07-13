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
                    Console.WriteLine("Você selecionou a dificuldade fácil. Você tem, apartir de agora, 60 segundos para descobrir o número qual eu pensei! " +
                        "Se você não acertar, acho melhor desistir. Os números variam de 0 a 99");
                    JogoRodando.NovoJogo(Dificuldades.Facil);
                    break;

                case 1:
                    Console.WriteLine("Você selecionou a dificuldade médio. Você tem, apartir de agora, 60 segundos para descobrir o número qual eu pensei! " +
                        "Bem simples. Vai do 0 ao 999");
                    JogoRodando.NovoJogo(Dificuldades.Medio);
                    break;

                case 2:
                    Console.WriteLine("Você selecionou a dificuldade difícil. Você tem, apartir de agora, 60 segundos para descobrir o número qual eu pensei! " +
                        "Os números vão de 0 a 999998");
                    JogoRodando.NovoJogo(Dificuldades.Dificil);
                    break;
                case 3:
                    Console.WriteLine("Você selecionou a dificuldade insano. Você tem, apartir de agora, 2 minutos para descobrir o número qual eu pensei!" +
                        " A dica que eu darei é, 6895432 éta 0 eD");
                    JogoRodando.NovoJogo(Dificuldades.Insano);
                    break;
                case 4:
                    Console.WriteLine("Você selecionou a dificuldade IMPOSSÍVEL. Amigo... você tem 2 minutos para procurar um número que vai de: -2345987 até 2345998." +
                        " Muito boa sorte.");
                    JogoRodando.NovoJogo(Dificuldades.IMPOSSIVEL);
                    break;
                default:
                    throw new Exceptions.DificuldadeInvalidaException();
            }
        }
    }
}