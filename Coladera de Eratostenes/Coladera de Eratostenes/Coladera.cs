using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera_de_Eratostenes
{
    class Coladera
    {
        // static  StringBuilder builder;
        static string a;

        static void iniciar()
        {
            int n = 1001; // número máximo hasta el que se quiere calcular
            bool[] marcados = new bool[n+1];
            StringBuilder builder = new StringBuilder();

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (!marcados[i])
                    for (int j = i * 2; j <= n; j += i)
                        marcados[j] = true; // se marcan los que se sabe que NO son primos
            }

            for (int i = 2; i < marcados.Length; i++)
                if (marcados[i] == false) // los primos son los que no están marcados
                   builder.Append(i + ", ");
            builder.Length -= 2;
            a = builder.ToString();

        }
        public void star (){
            iniciar();
        }

        public override string ToString()
        {
            return a;
        }

    }
}
