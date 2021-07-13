using GuessTheNumber.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber.Logicas
{
    public class Aleatorio
    {
        public static int GerarValorBaseadoEmDificuldade(Dificuldades dificuldades)
        {
            int facilidade = Convert.ToInt32(Enum.GetValues(typeof(Dificuldades)));
            Random valorGerado = new Random();
            switch (facilidade)
            {
                case 0:
                    valorGerado.Next(0, 100);
                    break;
                case 1:
                    valorGerado.Next(0, 1000);
                    break;
                case 2:
                    valorGerado.Next(0, 999999);
                    break;
                case 3:
                    valorGerado.Next(0, 2345987);
                    break;
                case 4:
                    valorGerado.Next(-2345987, 2345999);
                    break;
            }
            return Convert.ToInt32(valorGerado);
        }
    }
}
