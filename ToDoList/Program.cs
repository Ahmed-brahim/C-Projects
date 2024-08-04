using System.Transactions;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            PersonalList List1 = new PersonalList();
            Console.Write("loading");
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(100);
                Console.Write(".");
            }
            Console.Clear();
            Console.WriteLine("Welcome To To-Do-List Applictaion");
            while(true)
            {
                Console.WriteLine("1. Add Task To list\n2. Remove Task From list\n3. Show List\n4. mark task as done\nenter your choice (Q or q for Quite): ");
                choice = Console.ReadLine()[0];
                if (choice == '1')
                {
                    Console.Write("Enter task name: ");
                    string taskname = Console.ReadLine();

                    List1.AddTask(taskname);
                }
                else if (choice == '2')
                {
                    Console.Write("Enter task number to remove :");
                    List1.RemoveTask(int.Parse(Console.ReadLine()));
                }
                else if (choice == '3')
                {
                    List1.DisplayTasks();
                }
                else if (choice == '4')
                {
                    Console.Write("Enter task number to mark as done :");
                    List1.MarkTaskAsDone(int.Parse(Console.ReadLine()));
                }
                else
                {
                    break;
                }
            }
        }
    }
}


