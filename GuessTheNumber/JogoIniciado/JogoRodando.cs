using GuessTheNumber.Enuns;
using System;
using System.Collections.Generic;
using System.Text;
using GuessTheNumber.Logicas;
using System.Diagnostics;

namespace GuessTheNumber.JogoIniciado
{
    public class JogoRodando
    {
        internal static void NovoJogo(Dificuldades dificuldadeSelecionada)
        {
            Stopwatch tempoCorrido = new Stopwatch();
            int numeroGerado = Aleatorio.GerarValorBaseadoEmDificuldade(dificuldadeSelecionada);
            int numeroChutado;
            tempoCorrido.Start();
            while (!Int32.TryParse(Console.ReadLine(), out numeroChutado))
            {
                Console.WriteLine("Valor Inválido.");
            }
            while (numeroChutado != numeroGerado || tempoCorrido.Elapsed.TotalSeconds <= 60)
            {
                if (numeroChutado == numeroGerado)
                {
                    tempoCorrido.Stop();
                    Console.WriteLine($"PARABÉNS!!! Você acertou com um total de {tempoCorrido.Elapsed.TotalSeconds} segundos.");
                    break;
                }
                else if (numeroChutado < numeroGerado) Console.WriteLine("Muito baixo");
                else if (numeroChutado > numeroGerado) Console.WriteLine("Muito Alto");
                Int32.TryParse(Console.ReadLine(), out int novoChute);
                numeroChutado = novoChute;
            }
        }
    }
}
