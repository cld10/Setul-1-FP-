using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercitiul 1
            Console.WriteLine("Exercitiul 1.");
            Console.WriteLine("Introduceti variabila a:");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti variabila b:");
            double b = int.Parse(Console.ReadLine());
            double x;
            x = -b / a;
            Console.WriteLine($"Pentru ecuatia ax+b=0 solutia este :{x}");
            Console.ReadLine();

            //Exercitiul 2
            Console.WriteLine("Exercitiul 2.");
            Console.WriteLine("Introduceti variabila a:");
            double d = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti variabila b:");
            double e = int.Parse(Console.ReadLine());
            Console.WriteLine("Inttroduceti varabila c:");
            double f = int.Parse(Console.ReadLine());
            double delta;
            delta = e * e - 4 * d * f;
            if (delta > 0)
            {
                double x1, x2;
                x1 = (-e + Math.Sqrt(delta)) / 2 * d;
                x2 = (-e - Math.Sqrt(delta)) / 2 * d;
                Console.WriteLine($"Solutiile ecuatiei ax^2 + bx + c = 0 sunt: {x1} si {x2}");
                Console.ReadLine();
            }
            else
            {
                if (delta == 0)
                {
                    double x3;
                    x3 = -e / 2 * d;
                    Console.WriteLine($"Delta este egala cu 0, ecuatia ax^2 + bx + c = 0 are o singura solutie:{x3}");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ecuatia ax^2 + bx + c = 0 nu are solutii reale.");
                    Console.ReadLine();
                }
            }

            // Exercitiul 3
            Console.WriteLine("Exercitiul 3.");
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul k:");
            int k = int.Parse(Console.ReadLine());
            if (n % k != 0)
            {
                Console.WriteLine("Numarul n se divide cu k");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Numarul n nu se divide cu k ");
                Console.ReadLine();
            }

            // exercitiul 4
            Console.WriteLine("Exercitiul 4.");
            Console.WriteLine("Introduceti anul:");
            int an = int.Parse(Console.ReadLine());
            if (an % 400 == 0 || (an % 4 == 0 && an % 100 != 0)) //un an este bisect daca se divide cu 400 sau se divide cu 4 si nu se divide cu 100
            {
                Console.WriteLine("Anul este bisect.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Anul nu este bisect.");
                Console.ReadLine();
            }
            // exercitiul 5
            Console.WriteLine("Exercitiul 5.");
            Console.WriteLine("Introduceti numarul:");
            int nr = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti pozitia:");
            int poz = int.Parse(Console.ReadLine());
            int i = 0;
            while (nr != 0)
            {
                i++;
                if (i == poz)
                {
                    Console.WriteLine($"Numarul extras este:{nr % 10}");
                    Console.ReadLine();
                }
                nr = nr / 10;
            }
            // exercitiul 6
            Console.WriteLine("Exercitiul 6.");
            Console.WriteLine("Introduceti cele trei numere:");
            int l1 = int.Parse(Console.ReadLine());       //trei numere pot fi lungimile laturilot unui triunghi daca ele sunt pozitive si suma a oricare doua dintre ele sa fie mai mare decat a treia latura
            int l2 = int.Parse(Console.ReadLine());
            int l3 = int.Parse(Console.ReadLine());
            if ((l1 + l2 > l3) && (l1 + l3 > l2) && (l2 + l3 > l1))
            {
                Console.WriteLine("Cele trei numere pot fi lungimile laturilor unui triunghu.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Cele trei numere NU pot fi lungimile laturilor unui triunghu.");
                Console.ReadLine();
            }
            // exercitiul 7
            Console.WriteLine("Exercitiul 7.");
            Console.WriteLine("Introduceti cele doua numere pe care doriti sa le inversati:" + "a=");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int nr2 = int.Parse(Console.ReadLine());
            int aux = nr1;
            nr1 = nr2;
            nr2 = aux;
            Console.WriteLine($"In urma interschimbarii a={nr1} si b={nr2}");
            Console.ReadLine();

            // exercitiul 8
            Console.WriteLine("Exercitiul 8.");
            Console.WriteLine("Introduceti cele doua numere pe care doriti sa le inversati:" + "a=");
            int nr3 = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int nr4 = int.Parse(Console.ReadLine());
            nr3 = nr3 * nr4;
            nr4 = nr3 / nr4;
            nr3 = nr3 / nr4;
            Console.WriteLine($"In urma interschimbarii a={nr3} si b={nr4}");
            Console.ReadLine();

            // exercitiul 9
            Console.WriteLine("Exercitiul 9.");
            Console.WriteLine("Introduceti numarul n:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Divizorii numarului sunt:");
            for (int div1 = 1; div1 < n1; div1++)
            {
                if (n1 % div1 == 0)
                {
                    Console.WriteLine(div1);
                }
            }
            Console.ReadLine();

            // exercitiul 10
            Console.WriteLine("Exercitiul 10.");
            Console.WriteLine("Introduceti numarul n:");
            int n2=int.Parse(Console.ReadLine());
            int k1 = 0;
            for(int div2=2; div2<n2/2; div2++)
            {
                if(n2 % div2 == 0) { k1++; }
            }
            if (k1 == 0)
            {
                Console.WriteLine("Numarul introdus este prim.");
            }
            else
            {
                Console.WriteLine("Numarul introdus NU este prim ");
            }
            Console.ReadLine();

        }
    }
}
