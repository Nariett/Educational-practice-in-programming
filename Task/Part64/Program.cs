using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Action taskAction = () => {
            Console.WriteLine("Task started.");
            Task.Delay(1000).Wait();
            Console.WriteLine("Task in progress.");
            Task.Delay(1000).Wait();
            Console.WriteLine("Task finished.");
        };

        Task[] tasks = new Task[3];

        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = new Task(taskAction);
        }

        for (int i = 0; i < tasks.Length - 1; i++)
        {
            tasks[i].ContinueWith(_ => tasks[i + 1].Start());
        }

        tasks[0].Start();
        Task.WaitAll(tasks);
    }
}
