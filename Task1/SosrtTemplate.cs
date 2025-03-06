using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class SosrtTemplate
    {
        public void Sort(int[] data)
        {
            if (data.Length <= 1)
                return;

            Prepare(data);
            PerformSort(data);
        }

        // метод для реализации алгоритма сортировки
        protected abstract void PerformSort(int[] data);

        // ljg метод для подготовки данных 
        protected void Prepare(int[] data) { }
    }
}
