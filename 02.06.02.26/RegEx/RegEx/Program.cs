namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teeme Regular Exressio harjutuse");

            string word = "#CD5C5CA";
            Console.WriteLine("Hex code: " + word);
            Console.WriteLine("Kas on regex: " + RegExTest(word));
        }

        public static bool RegExTest(string word)
        {
            //Regular Expressin kontrollib, kas sisestav string vastab nõuetele
            return System.Text.RegularExpressions.Regex.IsMatch(word, @"[#][0-9A-Fa-f]{6}\b");
        }
    }
}
