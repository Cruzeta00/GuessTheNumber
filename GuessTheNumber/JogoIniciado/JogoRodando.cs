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
            while (!Int32.TryParse(Console.ReadLine(), out numeroChutado))
            {
                Console.WriteLine("Valor Inválido.");
            }
            while (tempoCorrido.Elapsed.TotalSeconds <= tempoDificuldade)
            {
                if (numeroChutado == numeroGerado)
                {
                    tempoCorrido.Stop();
                    Console.WriteLine($"PARABÉNS!!! Você acertou com um total de {tempoCorrido.Elapsed.TotalSeconds} segundos.");
                    Console.WriteLine("Gostaria de jogar novamente? 0 - SIM, 1 - NÃO");
                    Console.WriteLine("0 - SIM");
                    Console.WriteLine("1 - NÃO");
                    int jogarNovamente;
                    Int32.TryParse(Console.ReadLine(), out jogarNovamente);
                    if (jogarNovamente == 0) NovoJogo(dificuldadeSelecionada);
                    if (jogarNovamente == 1) return;
                }
                else if (numeroChutado < numeroGerado) Console.WriteLine("Muito baixo");
                else if (numeroChutado > numeroGerado) Console.WriteLine("Muito Alto");
                Int32.TryParse(Console.ReadLine(), out int novoChute);
                numeroChutado = novoChute;
            }
            Console.WriteLine($"Tempo esgotado. Não foi dessa vez, amigo. O número gerado era o {numeroGerado}.");
        }
    }
}
