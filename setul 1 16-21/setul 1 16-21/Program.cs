using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul_1_16_21
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
            /*//exercitiul 16
            Console.WriteLine("Exercitiul 16.");
            Console.WriteLine(" Introduceti cele 5 numere: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            if (a > b) SwapNum(ref a, ref b);
            if (a > c) SwapNum(ref a, ref c);
            if (a > d) SwapNum(ref a, ref d);
            if (a > e) SwapNum(ref a, ref e);
            if (b > c) SwapNum(ref b, ref c);
            if (b > d) SwapNum(ref b, ref d);
            if (b > e) SwapNum(ref b, ref e);
            if (c > d) SwapNum(ref c, ref d);
            if (c > e) SwapNum(ref c, ref e);
            if (d > e) SwapNum(ref d, ref e);
            Console.WriteLine($"Numerele in ordine crescatoare sunt: {a}, {b}, {c}, {d}, {e}");
            Console.ReadLine();

            //exercitiul 17 
            Console.WriteLine("Exercitiul 17.");
            Console.WriteLine("Introduceti cele doua numere:");
            int n=int.Parse(Console.ReadLine());
            int m=int.Parse(Console.ReadLine());
            int copie_n = n, copie_m=m;

            while (n != m)
            {
                if (n > m)
                {
                    n=n-m;
                }
                else
                {
                    m=m-n;
                }
            }
            Console.WriteLine($"Cel mai mare divizor comun al celor doua numere este {n}");
            int cmmmmc=(copie_n*copie_m)/n;
            Console.WriteLine($"Cel mai mic multiplu comun al celor doua numere este {cmmmmc}");
            Console.ReadLine() ;*/

            // exercitiul 18
            Console.WriteLine("Exercitiul 18");
            Console.WriteLine("Introduceti numarul:");
            int x=int.Parse(Console.ReadLine());
            int p, div=2;
            Console.WriteLine($"Descompunerea in factori primi a numarului este: ");
            while (x != 1)
            {
                p = 0;
                while (x % div == 0)
                {
                    p++;
                    x /= div;
                }
                if (p!=0)  Console.Write($"{div}^{p}x");
                    div++;
            }
            Console.ReadLine();

            //exercitiul 19
            Console.WriteLine("Exercitiul 9");
            Console.WriteLine("Introduceti numarul");
            int nr=int.Parse(Console.ReadLine());
            int v[] =in;
        }
    }
}
