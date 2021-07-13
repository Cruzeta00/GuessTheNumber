using GuessTheNumber.Enuns;
using System;
using System.Collections.Generic;
using System.Text;
using GuessTheNumber.Logicas;

namespace GuessTheNumber.JogoIniciado
{
    public class JogoRodando
    {
        internal static void NovoJogo(Enum numeroGerado)
        {
            //var numeroGerado = Aleatorio.GerarValorBaseadoEmDificuldade(Enum.GetValues(typeof(Dificuldades)).GetValue(dificuldade));
            int numeroChutado = Convert.ToInt32(Console.ReadLine());
            while (numeroChutado != numeroGerado)
            {
                int novoChute = Convert.ToInt32(Console.ReadLine());
                numeroChutado = novoChute;
                if (numeroChutado == numeroGerado)
                {
                    Console.WriteLine("PARABÉNS!!! Você acertou com um total de chutes.");
                    break;
                }
                else if (numeroChutado < numeroGerado) Console.WriteLine("<");
                else if (numeroChutado > numeroGerado) Console.WriteLine(">");
            }
        }
    }
}
