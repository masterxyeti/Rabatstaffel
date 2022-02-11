using System;

namespace Rabattstaffel
{
    class Program
    {
        static void Main(string[] args)
        {
            double summe,rabatt,r1,r2,r3,r4,r5;
            int i;
            Console.WriteLine("Rabattrechner \n");
            Console.WriteLine("Eingabe \n");
            Console.WriteLine("Artikelanzahl:               ");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Einzelpreis:                 ");
            double einzelpreis = Convert.ToDouble(Console.ReadLine());
            summe = eingabe * einzelpreis;
            r1=0.05;
            r2 = 0.09;
            r3 = 0.13;
            r4 = 0.16;
            r5 = 0.18;

            i = 0;

            rabatt = 0;
            
            Console.WriteLine("\n");
            if (summe >= 10000)
            {

                rabatt = summe * r5;
                i = 18;
            } else if (summe >= 5000)

            {

                rabatt = summe * r4;
                i = 16;
            } else if (summe >= 2500)
            {

                rabatt = summe * r3;
                i = 13;
            } else if (summe >= 100)
            {
                rabatt = summe * r2;
                i = 9;
            } else if (summe >= 500)
            {
                rabatt = summe * r1;
                i = 5;
            } else
            {
                rabatt = 1;
                i = 0;
            }
            

            Console.WriteLine("Ausgabe\n");

            Console.WriteLine("Verkaufpreis: \t\t {0:F2}",summe);
            Console.WriteLine("-{0}% Rabatt: \t\t {1:F2}",i,rabatt);
            Console.WriteLine("-----------------------------------");
            summe = summe + rabatt;
            Console.WriteLine("Zahlungsbetrag: \t {0:F2}",summe);

            Console.ReadKey();
        }
    }
}
