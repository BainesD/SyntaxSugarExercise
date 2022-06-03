using System;

namespace SyntaxSugarEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //code sweetened with syntax sugar
            var answer = 4;
            //for an even more fun option 4 can be replaced with int.parse(Console.ReadLine()); to allow for user input 
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response); //I used this to test the output and ensure it was correct. Not necessary
            
            //original code
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}
        }
    }
}
