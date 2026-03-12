using Encapsulation.Service;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation ehk kapseldamine");

            //lugipääs classile Studen ei ole piiratud kuna 
            //asub samas projektis
            Student student = new Student();


            //miks on ERROR?
            //Student2 ei tohi teha public classiks
            //koodi ei tohi parandada, aga pead aru saamaa, miks on viga
            //miks internal class ei saa vidata tesises projectis, aga
            //samas projektis olevat saab

            //Kui on tegemist internal classiga, siis ei saa teisest 
            //projektist neid esile kutsuda
            //Student2 student2 = new Student2();

            student.Id = 101;
            student.Name = "test";
            student.Email = "Test@test.com";

            Console.WriteLine("Id = " + student.Id);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);


            //kasutame ProtectedStudent classi
            ProtectedStudent protectedStudent = new ProtectedStudent();
            //protectedStudent.DoSomething();
            //ei saa kasutada kuna asub teises classis, aga samas projectis

            //teha Program.cs classi meetod nimega DoSmethimgInProgrammClass
            //ja kutsu see esile Programm meetodis

            Console.WriteLine("-------------------------------------");
           Program program = new Program();
           program.DoSmethimgInProgrammClass();

            //kutsuda esile PrivateProtectedProgramClass esile
            Console.WriteLine("---PrivateProtectedProgramClass---");
            Program pp = new Program();
            Console.WriteLine(pp.PrivateProtectedProgramClass =
                "PrivateProtectedProgramClass");

            //soovime kasutada PrivateProtectedStudent classis olevat 
            //meetodi ja kutsuda see esile Main meetodis
            var privateProtectedStudent = new PrivateProtectedStudent();
            //kui asub samas klassis saab kasutada, aga teises classis olevat ei saa
            //privateProtectedStudent.PrivateProtectedStudent1 = "asdasd";

            //sealed class kasutamine
            Console.WriteLine("-----Sealed Class-----");
            
            var sc = new SealedStudent();
            sc.Id = 123;
            sc.Name = "Test";
            sc.Email = "sealedTRest@sealed.com";
            //$ - string format ehk saan kasutada stringiväliseid muutujaid
            Console.WriteLine($"Id on {sc.Id}, Name on {sc.Name} ja Email on {sc.Email}")
            ;
        }

        protected void DoSmethimgInProgrammClass()
        {
            Console.WriteLine("DoSmethimgInProgrammClass");
        }

        private protected string PrivateProtectedProgramClass =
            "PrivateProtectedProgramClass";
    }
}
