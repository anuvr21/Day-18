using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortedListDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add("Maharashtra", "Mumbai");
            s.Add("Karnataka", "Bangalore");
            s.Add("Andhra Pradesh", "Hyderabad");
            Console.WriteLine("Elements in the sorted list");
            foreach(var item in s.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in s.Values)
            {
                Console.WriteLine(item);
            }


        }
    }
}
