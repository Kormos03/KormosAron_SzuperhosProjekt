﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        public Vasember(double szuperero, bool vanEGyengesege) : base(szuperero, vanEGyengesege)
        {
            szuperero = 150;
            vanEGyengesege = true;
        }

        public void KutyutKeszit()
        {
            this.Szuperero += (double)RND.Next(0, 10);
        }

        public override bool MegmentiAVilagot()
        {
            return Szuperero > 1000 ? true : false;
        }

        public new string ToString()
        {
            return $"Vasember: Szupererő: {this.Szuperero} {(this.VanEGyengesege ? "van" : "nincs")} gyengesége";
        }
    }
}
