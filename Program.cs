using System.Collections.Generic;
namespace StakQueueAndFilesTask
{
    internal class Program
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


        static Stack<char> ReverseWord = new Stack<char>();
        static void Main(string[] args)
        {
            // we use while loop to repeat the process and we set true so it will not stop ... 
            while (true)
            {
                //just to clear the screen ...
                Console.Clear();
                Console.WriteLine("System Menu \n");
                Console.WriteLine("Select option: ");
                Console.WriteLine("1. Reverse a String Using Stack");
                Console.WriteLine("2. Evaluate Postfix Expression");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");
                Console.WriteLine("6. ");
                Console.WriteLine("7. ");
                Console.WriteLine("0. Exit the system");

                Console.Write("\nEnter your option: \n");
                int choice = int.Parse(Console.ReadLine());

                //switch condation to choose between the functions ...
                switch (choice)
                {
                    case 1:
                        string word;
                        Console.WriteLine("Enter your word:");
                        word = Console.ReadLine();
                        //to call the UniqueWordsExtractor method ...
                        ReverseStringUsingStack(word); 
                        break;
                    //case 2: ViewAllRooms(); break;
                    //case 3: ReserveRoomForGues(); break;
                    //case 4: ViewAllReservationsWithTotalCost(); break;
                    //case 5: SearchReservationByGuestName(); break;
                    //case 6: FindHighestPayingGuest(); break;
                    ///case 7: CancelReservationByRoomNumber(); break;
                    case 0: Console.WriteLine("Have a nice day ..."); return;
                    default: Console.WriteLine("\n You enter unaccepted option! ... to try again click enter key"); break;
                }
                // we add this line just to stop the program from clear 'Console.Clear();'
                // the screen before the user see the result ...
                Console.ReadLine();
            }            
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
