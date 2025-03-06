using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Exexutation : IBotState
    {
        public void HandleInput(Bot bot, string input)
        {
            if (input.StartsWith("/help"))
            {
                Console.WriteLine("Бот: доступные команды: /start, /help, /send");
            }
            else if (input.StartsWith("/send"))
            {
                Console.WriteLine("Бот: введите сообщение для отправки");
                bot.SetState(new SendingMessage());
            }
            else
            {
                Console.WriteLine("Бот: неизвестная команда");
            }
        }
    }
}
