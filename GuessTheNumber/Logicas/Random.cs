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
            int facilidade = Convert.ToInt32(dificuldades);
            Random valorGerado = new Random();
            int? retorno = null;
            switch (facilidade)
            {
                case 0:
                    retorno = valorGerado.Next(0, 100);
                    break;
                case 1:
                    retorno = valorGerado.Next(0, 1000);
                    break;
                case 2:
                    retorno = valorGerado.Next(0, 999999);
                    break;
                case 3:
                    retorno = valorGerado.Next(0, 2345987);
                    break;
                case 4:
                    retorno = valorGerado.Next(-2345987, 2345999);
                    break;
            }
            return (int)retorno;
        }
    }
}
