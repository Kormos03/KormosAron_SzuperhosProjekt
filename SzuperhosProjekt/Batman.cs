using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Batman : ISzuperhos, IMilliardos
    {
        private double lelemenyesseg;

        public Batman()
        {
            this.lelemenyesseg = 100;
        }

        public double Lelemenyesseg { get => lelemenyesseg; set => lelemenyesseg = value; }

        public void KutyutKeszit()
        {
            Lelemenyesseg =+ 50;
        }

        public bool LegyoziE(ISzuperhos szuperhos)
        {
            return (Lelemenyesseg > szuperhos.MekkoraAzEreje()? true : false);
        }

        public double MekkoraAzEreje()
        {
            return Lelemenyesseg * 2;
        }

        public override string ToString()
        {
            return $"Batman: leleményesség: {this.lelemenyesseg}";
        }
    }
}
