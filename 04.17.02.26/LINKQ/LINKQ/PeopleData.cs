using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINKQ.Models;

namespace LINKQ
{
    class PeopleData
    {
        public static readonly List<PeopleList> peoples = new List<PeopleList>

        {
                new PeopleList()
            {
                Id = 1,
                Name = "Moona",
                Age = 31,
                GenderId = Guid.Parse("7a074360-b773-41f3-8516-9d548775e2fe")
            },
            new PeopleList()
            {
                Id = 2,
                Name = "Poona",
                Age = 21,
                GenderId = Guid.Parse("d095cf22-4e2c-4f7f-9dfd-3990bb6a36f8")
            },
            new PeopleList()
            {
                Id = 3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("d095cf22-4e2c-4f7f-9dfd-3990bb6a36f8")
            },
            new PeopleList()
            {
                Id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("7a074360-b773-41f3-8516-9d548775e2fe")
            },
             new PeopleList()
            {
                Id = 5,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("7a074360-b773-41f3-8516-9d548775e2fe")
            },
              new PeopleList()
            {
                Id = 6,
                Name = "Mari",
                Age = 21,
                GenderId = Guid.Parse("7a074360-b773-41f3-8516-9d548775e2fe")
            },
               new PeopleList()
            {
                Id = 7,
                Name = "Bill",
                Age = 21,
                GenderId = Guid.Parse("d095cf22-4e2c-4f7f-9dfd-3990bb6a36f8")
            },
        };
    }
}

