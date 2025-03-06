using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class SendingMessage : IBotState
    {
        public void HandleInput(Bot bot, string input)
        {
            Console.WriteLine($"Бот: cообщение отправлено: {input}");
            bot.SetState(new WaitingState());
        }
    }
}
