using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        public static Random RND = new Random();
        private double szuperero;
        private bool vanEGyengesege;

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        public Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.Szuperero = szuperero;
            this.VanEGyengesege = vanEGyengesege;
        }

        public abstract bool MegmentiAVilagot();

        public bool LegyoziE(ISzuperhos szuperhos)          //4-dik feladat utolsó előtti hiányzik
        {
            return true;
        }

        public double MekkoraAzEreje()
        {
            return Szuperero;
        }

        public override string ToString()
        {
            return $"Szupererő: {this.Szuperero} {(this.VanEGyengesege ? "van" : "nincs")} gyengesége";
        }

    }
}
