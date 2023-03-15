using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace linqqueries
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
        };
            var after1900 = from famousPeople in stemPeople
                             where famousPeople.BirthYear > 1900
                            select famousPeople;

            foreach(famousPeople names in after1900)
            {
                WriteLine(names.Name);
            }
            WriteLine();
            var lowerCaseL = from famousPeople in stemPeople
                             where famousPeople.Name.Contains("ll")
                             select famousPeople;

            foreach(famousPeople names in lowerCaseL)
            {
                WriteLine(names.Name);
            }
            WriteLine();
            var birthdayCount = from famousPeople in stemPeople
                                where famousPeople.BirthYear >1950
                                select famousPeople;
            WriteLine(birthdayCount.Count());
            WriteLine();
            var birthDayCount2 = from famousPeople in stemPeople
                                 where (famousPeople.BirthYear > 1920 && famousPeople.BirthYear < 2000)
                                 select famousPeople;
            foreach(famousPeople name in birthDayCount2)
            {
                WriteLine(name.Name);
            }
            WriteLine(birthDayCount2.Count());
            WriteLine();
            var birthdayOrder = from famousPeople in stemPeople
                                orderby famousPeople.BirthYear
                                select famousPeople;
            foreach(famousPeople name in birthdayOrder) 
            {
                WriteLine($"{name.Name} was born in {name.BirthYear}");
            }
            WriteLine();
            var deathYear = from famousPeople in stemPeople
                            where (famousPeople.DeathYear>1960 && famousPeople.DeathYear<2015)
                            orderby famousPeople.Name
                            select famousPeople;
            foreach(famousPeople name in deathYear)
            {
                WriteLine(name.Name);
            }
        }
        class famousPeople
        {
            public string Name { get; set; }
            public int? BirthYear { get; set; } = null;
            public int? DeathYear { get; set; } = null;
        }
        
    }
}

