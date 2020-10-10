using System;
//please let this text appear on github
using System.Collections.Generic;
using System.Text;

//contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.8


namespace MPS_Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {                                                       //string value
            string charCounts = Words.CountCharactersInSentence("Hello world");
            Console.WriteLine(charCounts);
        }
    }
}
