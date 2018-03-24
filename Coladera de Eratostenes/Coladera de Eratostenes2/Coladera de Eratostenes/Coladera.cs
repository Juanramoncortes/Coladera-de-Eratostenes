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
        static bool[] marcados;
        static int n = 1001;
       static StringBuilder builder;
        static void iniciar()
        {
            // número máximo hasta el que se quiere calcular
            builder = new StringBuilder();
            marcados = new bool[n + 1];

            Marcar();
            Revisar();

            builder.Length -= 2;
            a = builder.ToString();

        }
        static void Marcar()
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (!marcados[i])
                    for (int j = i * 2; j <= n; j += i)
                        marcados[j] = true; // se marcan los que se sabe que NO son primos
            }
        }
        static void Revisar()
        {
            for (int i = 2; i < marcados.Length; i++)
                if (marcados[i] == false) // los primos son los que no están marcados
                    builder.Append(i + ", ");

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
