    namespace InheritanceAndServiceClass.AppServices.Services
{
    //proovige lahendada probleem, et CarServices ei saa kasutada

    public class CarServices : ICarServices
    {
        public  void GetData()
        {
            Console.WriteLine("Car Services");
        }
    }
}
