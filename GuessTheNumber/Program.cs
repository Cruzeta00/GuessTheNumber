using System;
using GuessTheNumber.Logicas;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao GuessTheNumber!");
            Console.WriteLine("Digite 1 para começar");
            int iniciar;
            while (true)
            {
                try
                {
                    iniciar = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor Inválido.");
                }
            }
            if (iniciar == 1)
            {
                try
                {
                    Jogo.InicializarJogo();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            Console.WriteLine("Fim de jogo. Pressione qualquer tecla para encerrar.");
            Console.ReadLine();
        }
    }
}
