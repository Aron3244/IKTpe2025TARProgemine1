using System.ComponentModel;
using System.Linq;
using System.Xml;

namespace LINQTakeSkip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ meetodod");
            Console.WriteLine("1. Skip");
            Console.WriteLine("2. SkipWhile");
            Console.WriteLine("3. TakeWhile");
            Console.WriteLine("4. FirstOrDefualt");
            Console.WriteLine("5. AverageAge");
            Console.WriteLine("6. CountLINQ");
            Console.WriteLine("7. Sum");
            Console.WriteLine("8. Max");
            Console.WriteLine("9. Min");

            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Skip();
                    break;

                case 2:

                    SkipWhile();
                    break;

                case 3:
                    TakeWhile();
                    break;

                case 4:
                    FirstOrDefualt();
                    break;

                case 5:
                    AverageAge();
                    break;

                case 6:
                    CountLINQ();
                    break;

                case 7:
                    Sum();
                    break;

                case 8:
                    Max();
                    break;

                case 9:
                    Min();
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }

        public static void Skip()
        {
            Console.WriteLine("--------Skip---------");
            //kasuta skipi ja jäta kolm tüki vahele


            var skip = PeopleList.Peoples.Skip(3);

            foreach (var item in skip)
            {
                Console.WriteLine(item.Name);
            }
        }
        //teete uue meetodi, aga kasutate SkipWhile ja vanemad, kui 18 olema tingimus

        public static void SkipWhile()
        {
            //Mis tähendab => .See tähendab lambda märki ja selle abil saab kasutada pikema
            //class nimetuse asemel lühendit koos sees oleva muutijaga, mis antud juhul on x
            Console.WriteLine("----------SkipWhile---------");
            //SkipWhile jätab loendis nii kaua vahele rodu kuni vastab tingimusele
            //ehk antud juhul jätab read vahele kuni leiab 18 a isku ja peale seda
            //hakkab infot kuvama olenevata vanuse tingim´ustest

            var whileskip = PeopleList.Peoples.SkipWhile(x => x.Age > 18);

            foreach (var item in whileskip)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Age);
            }

        }
        //Vooskeem TakeWhile
        //kasutada TakeWhile ja katsuda see esile switchis
        //tingimus on Age > 18
        public static void TakeWhile()
        {
            var takeWhile = PeopleList.Peoples.TakeWhile(x => x.Age > 18);

            foreach (var item in takeWhile)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Age);
            }
            //TakeWhile näitab isikuid kaua vastab tingimusele
            //ehk antud juhul näitab andmeud  kuni leiab 18 a isku ja peale seda
            // ei näita andmeid

        }
        public static void FirstOrDefualt()
        {
            //kuvab esimese elemendu, mis järiestuses
            //vastab tingimustele

            //peate kasutama Name ja Lenghti-i. Nimi peab olema vähemalt 5 tähemärki

            string firstLongName = PeopleList.Peoples.FirstOrDefault(x => x.Name.Length == 5).Name;

            Console.WriteLine("The first long name is '{0}' .", firstLongName);
        }

        //Kasutada Avrage LINQ
        public static void AverageAge()
        {
            var averageAge = PeopleList.Peoples.Average(x => x.Age);

            Console.WriteLine("The average age is " + averageAge);
        }

        public static void CountLINQ()
        {
            var totalPersons = PeopleList.Peoples.Count();

            Console.WriteLine("Inimesi on kokku " + totalPersons);
            Console.WriteLine("-------------------------------------");

            var adultPerson = PeopleList.Peoples.Count(x => x.Age >= 18);

            Console.WriteLine("täiskasvanuid inimesi on kokku " + adultPerson);
        }

        public static void Sum()
        {
            var sum = PeopleList.Peoples.Sum(x => x.Age);

            Console.WriteLine("inimeste vanus on kokku " + sum);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Täisealiste isikute koonarv");
            var numAdults = 0;
            var sumAdults = PeopleList.Peoples.Sum(x =>
            {
                if (x.Age >= 18)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });

            Console.WriteLine("Täisealiste isikute koonarv " + numAdults);
        }
        public static void Max()
        {
            var max = PeopleList.Peoples.Max(x => x.Age);

            Console.WriteLine("Kõige vanem on " + max);
        }
        public static void Min()
        {
            var min = PeopleList.Peoples.Min(x => x.Age);

            Console.WriteLine("Kõige noorem on " + min);
        }
    }
}
