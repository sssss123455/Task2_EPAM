using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int num = 7;
            foreach (var item in Filter.FilterDigit(array, num))
            {
                Console.Write(item + " ");
            }
        }
    }
}
