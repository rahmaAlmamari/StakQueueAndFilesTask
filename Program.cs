using System.Collections.Generic;
namespace StakQueueAndFilesTask
{
    internal class Program
    {
        static Stack<char> ReverseWord = new Stack<char>();
        static void Main(string[] args)
        {
            //Stack ....
            /*
             * 
             Easy 
             1. Reverse a String Using Stack 
                Input a string from the user and print its reverse using a stack. 
             2. Evaluate Postfix Expression  
                Evaluate an expression like "5 3 + 8 *" using a stack and print the result. 

             Medium 
             3. Browser History Navigation  
                Implement a simple browser history using a stack of links ( strings ). When the user navigates to a new 
                page, it’s added to the stack. When the user clicks the "back" button, the last visited page is popped from 
                the stack. 
             4. XML/HTML Tag Validator 
                Validate whether all HTML or XML tags in a file are properly nested and closed using a stack (e.g., 
                <div><p></p></div> is valid, but <div><p></div></p> is not).
             */

            //1 .....
            string word;
            Console.WriteLine("Enter your word:");
            word = Console.ReadLine();
            //to call the UniqueWordsExtractor method ...
            ReverseStringUsingStack(word);
        }

        //1. Reverse a String Using Stack ...
        public static void ReverseStringUsingStack(string par)
        {
            //to store the word ...
            foreach(char letter in par)
            {
                ReverseWord.Push(letter);
            }
            //to display the reverse of the word ...
            Console.WriteLine("The reverse of your word is:");
            foreach (char letter in ReverseWord)
            {
                Console.WriteLine(letter); 
            }
        }

    }
}
