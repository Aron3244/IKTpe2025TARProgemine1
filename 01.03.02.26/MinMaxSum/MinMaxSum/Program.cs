namespace MinMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List numbrites");

            int[] numbers = new int [10] { 2, 10, 15, 6, 8, 22, 3, 35, 67, 34 };

            Console.WriteLine(numbers.Max());

            //min
            Console.WriteLine(numbers.Min());

            //sum
            Console.WriteLine(numbers.Sum());

            //average
            Console.WriteLine(numbers.Average());

            Console.WriteLine("-----------------------");
            Console.WriteLine("Sorteerib numbrid alates väiksemast suuremani");

            //Peate kasutaa Array ja Sort ning foreachi

            Array.Sort(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //sorteerib numbrid alates suuremast väiksemani
            Console.WriteLine("\n");
            Console.WriteLine("Sorteerib numbrid alates suuremast väiksemini");
            Array.Reverse(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------");
            //Kasutate bynarySearch
            //Kirjuta lühitalt, mis see tähendab
            Console.WriteLine(Array.BinarySearch(numbers, 1));
        }
    }
}
