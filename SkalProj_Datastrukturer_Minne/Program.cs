using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {

        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. Reverse text"
                    + "\n0. Exit the application"
                    );
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break; 
                    case '5':
                        ReverserText();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        private static void ReverserText()
        {
            var stack = new Stack<Char>();
            var input = Console.ReadLine();

            foreach (var item in input)
            {
                stack.Push(item);
            }

           
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            List<string> theList = new List<string>();
            bool menu = true;
            do
            {
            Console.WriteLine("press + to add to the list or press - to remove from the list Q for exit");
            string input = Console.ReadLine();
            char nav = input[0];
            string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine("Added: " + value);
                        Console.WriteLine($"Count: {theList.Count}");
                        Console.WriteLine(theList.Capacity); 
                        break;

                    case '-':
                        theList.Remove(value);
                        Console.WriteLine("Subrtacted: " + value);
                        Console.WriteLine($"Count: {theList.Count}");
                        Console.WriteLine(theList.Capacity);
                        break;
                    
                    case 'Q':
                        menu = false;
                        break;
                }

            } while (menu);
           
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
                Queue<string> theQueue = new Queue<string>();
            bool menu = true;
            do
            {
                Console.WriteLine("Examine the queue + to add - to remove");
                var input = Console.ReadLine();
                var value = input.Substring(1);


                switch (input[0])
                {
                    case '+':
                        theQueue.Enqueue(value);
                        Console.WriteLine("In Queue: " + value);
                        Console.WriteLine($"Count: {theQueue.Count}");
                        break;

                    case '-':
                        if (theQueue.Count != 0)
                        theQueue.Dequeue();
                        Console.WriteLine($"Count: {theQueue.Count}");
                        break;

                    case 'Q':
                        menu = false;
                        break;
                }

            } while (menu);
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            Stack<string> theStack = new Stack<string>();
            bool menu = true;
            
            
            do
            {
               Console.WriteLine("Examine the queue + to push - to pop");
               string input = Console.ReadLine();
          
               

                switch (input[0])
                {
                    case '+':
                        theStack.Push(input);
                        Console.WriteLine("Push: " + input);
                      
                        break;

                    case '-':
                        theStack.Pop();
                        Console.WriteLine("pop: " + input);
                   
                        break;

                    case 'Q':
                        menu = false;
                        break;
                }

            } while (menu);
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            var input = "(())";
            var stack = new Stack<char>();
            var dict = new Dictionary<char, char>
            {
                {'(', ')' }
            };

            foreach (var c in input)
            {

                if (dict.ContainsKey(c))
                    stack.Push(c);


            }

            //Använd stack

            //loopa på inout

            //om öppnare spara undan annars fel
            //Stängare sparas aldrig
            //Har vi något kvar ? fel



        }
    }
}


//Frågor
//1: Stacken är en trave staplat på varandra som är självunderhållande. Den har koll på vilka metoder och
//anrop som körs och rensar bort dem allt efersom den blir klar med dem. Stacken börjar från början och 
//arbetar sig sedan igenom metoderna och anropen i ordning. Stacken är självunderhållande.
//Heapen har tillgång till allt vilket är en skillnad från stacken. Den kan snabbt komma åt det vi vill ha.
//Den behöver även oroa sig för garbage collection.

//2: Typer som kommer ifrån System.valuetype några exempel är Int, bool, Char, Float, Enum och Double.
//   Reference types ärver från System.object. Referenstyper är tex. Class, Interface, Object, Delegate och string.
//   Reference typer lagrar alltid på Heapen medans Value types kan lagras i både Stacken och på Heapen.

//3: Den första returnerar 3 eftersom x är satt som tre.
//   Den andra returnerar 4 eftersom y är lika med x och y är satt till 4 senare i koden.

//Frågor Examine list
// 2:Den ökar på rad 81-82. alltså efter att något blivit registrerat.
// 3: Den ökar med 4
// 4: vet ej
// 5: Nej den minskar inte
// 6: När man jobbar med fasta listor?

//Fråga Examine stack
// 1: Eftersom det skulle innebära att den som kom till kön först inte skulle få gå förrän alla andra gått.



