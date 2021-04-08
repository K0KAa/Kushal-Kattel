using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main()
        {
            //LINQ  - Language Integrated Query
            int[] numbers = { 12, 23, 45, 67, 99, 5, 0, 34, 111, 2, 45, 69 };

            //Method Syntax
            var result1 = numbers.Where(num => num > 50).Select(num => num);

            //Query expression syntax

            var result2 = from num in numbers
                          where num > 50
                          select num;

            //Restrictions where
            var result3 = from num in numbers
                          where num > 50 && num < 70
                          select num;

            //Projections where
            var result4 = from num in numbers
                          select num * num;
            //even numbers
            var result5 = from num in numbers
                          where num % 2 == 0
                          select num;
            //Numbers in decending order
            var result6 = from num in numbers
                          orderby num descending
                          select num;

            //Partitioning take
            var result7 = numbers.Take(5);
            //skipping first five and taking other five

            var result8 = numbers.Skip(5).Take(5);

            var result9 = numbers.Any(num => num % 2 == 0);
            var result10 = numbers.All(num => num % 2 == 0);
            var result11 = numbers.Contains(31);

            //Generations:range, repeat

            var result12 = Enumerable.Range(1,15);
            var result13 = Enumerable.Repeat("hello",40);

        }

        void LearnLinqOnComplexCollection()
        {
            
            Country c1 = new Country("Nepal","Kathmandu","Asia",234234234);
            Country c2 = new Country("India", "Delhi", "Asia", 234234234,DateTime.Parse("1947/11/2"));
            Country c3 = new Country("Bhutan", "Thimpu", "Asia", 234234234);
            Country c4 = new Country("England", "London", "Europe", 234234234);
            Country c5 = new Country("Us", "DC", "NAmerica", 234234234,DateTime.Parse("1947/11/2"));
            Country c6 = new Country("Germany", "Berlin", "Europe", 234234234,DateTime.Parse("1947/11/2"));
            List<Country> countries = new List<Country>{c1,c2,c3,c4,c5,c6};

            //List all Asian countries name
            var result1 = from country in countries
                         where country.Continent =="Asia"
                         select country.Name;
            
            //List all countries name, never been invaded
            //List all european countries in ascending order that has population less than 500k


        }
    }


}
