using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio20
{
    static class Validacao
    {
        public static string ValidaNomes(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome Invalido!");

            }
            return nome;

        }

        public static double ValidaDadosdouble(double dados)
        {
            if (Convert.ToDouble(dados) < 0)
            {
                throw new Exception("Numeros invalidos");
            }
            return dados;
        }

        public static int Validainteiros(int dados)
        {
            if (Convert.ToInt32(dados) < 0)
            {
                throw new Exception("Numeros invalidos");
            }
            return dados;
        }

        public static int ValidaPortas(int dados)
        {
            if(dados<2 || dados > 4)
            {
                throw new Exception("Numero de portas invalidas!");
            }
            return dados;
        }


    }
}
