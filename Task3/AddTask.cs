using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class AddTask :ICommandcs
    {
        private ToDoList _tdl;
        private string _task;

        public AddTask(ToDoList tdl, string task)
        {
            _tdl =  tdl;
            _task = task;
        }

        public void Execute()
        {
            _tdl.AddTask(_task);
        }

        public void Undo()
        {
            _tdl.RmoveTask(_task);
        }
    }
}
