/*
 * Создайте бота для мессенджера, который может находиться в состояниях (ожидание ввода, выполнение команды, отправка сообщения). Поведение бота должно изменяться в зависимости от состояния.
 */
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bot bot = new Bot();

            bot.HandleInput("/start");
            bot.HandleInput("/help");
            bot.HandleInput("/send");
            bot.HandleInput("Привет, мир!");
            bot.HandleInput("/unknown");
        }
    }
}
