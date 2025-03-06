using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class ToDoList
    {
        private List<string> _tasks = new List<string>();

        public void AddTask(string task)
        {
            _tasks.Add(task);
            Console.WriteLine($"Задача добавлена: {task}");
        }

        public void RmoveTask(string task)
        {
            if (_tasks.Remove(task))
            {
                Console.WriteLine($"Задача удалена: {task}");
            }
        }

        public void ShowTasks()
        {
            Console.WriteLine("Текущие задачи:");
            foreach (var task in _tasks)
            {
                Console.WriteLine($"- {task}");
            }
        }
    }
}
