using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherithance2
{
    //River on antud juhul alamkklasss ja viitab Aater e peamisele klasssile

    //kui kirjutan overwride, siis kirjutab Water meetodis oleva DoSomehing meetodi üle
    //Kui ma panen siis public virtual void, siis ei kirjuta Water meetodi DoSomething-t üle
    internal class River : Water
    {
        public static void RiverMethod()
        {

            //Water classis olemas muutuja Flow ja Length ja sellep
            WaterProp waterProp = new WaterProp();
            //kuidas saada ära kasutada Water classis olevaid muutujaid siin
            Console.WriteLine($"This river method and it has " + waterProp.Flow + " and " + waterProp.Length + "is in meters");
        }
    }
}
