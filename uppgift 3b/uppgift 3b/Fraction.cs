using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_3b
{
    class Fraction
    {
        //använder understräck i dem två variablerna här under för att visa att de är privat
        private int _Teljare;//Täljare
        private int _Nemnare; //Nämnare

        public Fraction(int tel, int nem)// konstruktor som används initialiserar ett nytt bråktal
        {
            GetNumerator = tel;
            GetDenominator = nem;
        }

        public int GetNumerator// ger oss till gång till den privata variablerna _Teljare genom get os set
        {
            get
            {
                return _Teljare;
            }
            set
            {
                try
                {
                    if (value == 0)// kontrollerar om nämnare är lika med 0, om den är 0 kastas ett fel meddelande 
                    {

                        throw new ArgumentException();//kastar undantag som tas i mot i catch
                    }

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n-------------------------------------");
                    Console.WriteLine("ERROR!!! Täljare är 0");
                    Console.WriteLine("\n-------------------------------------\n");
                    Console.ResetColor();
                }
                _Teljare = value;
            }
        }

        public int GetDenominator// ger oss till gång till den privata variablerna _Nemnare genom get os set
        {
            get
            {
                return _Nemnare;
            }
            set
            {
                try
                {
                    if (value == 0)// kontrollerar om nämnare är lika med 0, om den är 0 kastas ett fel meddelande 
                    {

                        throw new ArgumentException();// kastar undantag som tas i mot i catch

                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n-------------------------------------");
                    Console.WriteLine("nERROR!!! nämnare är 0");
                    Console.WriteLine("-------------------------------------\n");
                    Console.ResetColor();
                }
                _Nemnare = value;
            }
        }
       
        public bool isNegative()// metode som avänds för att kontrollerar om bråktalet är negativt  
        {
            Console.WriteLine("\ndet är ett negativt bråktal");

            if ((_Teljare / _Nemnare) < 0)// if satas som kontrollerar om värdet av _numerator/_denominator gär ett tal som är mindre än 0
            {
                
                return true;
            }
            else
            {
                
                return false;
            }
        }

        public Fraction add(Fraction brok2)// adderar två bråktal 
        {

            int newTel = GetNumerator * brok2.GetDenominator + brok2.GetNumerator * GetDenominator;//(första täljaren * andra nämnaren) + (andra täljaren * första nämnaren) gär os en ny täljar

            int newNem = GetDenominator * brok2.GetDenominator; // första broktalets nämnare gångras med andra broktalets nämnare för att få en ny nämnar

            return new Fraction(newTel,newNem);

        }


        public Fraction multiply(Fraction brok2)// multiplicerar två bråktal 
        {

            int newTel = GetNumerator * brok2.GetNumerator;// man gångrar första täljaren * andra täljaren och får den nya täljare

            int newNem = GetDenominator * brok2.GetDenominator;//man gångrar första nämnare * andra nämnare och får den nya nämnare

            return new Fraction(newTel, newNem);
        }

        public void minstaformen()// minskar bråket till den minsta formen
        {
           
            int MinstaSGN = Math.Min(Math.Abs(GetNumerator), Math.Abs(GetDenominator));// här får vi minsta av de två störst gemensamma nämnare

            int minsta = 2;// minsta möjliga gemensamma nämnare
          
            do
            {// om (GetNumerator / minsta = svaret är lika med 0 ) och (GetDenominator / minsta lika med 0) så går vi in i if satsen
                if (((GetNumerator % minsta) == 0) && ((GetDenominator % minsta) == 0)) // if satsen krontoläar att vi värkligen har fåt minsta gemensamma nämnare
                {
                    GetNumerator = GetNumerator / minsta;
                    GetDenominator = GetDenominator / minsta;
                    //exempel exmpel på hur vi förkoratar bråket här upp 
                    //man har bråket 2/18 minsta gemensamma nämnare är 2 som sen delas med bråket 2/2 och 8/2 som gär oss bårketalet 1/4 

                    MinstaSGN = Math.Min(Math.Abs(GetNumerator), Math.Abs(GetDenominator));// här gör vi om processen i början, för att värklig se om vi fåt den minsta gemensamma nämnare
                    minsta = 2;
                }
                else
                {
                    minsta++; 
                }
            }
            while (minsta <= MinstaSGN); 
        }


        public bool isEqualTo(Fraction brok1)// kontroläar om broktalen är lika 
        {
            Console.WriteLine("\nbråktalen är lika");
            if (GetDenominator == brok1.GetDenominator && GetNumerator == brok1.GetNumerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()// visar bråktallet 
        {
            return string.Format("\nBråktal: {0}/{1}", GetNumerator, GetDenominator);
        }



    }
}
