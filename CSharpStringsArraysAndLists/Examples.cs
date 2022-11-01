using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringsArraysAndLists
{
    public class Examples
    {
        // Arrays
        public static void UsingArrays()
        {
            // Arrays are fixed in size and must be of one type
            int[] numbersA = new int[5];
            numbersA[3] = 12;
            Console.WriteLine(string.Join(",", numbersA));
            // numbers[6] = 22;

            int[] numbersB = {4, 6, 8, 12, 9};
            Console.WriteLine(string.Join(",", numbersB));

            // They can have multiple dimensions
            int[,] coordinatesA = new int[2, 2];
            coordinatesA[0, 0] = 1;
            coordinatesA[0, 1] = 3;
            Console.WriteLine(PrintCoordinates(coordinatesA));

            int[,] coordinatesB = { { 1, 3 }, { 2, 4 } };
            Console.WriteLine(PrintCoordinates(coordinatesB));
        }

        public static string PrintCoordinates(int[,] coordinates)
        {
            string ret = string.Empty;
            for (int i=0; i < coordinates.GetLength(0); i++)
            {
                ret += "[";
                for (int j=0; j < coordinates.GetLength(1); j++)
                {
                    ret += $"{coordinates[i, j]}, ";
                }
                ret = ret.TrimEnd(',', ' ') + "] ";
            }
            return ret;
        }


        // Creating Lists
        public static void CreatingLists()
        {
            // Lists are not fixed in size. They must be of one type
            List<int> numbersA = new List<int>();
            numbersA.Add(12);
            numbersA.Add(10);
            numbersA.Add(11);
            Console.WriteLine(string.Join(",", numbersA));

            List<int> numbersB = new List<int> { 4, 6, 8, 12, 9 };
            Console.WriteLine(string.Join(",", numbersB));

            // You can have a list of lists
            List<List<int>> coordinatesA = new List<List<int>>();

            // A list of any defined type including your own
            List<DateTime> holidayDates = new List<DateTime>();

            // A list of Tuples (a light weight data structure)             
            List<(int X, int Y)> coordinatesB = new List<(int X, int Y)>();
            coordinatesB.Add((1, 3));
            coordinatesB.Add((X: 2, Y: 3));
            Console.WriteLine(string.Join(",", coordinatesB));            
        }

        // Using Lists
        public static void UsingLists()
        {
            List<int> numbers = new List<int> { 4, 6, 8, 12, 9 };
            numbers.Add(2);
            numbers.RemoveAt(1);
            numbers.Reverse();
            Console.WriteLine(string.Join(",", numbers));

            int maxNumber = numbers.Max();
            int minNumber = numbers.Min();
            Console.WriteLine($"Min number is {minNumber}. Max number is {maxNumber}");

            List<int> greaterThanFour = numbers.Where(num => num > 4).ToList();
            Console.WriteLine(string.Join(",", greaterThanFour));

            List<int> doubled = numbers.Select(num => num * 2).ToList();
            Console.WriteLine(string.Join(",", doubled));

            List<string> names = new List<string> { "apple", "plum", "carrot", "sprout" };
            names.Sort();
            Console.WriteLine(string.Join(",", names));
        }


        // Converting a string to an array or a list and back again
        public static void StringToListAndBack()
        {
            string seasons = "Summer, Autumn, Winter, Spring";
            string[] stringArray = seasons.Split(", ");

            // array we cannot add to an array
            Console.WriteLine($"The string array is {stringArray.Length} items long");
            for (int i=0; i<stringArray.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {stringArray[i]}");
            }

            // List
            List<string> stringList = stringArray.ToList();
            stringList.Add("Christmas");
            Console.WriteLine($"The string list is now {stringList.Count} items long");

            // Turn it back into a string again
            string newString = string.Join(", ", stringList);
            Console.WriteLine(newString);
        }

        public static void ImmutableStrings()
        {
            // Immutable strings
            // Each time we change a string a new string instance gets created in memory
            string nameA = "Fred";
            string nameB = nameA;
            Console.WriteLine($"nameA:{nameA} nameB:{nameB}");
            nameA = "James";
            Console.WriteLine($"nameA:{nameA} nameB:{nameB}");
        }

        public static void UsingAStringBuilder()
        {
            // Each time we change a string a new string instance gets created in memory
            // Thats why repeated concatenation is slow. Best to use a string builder.
            SlowConcatenation();
            FastConcatenation();
        }

        public static void SlowConcatenation()
        {
            DateTime start = DateTime.Now;
            string val = "";
            for (int i=0; i<20000; i++)
            {
                val += i;
            }
            TimeSpan duration = DateTime.Now - start;
            Console.WriteLine($"Value is {val.Length} characters long");
            Console.WriteLine($"It took {duration.TotalMilliseconds} milliseconds");
        }

        public static void FastConcatenation()
        {
            DateTime start = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 20000; i++)
            {
                sb.Append(i);
            }
            string val = sb.ToString();
            TimeSpan duration = DateTime.Now - start;
            Console.WriteLine($"Value is {val.Length} characters long");
            Console.WriteLine($"It took {duration.TotalMilliseconds} milliseconds");
        }

        // Some of the many functions we can use with strings and chars
        // Look them up in the documentation
        public static void UsefulStringAndCharFunctions()
        {
            string sentance = " The cat sat on the mat. ";
            Console.WriteLine($"cat appears at index {sentance.IndexOf("cat")}");
            Console.WriteLine($"trim removes white space: {sentance.Trim()}");
            Console.WriteLine($"We can replace characters: {sentance.Replace("cat", "dog")}");
            Console.WriteLine($"We can substring characters: {sentance.Substring(1, 3)}");
            Console.WriteLine($"Check the character type: {Char.IsPunctuation(sentance[3])}");    
        }

        
        
        
        
    }
}
