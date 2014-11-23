using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("palindrom\nskriv in text: ");
          
            string text1 = Console.ReadLine();

            char[] text2 = text1.ToCharArray();// skapar en char array som får texten som matat in 

            Array.Reverse(text2);// vänder på arrayen 

            string palindrom = new string(text2);// omvandlar array till string 

            if (text1 == palindrom)// kontrolerar om det är en palindrom
            {
                Console.WriteLine("texten är en palindrom");
            }
            else// om det inte är det så körs den här else satsen 
            {
                Console.WriteLine("texten är inte en palindrom");
            }
        }
    }
}
