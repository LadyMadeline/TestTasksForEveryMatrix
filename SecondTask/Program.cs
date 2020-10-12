using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static int FindExtraNumber(int[] arrayWithExtraNumber)
        {
            int[] array100 = new int[100];

            for (int i = 0; i < array100.Length; i++)
            {
                array100[i] = i + 1;
            }

            int sumOf100 = array100.Sum();
            int sumOf101 = arrayWithExtraNumber.Sum();

            int result = sumOf101 - sumOf100;

            return result;
        }
        
        static void Main(string[] args)
        {
            int[] array101 = new int[101];

            for (int i = 0; i < array101.Length; i++)
            {
                array101[i] = i + 1;
            }

            array101[100] = 58;
            int result = FindExtraNumber(array101);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
