using System;

namespace Poprawa30_11
{
    //Grupa E
    class Program
    {
        static void Pierwsze()
        {
            Console.WriteLine("Podaj promien:");
            string r =Console.ReadLine();
            double x = Convert.ToDouble(r);
            double powierzchnia=4*3.14 * (Math.Pow(x, 2));
            double pojemnosc = (4 / 3) * 3.14 * Math.Pow(x, 3);
            Console.WriteLine(powierzchnia);
            Console.WriteLine(pojemnosc);
        }

        static void Drugie()
        {
            double suma = new double();
            double[] cena = {33.4, 50.2, 20.8, 12.7, 9.1, 1};
            double[] ilosc = {2, 8, 9, 5, 12, 7};
            double[] kwota = new double [cena.Length];
            for (int i = 0; i < cena.Length; i++)
            {
                kwota [i] = cena[i] * ilosc[i];
                if (i==0)
                {
                    suma = kwota[0];
                }
                else
                {
                    suma = kwota[i]+kwota[i-1];
                }
            }
            Console.WriteLine("Suma to: ");
            Console.WriteLine(suma);
        }

        static void Trzecie()
        {
            double[][] oceny = {
                new double[] {3,4,5,2,3,5},
                new double[] {1,2,2,2,1,1}
            };
            double[] srednia = new double [oceny[0].Length];
            for (int i = 0; i < oceny[0].Length; i++)
            {
                srednia[i]= oceny[0][i]*oceny[1][i];
                Console.WriteLine(srednia[i]);
            }
        }
            
        static void Main(string[] args)
        {
            Pierwsze();
            Drugie();
            Trzecie();
        }
    }
}