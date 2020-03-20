using System;
using System.Collections.Generic;

namespace ThirdLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pupils first = new Pupils();
            //Pupils second = new Pupils();
            //Pupils[] range = { first, second, first };
            //List<Pupils> pupilList = new List<Pupils>;
            //pupilList.Add(first);
            //pupilList.AddRange(range);
            //pupilList.Remove(second);
            //pupilList.RemoveAt(1);
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            Console.WriteLine(dictionary[2]);
            
            

        }
    }
}
