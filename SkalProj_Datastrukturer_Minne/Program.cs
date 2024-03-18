using System;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 6, 7, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. Check Parenthesis"
                    + "\n7. Reverse a Text"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
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
                    case '7':
                        ReverseText();
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

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            bool examineList = true;
            List<string> theList = new List<string>();
            Console.WriteLine("Write something with + prefix to add it to the list, with - to remove it or only 0 to return to the main menu.");
            while (examineList)
            {
                //Console.WriteLine("Listans kapacitet är just nu: " + theList.Capacity);
                //Console.WriteLine("Listans storlek är just nu: " + theList.Count);
                string input = Console.ReadLine()!;
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    case '0':
                        examineList = false;
                        break;
                    default:
                        Console.WriteLine("Use only + or - in the front!");
                        break;
                }
            }
            /*
2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
När listans storlek överskrider listans kapacitet.
3. Med hur mycket ökar kapaciteten?
Med dubbelt så mycket kapacitet som finns. Initialt med 4 om man inte angav en initial kapacitet i listans konstruktör.
4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
För att balansera prestanda och minnesanvändning genom att minska antalet reallokeringar och kopieringar.
När listan når sin nuvarande kapacitet, skapas en ny intern array med dubbelt så stor kapacitet. De befintliga elementen kopieras till den nya arrayen, och det nya elementet läggs till.
Detta gör att listan kan hantera en ökande mängd data effektivt utan att behöva reallokera minne för varje enskilt element. 
5. Minskar kapaciteten när element tas bort ur listan?
Nej.
6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
•  När man ska ha en fast kapacitet och vet exakt hur stor den ska vara.
•  Om man har mycket stora datamängder och prestanda är avgörande.  Direkt åtkomst till element i en array är snabbare eftersom det inte finns  någon overhead för metoder som Add, Remove, etc. 
•  Om man behöver finjustera minnesanvändningen och hantera minnet manuellt. Man har full kontroll över minnesallokering och frigöring.
             */
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            bool examineQueue = true;
            Queue<string> theQueue = new Queue<string>();
            Console.WriteLine("Write a name with + prefix to add it at the end of the queue, - to remove the name from the front of it or only 0 to return to the main menu.");
            while (examineQueue)
            {
                string input = Console.ReadLine()!;
                char nav = input[0];
                string name = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(name);
                        break;
                    case '-':
                        theQueue.Dequeue();
                        break;
                    case '0':
                        examineQueue = false;
                        break;
                    default:
                        Console.WriteLine("Use only + or - ");
                        break;
                }
            }
            /* After debugging the queue, I saw that it behaves exactly as a list regarding the size (Count) and the capacity. Enqueuing is the same as Add in a list. Dequeuing is removing the element that was enqueued earliest being at index 0 in the underlying array.
             */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            bool examineStack = true;
            Stack<string> theStack = new Stack<string>();
            Console.WriteLine("Write a name with + prefix to add it to the stack, - to remove the last added from the stack or only 0 to return to the main menu.");
            while (examineStack)
            {
                string input = Console.ReadLine()!;
                char nav = input[0];
                string name = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theStack.Push(name);
                        break;
                    case '-':
                        theStack.Pop();
                        break;
                    case '0':
                        examineStack = false;
                        break;
                    default:
                        Console.WriteLine("Use only + or - ");
                        break;
                }
            }
            /* After debugging the stack, I saw that it behaves exactly as a list regarding the size (Count) and the capacity. Pushing is adding elements in reverse order in the underlying array. The last element is always added at index 0, pushing the earlier added elements to newer indexes. Poping is removing the last added element in the stack being at index 0. That's why is not a good ideea to simulate an ICA queue on a stack (it is not first in first out, but last in, first out order).
             */
        }

        static void ReverseText()
        {
            Stack<char> stack = new Stack<char>();
            Console.WriteLine("Write a text that you want to see it printed in the reverse order: ");
            string input = Console.ReadLine()!;
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            foreach (var elem in stack)
            {
                Console.Write(elem);
            }
            Console.WriteLine();
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            Stack<char> stack = new Stack<char>();
            Console.WriteLine("Write a text with paranthesis: ");
            string input = Console.ReadLine()!;
            bool correct = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push('(');
                }
                if (input[i] == ')')
                {
                    if (stack.Peek() == '(')
                        stack.Pop();
                    else
                    {
                        correct = false;
                        break;
                    }
                }
                if (input[i] == '[')
                {
                    stack.Push('[');
                }
                if (input[i] == ']')
                {
                    if (stack.Peek() == '[')
                        stack.Pop();
                    else
                    {
                        correct = false;
                        break;
                    }
                }
                if (input[i] == '{')
                {
                    stack.Push('{');
                }
                if (input[i] == '}')
                {
                    if (stack.Peek() == '{')
                        stack.Pop();
                    else
                    {
                        correct = false;
                        break;
                    }
                }
            }
            if (stack.Count > 0)
            {
                correct = false;
            }
            if (correct)
                Console.WriteLine("Paranthesis in this string is Correct!");
            else Console.WriteLine("Paranthesis in this string is Incorrect!");
        }

    }
}

