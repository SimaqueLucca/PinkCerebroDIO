using System;

namespace PinkCerebroDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeEntradas = int.Parse(Console.ReadLine());
            string[] entradas = Console.ReadLine().Split(" ");

            int multiDois = 0, multiTres = 0, multiQuatro = 0, multiCinco = 0;


            for (int i = 0; i < quantidadeEntradas; i++)
            {
                int multiplo = int.Parse(entradas[i]);

                if (multiplo % 2 == 0)
                {
                    multiDois++;
                }
                if (multiplo % 3 == 0)
                {
                    multiTres++;
                }
                if (multiplo % 4 == 0)
                {
                    multiQuatro++;
                }
                if (multiplo % 5 == 0)
                {
                    multiCinco++;
                }
            }

            Console.WriteLine("{0} Multiplo(s) de 2", multiDois);
            Console.WriteLine("{0} Multiplo(s) de 3", multiTres);
            Console.WriteLine("{0} Multiplo(s) de 4", multiQuatro);
            Console.WriteLine("{0} Multiplo(s) de 5", multiCinco);
        }
    }
}
