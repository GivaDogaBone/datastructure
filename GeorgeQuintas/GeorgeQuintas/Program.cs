using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeorgeQuintas
{
    class Program
    {
        public static class IntUtil
        {
            private static Random random;
            private static HashSet<int> hset;

            private static void Init(string init)
            {
                switch (init)
                {
                    case "random" :
                        if (random == null) random = new Random();
                        break;
                    case "hset" :
                        if (hset == null) hset = new HashSet<int>();
                        break;
                    default:
                        Console.WriteLine("Invalid init parameter");
                        break;
                }               
            }

            public static int Random(int min, int max)
            {
                // Generate random range
                Init("random");
                return random.Next(min, max);
            }

            public static IList<int> RemoveDuplicates(IList<int> intList)
            {
                // Remove duplicates
                Init("hset");
                HashSet<int> hset = new HashSet<int>(intList);
                IList<int> hList = hset.ToList();
                return hList;
            }
        }
        
        static void Main(string[] args)
        {
            int lowNumber, highNumber;
            IList<int> intList = new List<int>();
            IList<int> noDupList = new List<int>();

            /*
             * Write C++ or C# code to implement an efficient algorithm to create a 52 element array containing the numbers 1 to 52, randomly ordered. 
             * Each number should only occur once in the resultant array.
            */
            Console.WriteLine("Random number 1 to 52 with possible duplicates");
            for (var i = 1; i <= 52; i++)
            {
                int randomNumber = IntUtil.Random(1, 52);
                Console.WriteLine("Random number : {0:G}\n", randomNumber);
                intList.Add(randomNumber);
            }
            Console.WriteLine("Removing Duplicates !!!");
            noDupList = IntUtil.RemoveDuplicates(intList);
            for (int i = 0; i < noDupList.Count; i++)
            {
                Console.WriteLine("List value : {0:G}\n", noDupList[i]);
            }
            Console.WriteLine("List value count : {0:G}\n", noDupList.Count);

            /*
             * Assume that you have access to a function called Random() that generates a random number in a specified range. This function will accept two parameters. 
             * The first is the LowNumber of the range and the second is the HighNumber of the range. 
             * The function will return a value that is >= LowNumber and <= HighNumber.
            */
            Console.Write("Enter your Low Number: "); 
            lowNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your High Number: ");
            highNumber = Convert.ToInt32(Console.ReadLine());
            intList = new List<int>();
            noDupList = new List<int>();
            for (var i = lowNumber; i <= highNumber; i++)
                {
                    int randomNumber = IntUtil.Random(lowNumber, highNumber);
                    Console.WriteLine("Random number : {0:G}\n", randomNumber);
                    intList.Add(randomNumber);
                }
            Console.WriteLine("Random number count (possible duplicates) : {0:G}\n", intList.Count);
            Console.WriteLine("Removing Duplicates !!!");
            noDupList = IntUtil.RemoveDuplicates(intList);
            for (int i = 0; i < noDupList.Count; i++)
            {
                Console.WriteLine("List value : {0:G}\n", noDupList[i]);
            }
            Console.WriteLine("List value count : {0:G}\n", noDupList.Count);
        }
    }
}