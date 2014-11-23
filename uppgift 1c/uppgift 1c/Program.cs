using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_1c
{
    class Program
    {
        static void Main(string[] args)
        {
            int test1 = 0;
            int test2 = 0;
            int bigest = 0;
            int secondbigest = 0;

            int meny = 0;

            int antal = 2;

            while(true )
            {

                Console.WriteLine("--------------------------------");
                Console.WriteLine("--------------Meny--------------");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1:välj antal siffror som ska mattas in\n2:kör programet\n3:avsluta");
                meny = int.Parse(Console.ReadLine());

                if (meny == 1)
                {

                    Console.WriteLine("\nhur många siffror ska mattas in: ");
                    antal = int.Parse(Console.ReadLine());
                  

                }
                else if(meny == 2)
                {
                    

                    for (int i = 0; i < antal; i++)
                    {
                        Console.WriteLine("skriv in siffra {0}: ", i + 1);

                        test1 = int.Parse(Console.ReadLine());//läser in siffra i inte text1

                        if (i == 0)//första siffran sparas i den här if satsen 
                        {
                            bigest = test1; //första siffran spara i bigest  

                        }
                        else if (i == 1)// här kontrolleras andra siffran som mattas in med första för att bedöma vilken är störst   
                        {

                            if (test1 > bigest) // om test1 har en störe sifra än bigest så körs den här if satsen
                            {
                                test2 = bigest;
                                secondbigest = bigest;
                                bigest = test1;
                            }
                            else// om test1 är mindre än bigest så lägs värdet i test1 in i variabeln secondbiest 
                            {
                                secondbigest = test1;
                            }
                        }
                        else
                        {
                            //testar om det inmatade siffran är större än det näst största siffran men mindre än det största  
                            if (test1 > secondbigest && test1 < bigest)
                            {
                                secondbigest = test1;
                            }
                            //testar om det inmatade siffran är större än det största siffran som mattas in tidigare    
                            else if (test1 > bigest)
                            {
                                test2 = bigest;
                                secondbigest = bigest;
                                bigest = test1;

                            }
                        }

                    }
                    Console.WriteLine("Det näst största talet är: {0}\n", secondbigest);
                }
                else if (meny == 3)
                {
                    break;
                }
            }
        }
    }
}
