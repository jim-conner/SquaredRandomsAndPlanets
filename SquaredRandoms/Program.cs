using System;
using System.Collections.Generic;
using System.Linq;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("////////////Squaring Random Numbers////////////");
            Random random = new Random();
            //int randomNumber = random.Next(0, 50);                                                                                                                    
            List<int> randomNumberList = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                int randomNumber = random.Next(0, 50);
                randomNumberList.Add(randomNumber);
            }

            foreach (var num in randomNumberList)
            {
                // is there another way to do this?
                Console.Write(num.ToString($"{num} "));
            }

            Console.WriteLine();

            var randomNumberListSquared = new List<int>();
            randomNumberListSquared.AddRange(randomNumberList);

            foreach (var squaredNum in randomNumberListSquared)
            {
                int Sqr = (int)Math.Pow(squaredNum, 2);
                Console.Write($"{Sqr} ", '-');
            }

            Console.WriteLine();

            var removeOddsFromList = randomNumberListSquared.Where(num => num % 2 != 0);

            foreach (var rmvOddNum in removeOddsFromList)
            {

                Console.Write(rmvOddNum.ToString($"{rmvOddNum} "));
            }
            Console.WriteLine();
            ///////////////// Planets & Spaceships Excercise /////////////////// 

            Console.WriteLine("/////////////PLANETS////////////");
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            //var spacecraftDict = rockyPlanets.ToDictionary(rockyPlanets => rockyPlanets);
            var spacecraft2 = new Dictionary<string, List<string>>();


            spacecraft2.Add("Mercury", new List<string> { "Viking", "Opportunity" });
            spacecraft2.Add("Venus", new List<string> { "Viking", "Opportunity" });
            spacecraft2.Add("Earth", new List<string> { "Viking", "Opportunity" });
            spacecraft2.Add("Mars", new List<string> { "Viking", "Opportunity" });


            //spacecraftDict.Add("Mercury", "Viking");
            //spacecraftDict.Add("Mars", "Opportunity");
            //spacecraftDict.Add("Mars", "Curiosity");
            //spacecraftDict.Add("Venus", "Sputnik1");
            //spacecraftDict.Add("Venus", "Sputnik2");
            //spacecraftDict.Add("Venus", "Sputnik2");
            //spacecraftDict.Add("Earth", "Mariner 10");
            //spacecraftDict.Add("Mars", "Mariner 1969A");
            //spacecraftDict.Add("Mars", "Mariner 42");

            foreach (var (planet, spaceship) in spacecraft2)
            {
                Console.WriteLine($"{planet}: {String.Join(", ", spaceship)} ");
            }

            Console.WriteLine();
            Console.WriteLine("///////////////Family//////////////");

            //////////////////FAMILY DICTIONARY////////////////

            //below is the longer version instead of var
            //Dictionary<string, Dictionary<string, string>> myFamily2 = new Dictionary<string, Dictionary<string, string>>();
            var myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("wife", new Dictionary<string, string>() { { "name", "Rachel" }, { "age", "452" } });
            myFamily.Add("self", new Dictionary<string, string>() { { "name", "Jim" }, { "age", "214" } });
            myFamily.Add("dog", new Dictionary<string, string>() { { "name", "Bowie" }, { "age", "6" } });

            //using index on keyValuePair to iterate thru values
            foreach (var member in myFamily)
            {
                Console.WriteLine($" {member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");
            }

            //same output but with destructuring
            foreach (var (myFamilyKey, familyMember) in myFamily)
            {
                 Console.WriteLine($" {familyMember["name"]} is my {myFamilyKey} and is {familyMember["age"]} years old.");
            }

            // this didn't work at all
            //foreach (var (relationshipType, familyMemberInfo) in myFamily)
            //{
            //    foreach (KeyValuePair<string, string> kvp in familyMemberInfo)
            //    {
            //        if(kvp.Key == "name")
            //        {
            //            final = ""
            //        }
            //        Console.WriteLine($" {name} is my {relationshipType} and is ___ years old.");
            //        var value = kvp.Value;
            //    }

            //}


        }
    }
}
