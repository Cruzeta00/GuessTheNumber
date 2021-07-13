using GuessTheNumber.Enuns;
using System;
using System.Collections.Generic;
using System.Text;
using GuessTheNumber.Logicas;

namespace GuessTheNumber.JogoIniciado
{
    public class JogoRodando
    {
        internal static void NovoJogo(Dificuldades dificuldadeSelecionada)
        {
            TimeSpan tempoCorrido = new TimeSpan();
            int numeroGerado = Aleatorio.GerarValorBaseadoEmDificuldade(dificuldadeSelecionada);
            int numeroChutado = Convert.ToInt32(Console.ReadLine());
            while (numeroChutado != numeroGerado || tempoCorrido.TotalSeconds <= 60)
            {
                if (numeroChutado == numeroGerado)
                {
                    Console.WriteLine("PARABÉNS!!! Você acertou com um total de chutes.");
                    break;
                }
                else if (numeroChutado < numeroGerado) Console.WriteLine("Muito baixo");
                else if (numeroChutado > numeroGerado) Console.WriteLine("Muito Alto");
                int novoChute = Convert.ToInt32(Console.ReadLine());
                numeroChutado = novoChute;
            }
        }
    }
}
