/*
 * Реализуйте сортировку массивов, используя шаблонный метод для определения различных алгоритмов сортировки (например, пузырьковая, быстрая, сортировка слиянием).
 */

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 64, 34, 25, 12, 22, 11, 90 };

            SosrtTemplate sorter = new BubbleSort();
            sorter.Sort(data);
            Console.WriteLine("ПУзырьковая сортировка: ");
            Console.WriteLine(string.Join(", ", data));

            int[] data2 = { 64, 34, 25, 12, 22, 11, 90 };
            sorter = new QuickSort();
            sorter.Sort(data2);
            Console.WriteLine("Быстрая сортировка:" );
            Console.WriteLine(string.Join(", ", data2));
        }
    }
}
