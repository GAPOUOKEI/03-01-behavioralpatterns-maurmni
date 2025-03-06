using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class WaitingState : IBotState
    {
        public void HandleInput(Bot bot, string input)
        {
            if (input.StartsWith("/start"))
            {
                Console.WriteLine("Бот: введите команду");
                bot.SetState(new Exexutation());
            }
            else
            {
                Console.WriteLine("Бот: ожидаю команду запуска (/start)");
            }
        }
    }
}
