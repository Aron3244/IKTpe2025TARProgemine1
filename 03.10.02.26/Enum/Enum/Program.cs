using System;

namespace EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");

            // kasutame enumit Weekday ja näitame Friday
            Console.WriteLine(Weekday.Friday);

            // tahame Friday numbrilist väärtust
            Console.WriteLine((int)Weekday.Friday);

            Console.WriteLine("------------------------");
            Console.WriteLine((int)Color.Red);
            Console.WriteLine(Color.Red);

            //tehke uus enum Color
            //väärtused on 
            //Red = 3
            //Green = 10
            //Blue = 12
            //Yellow = 5
            //Black = 1
            //White = 8
            //ühe värvi nimetuse peab  konsoolis ära näitama
        }
    }

    enum Weekday
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    enum Color
    {
        Red = 3,
        Green = 10,
        Blue = 12,
        Yellow = 5,
        Black = 1,
        White = 8
    }
}
    
  
