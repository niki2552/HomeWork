using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SequencesOfEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            for (int i = 0; i < words.Length-1; i++)
            {
                Console.Write(words[i]+" ");
               if (!words[i].Equals(words[i + 1]))
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine(words[words.Length-1]);
            Console.WriteLine();

            
        }
    }
}
