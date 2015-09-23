using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SortArrayOfNumbers
{
    class SortArray
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.Write(item);
                Console.Write(' ');
            }
            Console.WriteLine();
            //Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
