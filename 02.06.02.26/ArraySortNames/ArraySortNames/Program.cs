namespace ArraySortNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kasutame Array ja Sort-i");
            string[] animals = { "cat", "alligator", "fox", "donkey", "bear", "elphant", "goat" };
            //tuleb kasutada foreachi ja näidata kõiki loomi
            //paneb kõik tähestikulisse järiekorda
            //Array.Sort (animals);
            foreach (string i in animals)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------");
            //järiesta kom esimest sõna tähestikuses järiestuses
            //vaadake Sort meetodi ja mitu overload sel on

            Array.Sort (animals, 0, 3);
            foreach (string i in animals)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------------");
            int[] numbers = { 1, 2, 3, 4, 3, 55, 23, 2};
            //tuleb välistada kordused
            //mida teha, et numbrid ei korduks

            int[] distinct = numbers.Distinct().ToArray();
            Array.Sort(distinct, 0 , distinct.Length);

            foreach (int i in distinct)
            {
                Console.WriteLine(i);
            }
        }
    }
}
