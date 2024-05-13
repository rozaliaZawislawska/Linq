using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task4();
            foreach (var emp in t)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
