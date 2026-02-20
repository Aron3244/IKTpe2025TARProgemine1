using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class PeopleList
    {

        public static readonly List<People> Peoples = new List<People>

         {
                new People()
            {
                Id = 1,
                Name = "Moona",
                Age = 31,
                GenderId = Guid.Parse("7a074360-b773-41f3-8516-9d548775e2fe")
            },
            new People()
            {
                Id = 2,
                Name = "Poona",
                Age = 21,
                GenderId = Guid.Parse("d095cf22-4e2c-4f7f-9dfd-3990bb6a36f8")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("d095cf22-4e2c-4f7f-9dfd-3990bb6a36f8")
            },
            new People()
            {
                Id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("7a074360-b773-41f3-8516-9d548775e2fe")
            },
             new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("7a074360-b773-41f3-8516-9d548775e2fe")
            },
              new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 21,
                GenderId = Guid.Parse("7a074360-b773-41f3-8516-9d548775e2fe")
            },
               new People()
            {
                Id = 7,
                Name = "Bill",
                Age = 21,
                GenderId = Guid.Parse("d095cf22-4e2c-4f7f-9dfd-3990bb6a36f8")
            },
        };
    }
}

