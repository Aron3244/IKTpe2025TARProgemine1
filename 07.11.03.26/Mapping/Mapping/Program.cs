using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapped");


            Employee emp = new Employee();

            emp.Id = 11;
            emp.Name = "name1";
            emp.Title = "Title1";
            emp.Description = "Description1";


            //mappimine algab pihta
            EmployeeDto dto = new EmployeeDto();

            //mappimine on see, kus mõlema classi muutujad viiakse kokku
            //protsess, kus muudetakse andmed ühest formaadist, struktuurist või
            //süsteemist teiseks

            //kasutatatkse väärtustes ja muutmiste abil, et ühenduda andmebaasis
            //olevate tabelitega
            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Title = emp.Title;
            dto.Description = emp.Description;

            Console.WriteLine(dto.Id + " " + dto.Name + " " + dto.Title + " " + dto.Description);


            Console.WriteLine("----------------------------");
            Console.WriteLine("AutoMapper");

            var loggerFactory = LoggerFactory.Create(builder => { });

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDto>();
            }, loggerFactory);

            IMapper mapper = config.CreateMapper();

            var emp2 = new Employee
            {
                Id = 12,
                Name = "name2",
                Title = "Title2",
                Description = "Description2"
            };
            var dto2 = mapper.Map<EmployeeDto>(emp2);

            
            
            Console.WriteLine(dto2.Id + " " + dto2.Name + " " + dto2.Title + " " + dto2.Description);

            Car C = new Car();

            C.Id = 11;
            C.Name = "name1";
            C.Title = "Title1";
            C.Description = "Description1";

            CarDto d = new CarDto();
        }

        //tehke üks mappimine juurde ja teemaks on autod
        //peate kaks classi tegema nimega Car ja CarsDto


    }

    //Program.cs on tegemist failiga, kus on Program class ja 
    //nüüd oleme lisanud juurde Employee classi
    //kindlasti tuleb järgida, et class ei oles classi sees
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
    //miks pannakse classi nemetuse taha Dto
    //Dto tägendab data trasfer object
    //neid classe kasutatakse andmete edastamiskes
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }



    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class CarDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}

