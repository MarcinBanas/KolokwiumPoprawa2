using System;



namespace KolokwiumPoprawa2
{


    class Program
    {
        public static void Funkcja(ref int pkt, string odp)
        {
            if (string.Compare(odp, "tak") == 0)
            {
                pkt++;
            }
        }
        static void Main(string[] args)
        {
            string odpowiedz;
            int a = 0, punkty = 0;
            do
            {
                Console.WriteLine("Podaj odpowiedz:");
                odpowiedz = Console.ReadLine();
                Funkcja(ref punkty, odpowiedz);
                a++;
            }
            while (a < 3);
            Console.WriteLine(punkty);

            Random rnd = new Random();
            int[,] tab = new int[5, 4];
            int[] tab2 = new int[3];
            tab2[0] = 10;
            tab2[1] = 100;
            tab2[2] = 1000;

            for (int i = 0; i < 5; i++)
            {
                
                    tab[i, 0] = tab2[rnd.Next(3)];
                
                    tab[i, 1] = rnd.Next(1, 101);
                
                    tab[i, 2] = rnd.Next(2, 6);
                
                    tab[i, 3] = rnd.Next(6, 8);
                
            }

            int min = tab[0, 0];
            int akt;
            for (int n = 0; n < tab.GetLength(0); n++)
            {
                akt = tab[n, 0];

                if (akt < min)
                {

                    min = akt;
                }
            }
            Console.WriteLine("Przepustowosc:" + min);
            int x = 0;
            for (int o = 0; o < tab.GetLength(0); o++)
            {
                x += tab[o, 1];

            }
            Console.WriteLine("Suma opoznien:" + x);
            int b = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                b += tab[i, 2];
            }
            Console.WriteLine("Podlaczone urzadzenia:" + b);
            int c = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                c += tab[i, 3];
            }
            Console.WriteLine(c);
            Console.WriteLine("Wolne porty:" + (c - b));

            Lek apap = new Lek(true, "apap", 450, 50);
            Console.WriteLine(apap.Cena());
            apap.Sprzedaj();
        }
    }
}
