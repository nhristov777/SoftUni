﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sex
{
    class Program
    {
        static void Main(string[] args)
        {
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = info[0];
                string country = info[1];
                string city = info[2];
                if (!continents.ContainsKey(continent))
                    continents.Add(continent
                        , new Dictionary<string, List<string>> { });
                if (!continents[continent].ContainsKey(country))
                    continents[continent].Add(country, new List<string>());
                continents[continent][country].Add(city);
            }
            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
            }
        }
    }
}
