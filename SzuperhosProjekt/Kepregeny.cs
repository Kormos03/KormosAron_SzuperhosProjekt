using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();

        public static void Szuperhosok()
        {
            foreach(var s in szuperhosok) 
            {
                Console.WriteLine(s);
            }
        }
        public static void Szereplok(string eleres)
        {
            using (StreamReader sr = new StreamReader(eleres)) 
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] hosok = line.Split(' ');
                    int kutyutkeszit = Convert.ToInt32(hosok[1]);
                    
                    if (hosok[0] == "Batman")
                    {
                        Batman batman = new Batman();
                        for (int i = 0;i < kutyutkeszit; i++)
                        {
                            batman.KutyutKeszit();
                        }
                        szuperhosok.Add(batman);
                    }
                    else
                    {
                        Vasember vasember = new Vasember();
                        for (int i = 0; i < kutyutkeszit; i++)
                        {
                            vasember.KutyutKeszit();
                        }
                        szuperhosok.Add(vasember);
                    }
                }
                sr.Close();
            }
        }
    }
}
