using System.Collections.Concurrent;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //tuleb thea class nimega PeopleList
            //seal on kuus rida andmeid
            //kindlasti peab olema kaks Mari nimega isikut, aga erinevate vanustega

            Console.WriteLine("tee valik numbriga");
            Console.WriteLine("1: ThenByLINQ");
            Console.WriteLine("2: ThenByDescendingLINQ");
            Console.WriteLine("3: SelectLINQ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ThenByLINQ();
                    break;
                case 2:
                    ThenByDescendingLINQ();
                        break;
                case 3:
                    SelectLINQ();
                        break;
                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }
        //kutsuda meetod swichis esile
        public static void ThenByLINQ()
        {
            //thenby sorteerib numbrilises järiestikus
            var thenByResult = PeopleList.Peoples
                .OrderBy(x => x.Name)
                 .ThenBy(x => x.Age);

            Console.WriteLine("ThenBy järgi sorteerimine");



            foreach (var item in thenByResult)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }

        public static void ThenByDescendingLINQ()
        {
            var thenByDescending = PeopleList.Peoples
            .OrderBy(x => x.Name)
                 .ThenBy(x => x.Age);
            foreach (var item in thenByDescending)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }
        //tuleb teha meetod, kus kasutate LINQ selecti
        public static void SelectLINQ()
        {
            //select lihtsalt tagastab andmed nii nagu on andmebaasis
            //sama hea, mis SQL select
            var result = PeopleList.Peoples
                        .Select(x => new
                        {
                            Name = x.Name,
                            Age = x.Age,
                        });
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }
    }
}

