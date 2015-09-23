using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.Categorize
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            List<double> roundNums = new List<double>();
            List<double> floatNums = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 1) == 0)
                {
                    roundNums.Add(numbers[i]);
                }
                else
                {
                    floatNums.Add(numbers[i]);
                }
            }

            Console.WriteLine("[" + string.Join(", ", floatNums) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
                                floatNums.Min(), floatNums.Max(), floatNums.Sum(), floatNums.Average());

            Console.WriteLine("[" + string.Join(", ", roundNums) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
                                roundNums.Min(), roundNums.Max(), (int)roundNums.Sum(), roundNums.Average());
        }
    }
}
