using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_1b
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mata in ett heltal:");

           int numb = int.Parse(Console.ReadLine());

            string test = numb.ToString();

            List<int> list = new List<int>();// skapar list 

            int nollor = 0;
            int udda = 0;
            int jemn = 0;


            foreach (char c in test)// loopar i genom string och får char värdet av varige string   
            {
                list.Add((int)Char.GetNumericValue(c));// omvandlar från char till int 
            }

            for (int i = 0; i < list.Count; i++) // Loop igenom lista
            {
           
                if (list[i] == 0)
                {
                    // noll
                    nollor++;
                }
               
                else if ((list[i] % 2) == 0)
                {
                    // jämna
                    jemn++;
                }
                else
                {
                    // udda
                    udda++;
                } 
            }

            Console.WriteLine("Nollor: {0} Udda: {1} Jämna: {2}", nollor, udda, jemn);
         
        }

    }
}
