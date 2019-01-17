using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730499
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a collection that is A list
            var dogs = new List<string>();
            dogs.Add("bichon");
            dogs.Add("collia");
            dogs.Add("retriver");

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog + " ");

            }
            int[] a1 = new int[] { 1, 3, 5, 7, 9, 11 };
            foreach(int i in a1)
            {
                Console.WriteLine("the value of i");
            

        }
    }
}
