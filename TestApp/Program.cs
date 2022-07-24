using System;
using System.Linq;

namespace TestApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = {1, 8, 10, 0, -4, 5};
            SortArray(numbers);
        }

        private static void SortArray(int [] nums)
        {
            var l = nums.ToList();
            l.Sort();
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
