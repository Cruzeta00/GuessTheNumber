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
            //int? retorno = null;
            switch (facilidade)
            {
                case 0:
                    return valorGerado.Next(0, 100);

                case 1:
                    return valorGerado.Next(0, 1000);

                case 2:
                    return valorGerado.Next(0, 999999);

                case 3:
                    return valorGerado.Next(0, 2345987);

                case 4:
                    return valorGerado.Next(-2345987, 2345999);

                default:
                    throw new Exception("Valor inválido");
            }
        }
    }
}
