using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LINQAllAny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, LINQ");
            Console.WriteLine("1.AllLinq");
            Console.WriteLine("2.AnyLinq");
            Console.WriteLine("3.JoinLinq");


            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    AllLinq();
                    break;
                case 2:
                    AnyLinq();
                    break;
                case 3:
                    JoinLinq();
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;


            }
        }
        public static void AllLinq()
        {
            //kasutatate All
            //kontrollite, kas on vanemaid, kui 12 ja nooremaid, kui 20


            bool result = StudentData.students.All(x => x.Age > 12 && x.Age < 20);

            Console.WriteLine(result);
        }
        //teeme uue meetodi nimega AnyLinq
        //kasutada Any-t
        //vastus on true
        //kasutada muutujat Age

        public static void AnyLinq()
        {
            bool result = StudentData.students.Any(x => x.Age > 12 && x.Age < 20);

            Console.WriteLine(result);
        }

        // teha meetod nimega JoinLinq
        //kasutada jOINI-i


        public static void JoinLinq()
        {
            var innerJoin = StudentData.students
                .Join
                (
                    StandartData.standarts,
                    student => student.StandartId,
                    standardId => standardId.StandardId,
                    (students, standardId) => new
                    {
                        Name = students.Name,
                        StandardId = standardId.StandardId,
                    }
                );

            foreach (var item in innerJoin)
            {
                Console.WriteLine("{0} - {1}", item.Name, item.StandardId);
            }

        }
    }
}
