namespace InheritanceVIN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Teha pärilisus 
            //On olemas class nimega Machine 
            //See pärineb Cars classi 
            //saab sisestada masina numbri 
            //konsooli annab vastuse: Edukalt sisestatud 
            //VIN kood: VIN koodi nr
            Console.WriteLine("Sisesta VIN kood: ");
            int Code = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta VIN koodi number: ");
            int CodeNr = Convert.ToInt32(Console.ReadLine());

            Machine machine = new Machine();
            machine.SetCode(Code);
            machine.SetCodeNr(CodeNr);

            Console.WriteLine("Edukalt sisestatud");
            Console.WriteLine("VIN kood: " + machine.GetCode());
        }
    }

    class Car
    {
        

        public void SetCode(int C)
        {
            code = C;
        }

        public void SetCodeNr(int CNr)
        {
            codeNr = CNr;
        }
        protected int code;
        protected int codeNr;
    }

    class Machine : Car
    {
        public int GetCode()
        {
            return code;
        }
    }
}