using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class RmoveTask
    {
        private ToDoList _tdl;
        private string _task;

        public RmoveTask(ToDoList tdl, string task)
        {
            _tdl = tdl;
            _task = task;
        }

        public void Execute()
        {
            _tdl.RmoveTask(_task);
        }

        public void Undo()
        {
            _tdl.AddTask(_task);
        }
    }
}
