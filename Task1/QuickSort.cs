using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class QuickSort : SosrtTemplate
    {
        protected override void PerformSort(int[] data)
        {
            QuickSortRecursive(data, 0, data.Length - 1);
        }

        private void QuickSortRecursive(int[] data, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(data, low, high);
                QuickSortRecursive(data, low, pi - 1);
                QuickSortRecursive(data, pi + 1, high);
            }
        }
        private int Partition(int[] data, int low, int high)
        {
            int pivot = data[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (data[j] < pivot)
                {
                    i++;
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }

            int temp1 = data[i + 1];
            data[i + 1] = data[high];
            data[high] = temp1;

            return i + 1;
        }
    }
}
