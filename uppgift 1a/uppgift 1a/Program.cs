using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_1a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv en mening så kommer programmet \natt hitta antal stora A och små a:");
            string test = Console.ReadLine(); 

            int A = 0;
            int a = 0;

            foreach (char c in test)// loopar i genom string och får char värdet av varige string   
            {
                if (c == 'A')//jämför om char värdet är lika med bokstaven A    
                {
                    A++;
                }

                else if (c == 'a')//jämför om char värdet är lika med bokstaven a 
                {
                    a++;
                }
            }

            Console.WriteLine("antal stora A: {0}\nantal små a: {1}",A , a);
        }
    }
}
