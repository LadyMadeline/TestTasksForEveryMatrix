using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static int[] ArrayCombineAndSort(int[] firstArray, int[] secondArray)
        {
            int newArrayLength = firstArray.Length + secondArray.Length;
            int[] newArray = new int[newArrayLength];
            int[] longArray;
            int[] shortArray;
            
            if (firstArray.Length >= secondArray.Length)
            {
                longArray = firstArray;
                shortArray = secondArray;
            }

            else
            {
                longArray = secondArray;
                shortArray = firstArray;
            }

            for (int i = 0; i < longArray.Length; i++)
            {

                if (newArray[i + shortArray.Length - 1] > longArray[i] && i >= shortArray.Length)
                {
                    newArray[i + shortArray.Length] = newArray[i + shortArray.Length - 1];
                    newArray[i + shortArray.Length - 1] = longArray[i];
                }

                else if (i >= shortArray.Length)
                {
                    newArray[i + shortArray.Length] = longArray[i];
                }

                else if (shortArray[i] > longArray[i] || shortArray[i] == longArray[i])
                {
                    newArray[i * 2] = longArray[i];
                    newArray[i * 2 + 1] = shortArray[i];
                }

                else
                {
                    newArray[i * 2] = shortArray[i];
                    newArray[i * 2 + 1] = longArray[i];
                }
                
            }

            return newArray;
        }


        static void Main(string[] args)
        {
            ArrayCombineAndSort(new int[] { 2, 5, 6, 8, 12, 42, 54 }, new int[] { 2, 4, 8, 34 });
        }
    }
}
