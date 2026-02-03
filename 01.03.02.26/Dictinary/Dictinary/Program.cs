namespace Dictinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictinary ja foreach");

            //var on muutuja
            var domains = new Dictionary<string, string>()
            {
                { "fi", "Finland" },
                { "se", "Sweden" },
                { "de", "Germany" },
                { "fr", "France" },
                { "es", "Spain" }
            };
            //kasutage foreachi ja juurde tuleb lisada komas rida
            int i = 1;
            foreach (var domain in domains)
            {
                Console.WriteLine($"{domain.Key} - {domain.Value} - {i}");
                i++;
            }
           
        }
    }
}
