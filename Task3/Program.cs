/*
 * Создайте приложение для управления задачами (to-do list), где пользователи могут добавлять, удалять и помечать задачи как выполненные с помощью команд, а также отменять и повторять эти действия.
 */
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList tdl = new ToDoList();
            Comands commandManager = new Comands();
                     
            commandManager.ExecuteCommand(new AddTask(tdl, "Лечь спать"));
            commandManager.ExecuteCommand(new AddTask(tdl, "Купить  продукты"));
            commandManager.ExecuteCommand(new AddTask(tdl, "Сдать отчет до 20:00"));

            tdl.ShowTasks();

            commandManager.Undo();
            tdl.ShowTasks();

            commandManager.Undo();
            tdl.ShowTasks();

            commandManager.Undo();
            tdl.ShowTasks();
                        
        }
    }
}
