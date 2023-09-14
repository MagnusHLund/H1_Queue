using H1_Queue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace H1_Queue.Controller
{
    internal class Controller
    {
        Queue<Person> people = new Queue<Person>();

        View.View view = new View.View();


        /// <summary>
        /// StartController calls the other methods, including GUI in the view.
        /// Other methods are called based on user input.
        /// User input then gets checked in the switch, which then calls the appropriate method.
        /// </summary>
        public void StartController()
        {
            while (true)
            {
                view.TopMenu(people.Count());
                view.Options();

                string input = Console.ReadLine();

                switch (input)
                {
                    // Adds more people to the queue
                    case "1":
                        AddPeople();
                        break;
                    // Delete people from the queue
                    case "2":
                        Delete();
                        break;
                    // Outputs the first and last person in the queue
                    case "3":
                        MinMax();
                        break;
                    // Find item based on name
                    case "4":
                        Search();
                        break;
                    // Output all people in the queue
                    case "5":
                        OutputAll();
                        break;
                    // Exit program
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        view.Message("Invalid input! Write a number.");
                        break;
                }
            }
        }

        /// <summary>
        /// This adds people to our queue.
        /// Users decide how many they want to add,
        /// </summary>
        void AddPeople()
        {
            try
            {
                view.Message("How many people do you wanna add?");

                int value = short.Parse(view.RL());


                Person person = new Person();

                Random random = new Random();

                for (int i = 0; i < value; i++)
                {
                    string randomFirstName = person.firstNames[random.Next(person.firstNames.Length)];
                    string randomLastName = person.lastNames[random.Next(person.lastNames.Length)];
                    people.Enqueue(new Person() { FirstName = randomFirstName, LastName = randomLastName });
                }
            }
            catch
            {
                view.Message("Invalid input! Write a number.");
            }

            view.WaitOnUser();
        }

        /// <summary>
        /// Deletes a user specified amount of people from the queue
        /// </summary>
        void Delete()
        {
            try
            {
                view.Message("How many people do you wanna delete?");

                int value = short.Parse(view.RL());

                for(int i = 0; i < value; i++)
                {
                    people.Dequeue();
                }
            }
            catch
            {
                view.Message("Invalid input! Write a number.");
            }

            view.WaitOnUser();
        }

        /// <summary>
        /// Displays the first and last element inside the queue
        /// </summary>
        void MinMax()
        {
            view.Message("");

            short counter = 0;

            foreach(Person person in people)
            {
                if (counter == 0 || counter == people.Count-1)
                {
                    view.Message(person.FullName);
                }

                counter++;
            }

            view.WaitOnUser();
        }

        /// <summary>
        /// Allows the user to search for names, inside the queue
        /// </summary>
        void Search()
        {
            view.Message("Which name you wanna search for?");

            string input = view.RL().ToLower();

            foreach (Person person in people)
            {
                if (person.FullName.ToLower().Contains(input))
                {
                    view.Message(person.FullName);
                }
            }

            view.WaitOnUser();
        }

        /// <summary>
        /// Outputs all people in the queue
        /// </summary>
        void OutputAll()
        {
            foreach (Person person in people)
            {
                view.Message("\t" + person.FullName);
            }

            view.WaitOnUser();
        }
    }
}
