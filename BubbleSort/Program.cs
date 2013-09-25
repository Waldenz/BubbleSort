using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort<string> bsStr = new BubbleSort<string>();
            string[] strArr = { "c", "b", "a", "d", "f", "z" };
            bsStr.BubbleSortFunction(strArr);

            BubbleSort<int> bsInt = new BubbleSort<int>();
            int[] intArr = new int[] { 1, 9, 5, 8, 2, 7 };
            bsInt.BubbleSortFunction(intArr);

            Console.WriteLine("Success!");
            Console.ReadLine();
        }
    }
}
