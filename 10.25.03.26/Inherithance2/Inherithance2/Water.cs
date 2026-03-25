using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherithance2
{
    //siis on DoSomethinf meetod, mida siis viidatakese River classi all.
    //see voib olla virtual ja ei pea panema override kua teda kirjutatakse üle
    internal class Water
    {

        static void DoSomething()
        {
            Console.WriteLine("Do Something method");


        }
    }

    internal class WaterProp
    {
        public bool Flow;
        public string Length;
    }
}
