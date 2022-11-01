using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringsArraysAndLists
{
    public class Exercises
    {
        // The first four exercises can be procedures if you wish
        // Please add appropriate calling code to Program.cs

        // Add tests as well as calling code for the exercises where you use functions

        // 1: Arrays
        // Create an array of doubles each of which holds three coordinates
        // Print these to the screen

        public static void Arrays()
        {
            double[,] coords = new double[3, 3] { { 0, 1, 2 }, { 0, 1, 2 }, { 0, 1, 2 } };
 
            Console.WriteLine(String.Join(" ", coords.Cast<double>())); // or method from examples

        }

        // 2: Byte Arrays
        // i) Create an array of bytes that represents the word hello. Convert this to a string and output the result.
        // ii) Convert the word hello both in Chinese and in English to bytes. Output the byte array. 

        public static void ByteArrays()
        {
            byte[] helloArray = new byte[5] { 104, 101, 108, 108, 111 };
            Console.WriteLine("byte[] to string hello: " + System.Text.Encoding.Default.GetString(helloArray));

            string hello = "hello";
            string helloCh = "你好";

            byte[] helloConvertedArray = System.Text.Encoding.Default.GetBytes(hello);
            byte[] helloChConvertedArray = System.Text.Encoding.Default.GetBytes(helloCh); //using ASCII for chinese character returns 2 decimal character code for question mark 

            Console.WriteLine("hello bytes " + string.Join(",", helloConvertedArray));
            Console.WriteLine("chinese hello bytes: " + string.Join(",", helloChConvertedArray));
        }

        // 3: Temperatures
        // Populate a list of doubles to represent daily temperatures over two weeks
        // Calculate and output the min, max and average temperatures over the time period
        // Sort the list in ascending order and print it out

        public static void Temperatures()
        {
            List<double> temps = new List<double>() { 15.5, 13, 12, 10, 19, 14, 16 };
            Console.WriteLine("min: {0}, max: {1}, average: {2}", temps.Min(), temps.Max(), temps.Average().ToString("G3"));
            temps.Sort();
            Console.WriteLine("sorted temps: " + string.Join(",", temps));
        }


        // 4: Students
        // Populate a list of student data with a firstname, surname and date of birth. Use a tuple.
        // Print the names of the oldest and youngest students
        // Print out how many students were born after 2010
        // Create a new list of strings with the full names of all the students and print this out     

        public static List<string> Students()
        {
            List<Tuple<string, string, DateTime>> students = new List<Tuple<string, string, DateTime>>();

            DateTime today = DateTime.Today;
            
            Tuple<string, string, DateTime> studentData1 = new Tuple<string, string, DateTime>("Alex", "Rathour", new DateTime(2006, 5, 18));
            Tuple<string, string, DateTime> studentData2 = new Tuple<string, string, DateTime>("John", "White", new DateTime(2013, 9, 20));
            Tuple<string, string, DateTime> studentData3 = new Tuple<string, string, DateTime>("Bob", "Green", new DateTime(1976, 3, 21));

            students.Add(studentData1);
            students.Add(studentData2);
            students.Add(studentData3);

            //students.OrderBy(x => x.Item3.Date);

            students = students.OrderByDescending(x => x.Item3).ToList();

            Console.WriteLine("The youngest student is {0}", students[0].Item1);
            Console.WriteLine("The oldest student is {0}", students.Last().Item1);

            int post2010Count = students.Count(x => x.Item3.Year > 2010);

            Console.WriteLine("{0} student(s) were born after 2010", post2010Count);

            List<string> names = new List<string>();

            foreach (var tuple in students)
            {
                names.Add(tuple.Item1 + " " + tuple.Item2);
            }

            return names;
            

        }

        // 5: Pig Latin
        // Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
        // Leave punctuation marks untouched.
        // The cat sat on the mat. => heTay atcay atsay noay hetay atmay.
        public static string PigLatin(string input)
        {
            List<string> splitString = input.Split().ToList();

            for (int i = 0; i < splitString.Count; i++)
            {
                char punc = ' ';

                for (int j = 0; j < splitString[i].Length; j++)
                {
                    if (char.IsPunctuation(splitString[i], j))
                    {
                        punc = splitString[i][j];
                        splitString[i] = splitString[i].Remove(j,1);

                    }
                }
                
                splitString[i] = splitString[i].Substring(1) + splitString[i].Substring(0,1) + "ay" + punc;
                //include punctuation not on end of word?
                //can be done by storing position of j and inserting back at j-1 (unless first character)

            }

            string pigSentence = String.Join(' ', splitString);

            return pigSentence;

        }

        // 6. Mexican wave
        //  1.  The input string will always be lower case but maybe empty.
        //  2.  If the character in the string is whitespace then pass over it as if it was an empty seat
        // Example
        // Wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]
        public static List<string> Wave(string input)
        {
            throw new NotImplementedException();
        }

        // 7. Anagram
        // Given a word and a list of words return the number of words that are anagrams of the others
        // Anagram("star", ["rats", "arts", "arc"]) => 2
        public static int Anagram(string input, string[] possibleAnagrams)
        {
            throw new NotImplementedException();
        }

        // 8. Variable Name helper
        public enum VariableNameType
        {
            CamelCase,
            PascalCase,
            SnakeCase
        }
        // Return the string in either camelCase, PascalCase or snake_case depending on the user choice
        public static string WriteVariableName(string input, VariableNameType caseNeeded = VariableNameType.CamelCase)
        {
            throw new NotImplementedException();
        }

        // 9. Binary search
        // The function should take a sorted list. You can sort it in the calling code using default sort.
        // Use a binary search to find the requested value (write this yourself)
        // It should return the index of the value found or -1 if it isn't found
        public static int BinarySearch(List<decimal> values)
        {
            throw new NotImplementedException();
        }
    }
}
