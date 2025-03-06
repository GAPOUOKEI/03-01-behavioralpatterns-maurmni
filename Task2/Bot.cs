using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Bot
    {
        private IBotState _currentState;

        public Bot()
        {
            _currentState = new WaitingState(); 
        }

        public void SetState(IBotState newState)
        {
            _currentState = newState;
        }

        public void HandleInput(string input)
        {
            _currentState.HandleInput(this, input);
        }
    }
}
