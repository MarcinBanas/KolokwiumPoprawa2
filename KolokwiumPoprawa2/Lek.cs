using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumPoprawa2
{
    class Lek
    {
        private bool OTC { get; }
        private string Nazwa { get; set; }
        private double CenaPodstawowa { get; set; }
        private double Promocja { get; set; }

        public Lek(bool otc, string nazwa, double cenapodstawowa, int promocja)
        {
            OTC = otc;
            Nazwa = nazwa;
            CenaPodstawowa = cenapodstawowa;
            Promocja = promocja;
        }
        public double Cena()
        {
            return CenaPodstawowa - (CenaPodstawowa * (Promocja / 100));
        }

        public void Sprzedaj()
        {
            if(OTC)
            {
                Console.WriteLine("Podaj Numer recepty");
                string a = Console.ReadLine();
                if(a.Length==10)
                {
                    Console.WriteLine(Nazwa+" "+Cena());
                }
                else
                {
                    throw new ArgumentException("Zly nr recepty");
                }
            }
        }
    }
}
