namespace Inherithance2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Inheritance 2");

            //kui siin on water class, siis kuvatakse seal olevat DoSomething meetodi sisu
            //kui panna Water water = new River(); , siis kuvatakse River olevat DoSomething
            //meetodi sisu.
            WaterProp water = new WaterProp();

            WaterProp water2 = new WaterProp();
            water.Flow = true;
            water.Length = "123";
            //kutsume soovitud meetodi ette-
            River.RiverMethod();

            WaterProp water3 = new WaterProp();
            water.Flow = false;
            water.Length = "232";
            Lake.LakeMethod();
            
        }   
    }
}
