using System;
using System.Collections.Generic;
using System.Text;
using GuessTheNumber.JogoIniciado;
using GuessTheNumber.Enuns;
using GuessTheNumber.Logicas;

namespace GuessTheNumber.Logicas
{
    public class Jogo
    {
        public static void InicializarJogo()
        {
            Console.WriteLine("Gostaria de ler as regras? 1 para SIM ou 0 para PULAR.");
            int regras;
            while (!int.TryParse(Console.ReadLine(), out regras))
            {
                Console.WriteLine("Valor Inválido. Digite 0 ou 1.");
            }
            if(regras == 0)
            {
                Console.WriteLine("Ok, sabichão. Boa sorte e escolha sua dificuldade.");
            }
            if (regras == 1)
            {
                Console.WriteLine("Sábia escolha! hahaha");
                Regras.ChamarRegras();
            }
            int dificuldade;
            while (true)
            {
                try
                {
                    while (!int.TryParse(Console.ReadLine(), out dificuldade))
                    {
                        Console.WriteLine("Valor Inválido.");
                    }
                    Funcionalidades.DificuldadeSelecionada(dificuldade);
                    break;
                }
                catch (Exceptions.DificuldadeInvalidaException)
                {
                    Console.WriteLine("Valor Inválido.");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
