using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Queue.View
{
    internal class View
    {
        /// <summary>
        /// Writes a custom message to the console, based on the parameter
        /// </summary>
        /// <param name="message"></param>
        internal void Message(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Outputs the header of the program, 
        /// which includes the total amount of people in queue on this "website", that they are in queue to enter.
        /// The header is always displayed.
        /// </summary>
        /// <param name="people"></param>
        internal void TopMenu(int people) 
        {
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("               KRØLLS BANK\n");
            Console.WriteLine($"     There are {people} people in queue\n");
            Console.WriteLine("----------------------------------------\n");
        }

        /// <summary>
        /// Outputs the options. This output happens whenever the program starts and repeats.
        /// It shows each possible input that the user can write, which then calls the appropriate method.
        /// </summary>
        internal void Options()
        {
            // Our menu has 6 options, instead of the 7 in the assignment,
            // due to "3. Show the number of items" already being displayed in the menu header.
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Delete items");
            Console.WriteLine("3. Show the first and last item");
            Console.WriteLine("4. Find item");
            Console.WriteLine("5. Print all items");
            Console.WriteLine("6. exit");
        }

        /// <summary>
        /// This waits on the user to press enter, then it will clear the console.
        /// </summary>
        internal void WaitOnUser()
        {
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

        /// <summary>
        /// This returns a string, which includes the ReadLine value.
        /// </summary>
        /// <returns></returns>
        internal string RL()
        {
            return Console.ReadLine(); 
        }
    }
}
