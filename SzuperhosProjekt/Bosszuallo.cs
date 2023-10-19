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

        public Bosszuallo(int Szuperero, bool VanEGyengesege)
        {
            this.Szuperero = Szuperero;
            this.VanEGyengesege = VanEGyengesege;
        }

        public abstract bool MegmentiAVilagot();

        public bool LegyoziE(ISzuperhos szuperhos)          //4-dik feladat utolsó előtti hiányzik
        {
            if(szuperhos is Bosszuallo && this.VanEGyengesege == true && this.MekkoraAzEreje() < szuperhos.MekkoraAzEreje())
            {
                return true;
            }
            else if (szuperhos is Batman && this.MekkoraAzEreje() * 2 > szuperhos.MekkoraAzEreje())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double MekkoraAzEreje()
        {
            return Szuperero;
        }

        public override string ToString()
        {
            return $"Szupererő: {this.Szuperero}; {(this.VanEGyengesege ? "van" : "nincs")} gyengesége";
        }

    }
}
