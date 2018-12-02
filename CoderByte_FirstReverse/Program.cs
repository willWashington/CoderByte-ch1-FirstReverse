using System;

namespace CoderByte_FirstReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the C# language, create a function that reverses the string being passed and returns the largest word in the string. 
            //If there are two or more words that are the same length, return the first word from the string with that length. 
            //Ignore punctuation and assume _string will not be empty. 
            //https://www.coderbyte.com/editor/guest:Longest%20Word:Csharp

            Console.WriteLine(Reverser("This is a very long string that has a large number of words in it!"));
            Console.ReadLine();
        }

        public static string Reverser(string _string)
        {
            if (_string == null)
            {
                _string = " ";
            }
            string[] revString = _string.Split(null);
            string finString = " ";

            foreach (string str in revString)
            {
                if (str.Length > finString.Length) {
                    finString = str;                   
                }              
            }

            char[] charArray = finString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
