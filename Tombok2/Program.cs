using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tomb;
            //tomb = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            //int[] tomb = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            

            // Console.WriteLine(tomb[0]);
            //  Console.WriteLine(tomb[6]);

            //  Console.WriteLine(tomb.Length);
            // Console.WriteLine(tomb[tomb.Length -1]);

            // for (int i = 0; i < tomb.Length; i++)
            //{
            //    Console.WriteLine($"A(z) {i}.elem: { tomb[i]}");
            //}

            /*
             Visszafelé:   
            for (int i = tomb.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine($"A(z) {i}.elem: { tomb[i]}");
            }
            */



            //int i = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine($"A(z) {i}.elem: { tomb[i/* vagy i++ és a végére nem kell */]}");
            //    i++;
            //}



            int[] tomb = new int[10];
            // tomb[5] = 100; <-- 5. elem = 100
            Random veletlen = new Random();
            for (int i = 0; i < 10; i++)
            {
                tomb[i] = veletlen.Next(100);
            }
            /* Nem lehet megállítani, végigmegy az egész tömbön:*/
            foreach (/*var, ez a program működésén belül derül ki, lehet string is*/ int szam in tomb)
            {
                Console.WriteLine(szam);
            }

            Console.ReadKey();
        }
    }
}
