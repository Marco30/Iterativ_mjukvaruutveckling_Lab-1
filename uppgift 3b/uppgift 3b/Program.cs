using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            // test 1, provar om konstruktor och ToString
            Fraction B1 = new Fraction(4, 10);

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("test 1, provar om konstruktor och ToString\n");

            Console.WriteLine(B1.ToString());

            // test 2, testar om det är ett negativt bråktal
            Fraction B2 = new Fraction(-12, 3);

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("\ntest 2, testar om det är ett negativt bråktal\n");

            Console.WriteLine(B2.isNegative());

            // test 3, test 3, testar om bråktalen är lika
       
            Fraction B3 = new Fraction(5 , 5);
            Fraction B4 = new Fraction(5 , 5);

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("\ntest 3, testar om bråktalen är lika\n");

            Console.WriteLine(B3.isEqualTo(B4));

            // test 4, addera två bråktal 

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("\ntest 4, addera två bråktal");

            Fraction B5 = new Fraction(4, 10);
            Fraction B6 = new Fraction(6, 16);
            Fraction B7 = B6.add(B5);
            B7.minstaformen();
            Console.WriteLine(B7.ToString());

            // test 5, multiplicera två bråktal   

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("\ntest 4, multiplicera två bråktal");

            Fraction B8 = new Fraction(2,18);
            Fraction B9 = new Fraction(2,8);
            Fraction B10 = B9.multiply(B8);
            B10.minstaformen();
            Console.WriteLine(B10.ToString());

            Console.ReadKey();
        }
    }
}
