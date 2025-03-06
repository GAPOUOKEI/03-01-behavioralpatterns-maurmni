using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task3
{
    internal class Comands
    {
        private Stack<ICommandcs> _undoStack = new Stack<ICommandcs>();
        private Stack<ICommandcs> _redoStack = new Stack<ICommandcs>();

        public void ExecuteCommand(ICommandcs command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                var command = _undoStack.Pop();
                command.Undo();
                _redoStack.Push(command);
            }
            else
            {
                Console.WriteLine("Нет действий для отмены.");
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                var command = _redoStack.Pop();
                command.Execute();
                _undoStack.Push(command);
            }
            else
            {
                Console.WriteLine("Нет действий для повтора.");
            }
        }
    }
}
