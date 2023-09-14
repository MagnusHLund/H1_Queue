using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Queue.View
{
    internal class View
    {
        internal void Message(string message)
        {
            Console.WriteLine(message);
        }

        internal void TopMenu(int people) 
        {
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("               KRØLLS BANK\n");
            Console.WriteLine($"     There are {people} people in queue\n");
            Console.WriteLine("----------------------------------------\n");
        }

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

        internal void WaitOnUser()
        {
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

        internal string RL()
        {
            return Console.ReadLine(); 
        }
    }
}
