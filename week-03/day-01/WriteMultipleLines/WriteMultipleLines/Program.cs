﻿using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\L\Documents";
            Console.Write("Give me a number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a word: ");
            string inputString = Console.ReadLine();

            try
            {
                MultipleLinesWriter(path, inputString, inputNumber);
            }
            catch (Exception)
            {

            }
            finally
            {
                Console.ReadLine();
            }
        }

        static void MultipleLinesWriter(string path, string word, int number)
        {
            string[] content = File.ReadAllLines(path + @"\doksi.txt");

            for (int i = 0; i < number; i++)
            {
                using (StreamWriter outputFile = new StreamWriter(path + @"\doksi.txt", true))
                {
                    outputFile.WriteLine(word);
                }
            }
        }
    }
}

// Create a function that takes 3 parameters: a path, a word and a number,
// than it should write to a file.
// The path parameter should be a string, that describes the location of the file.
// The word parameter should be a string, that will be written to the file as lines
// The number paramter should describe how many lines the file should have.
// So if the word is "apple" and the number is 5, than it should write 5 lines
// to the file and each line should be "apple"
// The function should not raise any error if it could not write the file.