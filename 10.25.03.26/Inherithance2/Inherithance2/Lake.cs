using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherithance2
{
     class Lake : Water
    {
        //tehke sama asi, mis Riveri-ga ja kutsuge Program classis Main meetodis esile

        public static void LakeMethod()
        {

            WaterProp waterProp = new WaterProp();
            Console.WriteLine($"This Lake method and it has " + waterProp.Flow + " and " + waterProp.Length);

        }
    }
}
