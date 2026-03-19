using InheritanceAndServiceClass.Core.Services;

namespace InheritanceAndServiceClass.AppServices.Services
{
    //proovige lahendada probleem, et CarServices ei saa kasutada

    public class CarServices : ICarServices
    {
        public  void GetData()
        {
            Console.WriteLine("Car Services Get");
        }
         public  void PostData()
        {
            Console.WriteLine("Car Services Post");
        }

        public void UpdateData()
        {
            Console.WriteLine("Car Services Update");
        }

        public void DeleteData()
        {
            Console.WriteLine("Car Services Delete");
        }
    }
}
