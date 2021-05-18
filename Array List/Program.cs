using System;
using System.Collections;
namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");                               //Adds an element at the end of a ArrayList
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);
            arlist1.Insert(1, "Tom");                       //Inserts an element at the specified index 
            int[] arr = { 100, 200, 300, 400 };
            arlist1.AddRange(arr);                          //adding array in arraylist 
            foreach (var item in arlist1)                   //Iterates through a ArrayList
                Console.WriteLine(item);
            arlist1.Remove(null);                           //Removes first occurance of null
            arlist1.RemoveAt(4);                            //Removes element at index 4
            Console.WriteLine();
            foreach (var item in arlist1)
                Console.WriteLine(item);
            Console.WriteLine(arlist1.Contains(300));       //Checks whether the specified element exists or not
            arlist1.Reverse();                              //Reverses the order of the elements in the entire ArrayList.
            Console.WriteLine();
            foreach (var item in arlist1)
                Console.WriteLine(item);
        }
    }
}
