using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SzallodaApp
{
    internal class Lakosztaly : Szoba
    {
        public int ExtraSzolgaltatasAr { get; set; }


        public Lakosztaly(int szobaszam, int alapar, int extraszolg) : base(szobaszam, alapar)
        {
            ExtraSzolgaltatasAr = extraszolg;

        }

        public override int Arkiszamitas(int ejszakakszama)
        {
            return base.Arkiszamitas(ejszakakszama+ExtraSzolgaltatasAr);
        }

        public override string ToString()
        {
            return [base.ToString()] ($"Extra Szolgaltatas{ExtraSzolgaltatasAr} Ft");

            
        }






    }
}
