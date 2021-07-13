using GuessTheNumber.Enuns;
using System;
using System.Collections.Generic;
using System.Text;
using GuessTheNumber.Logicas;
using System.Diagnostics;
using GuessTheNumber.Global;

namespace GuessTheNumber.JogoIniciado
{
    public class JogoRodando
    {
        internal static void NovoJogo(Dificuldades dificuldadeSelecionada)
        {
            Stopwatch tempoCorrido = new Stopwatch();
            int numeroGerado = Aleatorio.GerarValorBaseadoEmDificuldade(dificuldadeSelecionada);
            int tempoDificuldade = Tempos.RetornarTempo(dificuldadeSelecionada);
            int numeroChutado;
            tempoCorrido.Start();
            Console.WriteLine("VALENDO!!");
            while (tempoCorrido.Elapsed.TotalSeconds <= tempoDificuldade)
            {
                double tempoFixoEmSegundos = tempoCorrido.Elapsed.TotalSeconds;
                bool eUmNumero = int.TryParse(Console.ReadLine(), out int novoChute);
                if (eUmNumero)
                {
                    numeroChutado = novoChute;
                    if (numeroChutado == numeroGerado)
                    {
                        tempoCorrido.Stop();
                        Console.WriteLine($"PARABÉNS!!! Você acertou o meu número pensado em {Math.Round(tempoCorrido.Elapsed.TotalSeconds, 0)} segundos." +
                            "Será que da para bater o seu tempo?");
                        JogarNovamente.ReiniciarOJogo();
                    }
                    else if (numeroChutado < numeroGerado) Console.WriteLine($"Muito baixo. Tempo restante: {Math.Round(tempoDificuldade - tempoFixoEmSegundos, 0)}");
                    else if (numeroChutado > numeroGerado) Console.WriteLine($"Muito Alto. Tempo restante: {Math.Round(tempoDificuldade - tempoFixoEmSegundos, 0)}");
                }
                else Console.WriteLine("Então... Você precisa acertar um número. Que tal tentar com valores númericos dessa vez?");
            }
            Console.WriteLine($"Tempo esgotado. Não foi dessa vez, amigo. O número gerado era o {numeroGerado}.");
            JogarNovamente.ReiniciarOJogo();
        }
    }
}
