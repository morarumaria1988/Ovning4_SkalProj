using System;

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
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
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
                    //case '2':
                    //    ExamineQueue();
                    //    break;
                    //case '3':
                    //    ExamineStack();
                    //    break;
                    //case '4':
                    //    CheckParanthesis();
                    //    break;
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
            Console.WriteLine("Write something with + as prefix to add it to the list, with - to remove it or only 0 to return to the main menu.");
            while (examineList)
            {
                Console.WriteLine("Listans kapacitet är just nu: " + theList.Capacity);
                Console.WriteLine("Listans storlek är just nu: " + theList.Count);
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
                        Console.WriteLine("Use only + or - in front!");
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
•	När man ska ha en fast kapacitet och vet exakt hur stor den ska vara.
•	Om man har mycket stora datamängder och prestanda är avgörande.  Direkt åtkomst till element i en array är snabbare eftersom det inte finns någon overhead för metoder som Add, Remove, etc. 
•	Om man behöver finjustera minnesanvändningen och hantera minnet manuellt. Man har full kontroll över minnesallokering och frigöring.
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
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

