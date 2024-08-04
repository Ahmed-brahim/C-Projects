namespace ToDoList
{
    /// <summary>
    /// class to represent a task name and its status
    /// </summary>
    public class Task
    {
        string TaskName;
        public Status St;

        public Task(string taskName, Status status)
        {
            TaskName = taskName;
            St = status;
        }
        public override string ToString()
        {
            return TaskName;
        }
    }

    /// <summary>
    /// class to represent the list of tasks i have
    /// </summary>

    public class PersonalList
    {
        
        List<Task> Tasks = new List<Task>();
        public void AddTask(string TaskName)
        {
            Tasks.Add(new Task(TaskName, Status.NotFinished));//by default the added task was not finished
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("****Added Successfully****");
            System.Threading.Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();    
        }
        public void RemoveTask(int idx)
        {
            Tasks.RemoveAt(--idx);
            Console.Clear();
            Console.WriteLine($"Removed task {idx} successfully");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
        public void DisplayTasks()
        {
            int i = 1;
            foreach(var t in Tasks)
            {
                if(t.St == Status.Finished)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write($"{i++}. ");
                Console.WriteLine(t);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            if (Tasks.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("list is Empty");
                System.Threading.Thread.Sleep(1000);
                Console.Clear ();   
            }
        }
        public void MarkTaskAsDone(int idx)
        {
            Tasks[--idx].St = Status.Finished;
        }
    }

    /// <summary>
    /// enum to check if the task finished or not
    /// </summary>
    public enum Status  
    {
        Finished = 1,
        NotFinished = 0
    }
}