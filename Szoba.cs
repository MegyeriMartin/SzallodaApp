using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    internal class Szoba
    {
        public int SzobaSzam { get; }
        protected int alapar { get; set; }
        public int Alapar
        {
            get;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Az alapár nem lehet 0 vagy negatív");
                }
               
            }
        }

        public Szoba(int szobaszam, int alapar)
        {
            SzobaSzam = szobaszam;
            Alapar = alapar;
        }





        public virtual int Arkiszamitas(int ejszakakszama)
        {

            return ejszakakszama * Alapar;

        }

        public override string ToString()
        {

            return $"Szoba:{SzobaSzam}, Alapár:{Alapar} Ft/éj";
        }


    }
}
