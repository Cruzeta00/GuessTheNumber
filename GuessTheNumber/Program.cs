using System;
using GuessTheNumber.Logicas;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao GuessTheNumber!");
            try
            {
                Jogo.InicializarJogo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Console.WriteLine("Fim de jogo. Pressione qualquer tecla para encerrar.");
            Console.ReadLine();
        }
    }
}
