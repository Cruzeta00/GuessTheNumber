using System;
using System.Collections.Generic;
using System.Text;
using GuessTheNumber.JogoIniciado;
using GuessTheNumber.Enuns;

namespace GuessTheNumber.Logicas
{
    public class Jogo
    {
        public static void InicializarJogo()
        {
            Console.WriteLine("###REGRAS###");
            Console.WriteLine("O jogo consiste em advinhação. Testaremos a sua sorte em acertar números gerados aleatoriamente.");
            Console.WriteLine("Ou seja. Você deve tentar até ter sucesso ou perder por tempo finalizado.");
            Console.WriteLine("Um número é gerado e você precisa digitar esse número e apertar ENTER.");
            Console.WriteLine("Caso o número digitado seja menor que o gerado, você receberá um indicativo <.");
            Console.WriteLine("Caso contrário, receberá o > que indica que seu número é maior que o gerado.");
            Console.WriteLine("As seguintes dificuldades estão disponíveis: Fácil, Médio, Díficil, Insano e IMPOSSÍVEL");
            Console.WriteLine("Basta você digitar um número para selecionar a dificuldade, no exemplo a seguir:");
            Console.WriteLine("0 - Fácil");
            Console.WriteLine("1 - Médio");
            Console.WriteLine("2 - Difícil");
            Console.WriteLine("3 - Insano");
            Console.WriteLine("4 - IMPOSSÍVEL");
            int dificuldade;
            while (!Int32.TryParse(Console.ReadLine(), out dificuldade))
            {
                Console.WriteLine("Valor Inválido.");
            }
            Funcionalidades.DificuldadeSelecionada(dificuldade);
        }
    }
}
