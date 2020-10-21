using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 12, 21.22, 23.344, 5555.4, 12, 21.22, 23.344 };
            Console.WriteLine(SearchSumEqual.Get(array));
        }
    }
}
