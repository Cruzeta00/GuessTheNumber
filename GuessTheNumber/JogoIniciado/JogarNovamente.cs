using GuessTheNumber.Logicas;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber.JogoIniciado
{
    public class JogarNovamente
    {
        public static void ReiniciarOJogo()
        {
            int jogarNovamenteVitoria;
            Console.WriteLine("Gostaria de jogar novamente?");
            Console.WriteLine("0 - SIM");
            Console.WriteLine("1 - NÃO");
            while (!int.TryParse(Console.ReadLine(), out jogarNovamenteVitoria))
            {
                Console.WriteLine("Valor Inválido. Digite 0 ou 1.");
            }
            if (jogarNovamenteVitoria == 0) Jogo.InicializarJogo();
            if (jogarNovamenteVitoria == 1) return;
        }
    }
}
