using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAllAny
{
    public class StandartData
    {
        public static readonly List<Standart> standarts = new List<Standart>()
        {
            new Standart() {StandardId = 1, Name = "Standart 1"},
            new Standart() {StandardId = 2, Name = "Standart 2"},
            new Standart() {StandardId = 3, Name = "Standart 3"},
        };
    }
}
