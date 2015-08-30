using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReverser
{
    class Reverser
    {
        static void Main(string[] args)
        {
            string line = "Hello My Friends";

            string reversed = ReverseText(line); //calling the ReverseText method from Main
            Console.WriteLine(reversed); //outputs the return value from ReverseText
            Console.ReadLine();
        }

        static string ReverseText(string line)  //reversetext method
        {
            StringBuilder sb = new StringBuilder();  //creating a new stringbuilder object called sb
            for(int i = line.Length - 1; i >= 0; i--) //for loop starts from the end of the string to beginning of string
            {
                sb.Append(line[i]);  //adding elements from line to sb object from end to start.
            }
            return sb.ToString(); //returning the object as a string to Main
        }
    }
}
