using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using LINKQ;
using LINKQ.Models;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ läbi swichi!");
            Console.WriteLine("Valik vastav link numbriga");
            Console.WriteLine("1. Where");


            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    WhereLINQ();
                    break;

                case 2:
                    WhereByNameLINQ();
                    break;

                default:
                    break;
            }

        }
        //teeme uue meetodi

        public static void WhereLINQ()
        {
            var peopleAge = PeopleData.peoples
                .Where(x => x.Age > 20 && x.Age < 23);

            //kasutada muutuja peopleAge ja kuvab andmed esile
            //kasutada foreachi

            foreach (var person in peopleAge)
            {
                Console.WriteLine(person.Name);

            }
        }
        public static void WhereByNameLINQ()
        {
            Console.WriteLine("Kirjuta inimese nimi: ");
            string name = Console.ReadLine();

            //kasutada where imimese otsimiseks
            //otsimine toimub nime alusel
            var peopleData = PeopleData.peoples
            .Where(x => x.Name == name);

            foreach (var people in peopleData)
            {
                Console.WriteLine(people.Name + " " + people.Age );
            }
        }
    }
}
