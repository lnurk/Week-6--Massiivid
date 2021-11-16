using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't panic" nulliga - 0
            //programm asendab kõik 'a' tähed samas lauses 4-ga

            string dontP = "Don't panic!";

            /* for(int i = 0; i < dontP.Length; i++)
            {
                dontP[i] = '*'; //sõnad on muutumatu
            }*/

            dontP = dontP.Replace('o', '0');
            dontP = dontP.Replace('a', '4');
            Console.WriteLine(dontP);

        }
    }
}
