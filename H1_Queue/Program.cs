namespace H1_Queue
{
    internal class Program
    {
        /// <summary>
        /// Calls the controller and exists static
        /// </summary>
        static void Main()
        {
            Controller.Controller controller = new();
            controller.StartController();
        }
    }
}