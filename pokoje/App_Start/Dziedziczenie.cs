using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pokoje.App_Start
{
    public class Dziedziczenie
    {
        public string aa = "Hello";
        void metoda()
        {
            Console.WriteLine(aa);
        }
    }
    public class Dziecko : Dziedziczenie
    {
        Dziedziczenie aa1 = new Dziedziczenie();
        void metoda1()
        {
            aa1.aa.ToString();
        }
    }
}