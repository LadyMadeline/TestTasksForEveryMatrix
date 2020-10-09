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

            for (int i = 1; i <= longArray.Length; i++)
            {

                if (newArray[i + shortArray.Length - 2] > longArray[i - 1] && i > shortArray.Length)
                {
                    newArray[i + shortArray.Length - 1] = newArray[i + shortArray.Length - 2];
                    newArray[i + shortArray.Length - 2] = longArray[i - 1];
                }

                else if (i > shortArray.Length)
                {
                    newArray[i + shortArray.Length - 1] = longArray[i - 1];
                }

                else if (shortArray[i - 1] > longArray[i - 1] || shortArray[i - 1] == longArray[i - 1])
                {
                    newArray[(i - 1) * 2] = longArray[i - 1];
                    newArray[(i - 1) * 2 + 1] = shortArray[i - 1];
                }

                else
                {
                    newArray[(i - 1) * 2] = shortArray[i - 1];
                    newArray[(i - 1) * 2 + 1] = longArray[i - 1];
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
