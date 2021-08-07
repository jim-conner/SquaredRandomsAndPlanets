using System;
using System.Collections.Generic;
using System.Linq;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //foreach (var planet in planetList)
            //{
            //    Console.WriteLine(planet);
            //}
            
            foreach (var rockyPlanet in rockyPlanets)
            {
                Console.WriteLine(rockyPlanet);
            }

            //********* try coming back and using .ToDictionary() -- with lists already made?
            //var spacecraftDict = rockyPlanets.ToDictionary(rockyPlanets => rockyPlanets);
            var spacecraft2 = new Dictionary<string, List<string>>();


            spacecraft2.Add("Mercury", new List<string> { "Viking", "Opportunity" });
            //spacecraftDict.Add("Venus", new List<string> { "Viking", "Opportunity" });
            //spacecraftDict.Add("Earth", new List<string> { "Viking", "Opportunity" });
            //spacecraftDict.Add("Mars", new List<string> { "Viking", "Opportunity" });


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


        }

    }
}
