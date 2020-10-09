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

            for (int i = 0; i < firstArray.Length || i < secondArray.Length; i++)
            {
                if (i >= firstArray.Length)
                {
                    if (newArray[i + firstArray.Length - 1] > secondArray[i])
                    {
                        newArray[i + firstArray.Length] = newArray[i + firstArray.Length - 1];
                        newArray[i + firstArray.Length - 1] = secondArray[i];
                    }

                    else
                    {
                        newArray[i + firstArray.Length] = secondArray[i];
                    }
                }

                else if (i >= secondArray.Length)
                {
                    if (newArray[i + secondArray.Length - 1] > firstArray[i])
                    {
                        newArray[i + secondArray.Length] = newArray[i + secondArray.Length - 1];
                        newArray[i + secondArray.Length - 1] = firstArray[i];
                    }

                    else
                    {
                        newArray[i + secondArray.Length] = firstArray[i];
                    }
                }

                else
                {
                    if (firstArray[i] > secondArray[i] || firstArray[i] == secondArray[i])
                    {
                        newArray[i * 2] = secondArray[i];
                        newArray[i * 2 + 1] = firstArray[i];
                    }

                    else
                    {
                        newArray[i * 2] = firstArray[i];
                        newArray[i * 2 + 1] = secondArray[i];
                    }
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
