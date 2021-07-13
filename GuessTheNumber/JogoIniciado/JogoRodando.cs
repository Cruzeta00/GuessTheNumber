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
                int novoChute;
                bool eUmNumero = int.TryParse(Console.ReadLine(), out novoChute);
                if (eUmNumero)
                {
                    numeroChutado = novoChute;
                    if (numeroChutado == numeroGerado)
                    {
                        tempoCorrido.Stop();
                        Console.WriteLine($"PARABÉNS!!! Você acertou o meu número pensado em {tempoCorrido.Elapsed.TotalSeconds} segundos. Será que da para bater " +
                            $"o seu tempo?");
                        Console.WriteLine("Gostaria de jogar novamente? 0 - SIM, 1 - NÃO");
                        Console.WriteLine("0 - SIM");
                        Console.WriteLine("1 - NÃO");
                        int.TryParse(Console.ReadLine(), out int jogarNovamenteVitoria);
                        if (jogarNovamenteVitoria == 0) Jogo.InicializarJogo();
                        if (jogarNovamenteVitoria == 1) return;
                    }
                    else if (numeroChutado < numeroGerado) Console.WriteLine("Muito baixo");
                    else if (numeroChutado > numeroGerado) Console.WriteLine("Muito Alto");
                }
                else Console.WriteLine("Então... Você precisa acertar um número. Que tal tentar com valores númericos dessa vez?");
            }
            Console.WriteLine($"Tempo esgotado. Não foi dessa vez, amigo. O número gerado era o {numeroGerado}.");
            Console.WriteLine("Gostaria de jogar novamente?");
            Console.WriteLine("0 - SIM");
            Console.WriteLine("1 - NÃO");
            int.TryParse(Console.ReadLine(), out int jogarNovamente);
            if (jogarNovamente == 0) Jogo.InicializarJogo();
            if (jogarNovamente == 1) return;
        }
    }
}
