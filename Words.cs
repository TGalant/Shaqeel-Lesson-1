using System;
using System.Collections.Generic;
using System.Text;
//contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.8

public static class Words
    {
            public static string CountCharactersInSentence(string inputString)
        //created a method called CountCharactesInSentence
        //if we have a string method we gotta return string variable
        //if we have a int method we return a int
        {

            string New_inputString = inputString;
            // created a new string called new_inputString
            //new string equal to input String which holds a value of Hello World
            string print = "";
            //creating a string variable named it r
            // equal to nothing because we will use this as a base to print our int with a string
            
            New_inputString = New_inputString.Replace(" ", string.Empty);
            //this line of code takes away the empty spaces
            //the variable new string will be equal to itself with an additional function called dot replace
            //dot replace is a built in function which is called upon by the using system collection generic
            
                   //hello world
            while (New_inputString != "")
            //while loop
            //while hello world is not equal to nothing 
            // != means not equal to
            /*while(1 != 10)
            {
                1++
            }
            */
            {
                                  //this value is h
                                  //new_inputstring[1] this will be equal to e
                                  //new_inputstring[2] this will be equal to l
                char characters = New_inputString[0];  
                //char first character variable is equal to new string which has a value of Hello world 
                //however the square brackets with the zero inside of it indicates that hello world has become an array
                //an array starts at zero therefore new string block brackets is equal to the letter h
                int Repeats = 1;
                //created a int variable which contain numbers 
                //the reason why we have it equal to 1 is because if we encounter a character it should start at 1
                for (int j = 1; j < New_inputString.Length; j++)
                //for loop
                //inside a for loop we created a variable equal to j
                //we compare j which has a value of 1 to see if its less than new inputstring
                //.length is a built in function which converts a string to an integer
                //++ always means that we are adding one to the variable
                {
                    if (New_inputString[j] == characters)
                    //when the new inputstring [j] which is an array 
                    // == means to compare
                    //we comparing to see if the character are the same
                    {
                        Repeats++;
                        //if so add 1 to repeats which has a value of 1
                    }
                }
                print += " " + characters + " : " + Repeats + " ";
                //r is a empty string but at this stage we are adding the variables first and repeats
                New_inputString = New_inputString.Replace(new String(characters, 1), string.Empty);
            }
            return print;
            //return the string to program cs to be printed out on the console.writeline
        }
    }
           