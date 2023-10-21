using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul_1_11_15
{
    internal class Program
    {
        static void SwapNum(ref int x, ref int y)
        {

            int tempswap = x;
            x = y;
            y = tempswap;
        }
        static void Main(string[] args)
        {
            //exercitiul 11
            Console.WriteLine("Exercitiul 11.");
            Console.WriteLine("Introduceti numarul:");
            int n = int.Parse(Console.ReadLine());
            int inv = 0;
            while (n != 0)
            {
                inv = inv * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine($"Numarul inversat este:{inv}");
            Console.ReadLine();

            // exercitiul 12
            Console.WriteLine("Exercitiul 12.");
            Console.WriteLine("Intrroduceti numarul n:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti capetele intervalului [a,b] ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int k = 0;
            for (int i = a; i <= b; i++)
            {
                if (m % i == 0)
                {
                    k++;
                }
            }
            Console.WriteLine($"Sunt {k} numere intregi care se divid cu n si apartin intervalului [a,b]");
            Console.ReadLine();

            // exercitiul 13
            Console.WriteLine("Exercitiul 13.");
            Console.WriteLine("Introduceti anii: ");
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int j = y1; j <= y2; j++)
            {
                if (j % 400 == 0 || (j % 4 == 0 && j % 100 != 0))
                {
                    cnt++;
                }
            }
            Console.WriteLine($"Sunt {cnt} de ani bisecti intre anii introdusi. ");
            Console.ReadLine();

            // exercitiul 14
            Console.WriteLine("Exercistiul 14.");
            Console.WriteLine("Introduceti numarul:");
            int x = int.Parse(Console.ReadLine());
            int oglindit = 0, copie = x;    //copiem valoarea lui x pentru ca in while isi va schimba valoarea
            while (x != 0)
            {
                oglindit = oglindit * 10 + x % 10;
                x /= 10;
            }

           if (oglindit == copie)
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul NU este palindrom");
            }
            Console.ReadLine();

            // exercitiul 15
            Console.WriteLine("Exercitiul 15.");
            Console.WriteLine("Introduceti cele 3 numere:");
            int c=int.Parse(Console.ReadLine());
            int d=int.Parse(Console.ReadLine());
            int e=int.Parse(Console.ReadLine());
            if(c>d) SwapNum(ref c, ref d);
            if(d>e) SwapNum(ref d, ref e);
            if (c>d) SwapNum(ref c, ref d);
            Console.WriteLine($"Cele trei numere in ordinea crescatoare sunt: {c}, {d}, {e}");
            Console.ReadLine();

        }
    }
}
