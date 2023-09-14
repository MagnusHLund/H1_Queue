using H1_Queue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Queue.Controller
{
    internal class Controller
    {
        Queue<Person> people = new Queue<Person>();

        View.View view = new View.View();

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

        void AddPeople()
        {
            try
            {
                view.Message("How many people do you wanna add?");

                int value = short.Parse(view.RL());


                // Add code: Add new people to the list

                view.WaitOnUser();
            }
            catch
            {
                view.Message("Invalid input! Write a number.");
            }
        }

        void Delete()
        {

            try
            {
                int value = short.Parse(view.RL());
                view.WaitOnUser();
            }
            catch
            {
                view.Message("Invalid input! Write a number.");
            }
        }

        void MinMax()
        {
            for (int i = 0;  i < people.Count; i++)
            {
                if(i == 0 || i == people.Count)
                {
                    view.Message($"{people.ToArray()[i]}");
                }
            }
        }

        void Search()
        {
            view.Message("Which name fou wanna search for?");

            string input = view.RL();

            foreach (Person person in people)
            {
        //        view.Message(person.name.Contains(input));
            }
        }

        void OutputAll()
        {
            foreach (Person person in people)
            {
                view.Message(person.ToString());
            }
        }
    }
}
