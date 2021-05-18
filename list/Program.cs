using System;
using System.Collections.Generic;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstlist = new List<int>();
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);
            Console.WriteLine("Count Is: " + firstlist.Count);
            firstlist.Add(5);
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);
            Console.WriteLine("Count Is: " + firstlist.Count);          //Returns the total number of elements exists in the List
            foreach (int num in firstlist)
                Console.WriteLine(num);
            Console.WriteLine(firstlist.BinarySearch(2));          //Search the element and returns an index of the element.
            firstlist.Add(6);                                    //Adds an element at the end of a List
            firstlist.Insert(0, 0);                              //Insert Elements in List at specified index. 



            string[] cities = new string[3] { "Mumbai", "London", "New York" };

            List<string> popularCities = new List<string>();
            popularCities.AddRange(cities);         // adding an array in a List
            //popularCities.Clear();         // Removes all the elements from a List

            foreach (string names in popularCities)
                Console.WriteLine(names);
        }
    }
}
