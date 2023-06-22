using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cont = 0;
            double result = 0;

            do
            {
                cont++;
                result = result + cont;

            } while (cont < 100);

            Console.WriteLine("A Soma dos Números Inteiros Positivos no Intervalo de 1 a 100 é de: {0}", result);
        }
    }
}
