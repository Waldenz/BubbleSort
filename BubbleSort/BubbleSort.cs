using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class BubbleSort<T> where T : IComparable
    {
        public void BubbleSortFunction(T[] array)
        {
            foreach (T a in array)
            {
                Console.Write(a.ToString() + " ");
            }
            Console.WriteLine();

            int length = array.Length;
            T temp;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = length - 1; j > i; j--)
                {
                    if (array[j].CompareTo(array[j - 1]) < 0)
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }

            }

            foreach (T a in array)
            {
                Console.Write(a.ToString() + " ");
            }
            Console.WriteLine();
        }

    }
}
