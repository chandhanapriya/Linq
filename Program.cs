using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace DemoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of LINQ!");

           int[] scores = new int[] { 30,40,50,60,70 };
            string[] cities = new string[] { "Karnataka", "Bengal", "andhrapradesh", "Delhi" };


            /*IEnumerable<int> scoreQuery =
                from score in scores
                where score > 30
                select score;*/
            IEnumerable<string> CityQuery =
                from city in cities
                where city is "Bengal"
                select city;



            // Execute the query.
            /*foreach (int i in scoreQuery)
            {
                Console.WriteLine("value is:" + i);
            }*/
            foreach (string i in CityQuery)
           {
               Console.WriteLine("city is:" + i);
           }


        }
    }
}
    
