using System.Net.Cache;
using ListINQ;

namespace ListLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liat and LINQ");

            //teeme "andmebaasi"
            //ja selleks on vaja luua class nimega Persone
            //mis on muutuja all nimega person
            IList<Person> person = new List<Person>()
            {
            new Person() {Id = 1, Name = "Juku", Age = 10},
            new Person() {Id = 2, Name = "Juhan", Age = 10},
            new Person() {Id = 3, Name = "Maiili", Age = 10},
            new Person() {Id = 4, Name = "Aksel", Age = 10},
            };
            //nüüd kasutamae person muutujat uue muutuja all
            //mille nimekso on persons
            var persons = from p in person
                          select new
                          {
                              Id = p.Id,
                              Name = p.Name,
                              Age = p.Age,
                          };

            //kasutama muutuja persons, et näidata kosnsolis tulemust
            foreach (var item in persons)
            {
                Console.WriteLine("Id on " + item.Id + " ja nimi on " + item.Name);

            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("kASUTAME LiNQ Selecti ehk teine variant");
            //Siin sii koondame kogu info result muutuja sisse
            var result = person
                //Where-ga saab teha konkreetse päringu, et vastab mingitele tingimustele
                .Where(p => p.Id == 1 || p.Age == 9)
                .OrderBy(p => p.Name) //järiestab isikud nime järgi
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Age = x.Age,
                });

            //kasutame result muutujat ja teema ta lahti rea kaupa
            //läbi muutuja item
            foreach (var item in result)
            {
                Console.WriteLine("Id on " + item.Id + " ja nimi on " + item.Name);
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Gruppide kaupa sorteerimine");

            var groupBy = person
                .GroupBy(p => p.Id);
            foreach (var item in groupBy)
            {
                Console.WriteLine("Vanuse grupp on: {0} ", item.Key);
            }
        }
    }
}
