using System;
using System.Linq;

namespace USR3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Четные: {0}", arr.Count(i => i % 2 == 0));
            Console.WriteLine("Нечетные: {0}", arr.Count(i => i % 2 == 1));
        }
    }
}