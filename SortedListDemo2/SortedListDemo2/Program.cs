using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add("Maharastra", "Mumbai");
            s.Add("Andhra Pradesh", "Hyderabad");
            s.Add("Tamil Nadu","Chennai");
            s.Add("Karnataka","Bangalore");
            Console.WriteLine("Elements in the sorted list");
            IDictionaryEnumerator e=s.GetEnumerator();
            while(e.MoveNext())
            {
                Console.WriteLine(e.Key+"\t"+e.Value);
            }


        }
    }
}
