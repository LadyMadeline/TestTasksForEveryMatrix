using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
            int FAIndex = 0;
            int SAIndex = 0;

            for (int i = 0; i < newArrayLength; i++)
            {
                if (FAIndex >= firstArray.Length)
                {
                    newArray[i] = secondArray[SAIndex];
                    SAIndex++;
                }

                else if (SAIndex >= secondArray.Length)
                {
                    newArray[i] = firstArray[FAIndex];
                    FAIndex++;
                }
                
                else if (firstArray[FAIndex] > secondArray[SAIndex] || firstArray[FAIndex] == secondArray[SAIndex])
                {
                    newArray[i] = secondArray[SAIndex];
                    SAIndex++;
                }

                else if (firstArray[FAIndex] < secondArray[SAIndex])
                {
                    newArray[i] = firstArray[FAIndex];
                    FAIndex++;
                }
            }

            return newArray;
        }

        static bool IsValidArrayCombineAndSort(int amountOfTrials)
        {
            Random randNum = new Random();
            try
            {
                for (int j = 0; j <= amountOfTrials; j++)
                {
                    int lenOfFirstTestArray = randNum.Next(1, 100);
                    int[] test1 = Enumerable
                        .Repeat(0, lenOfFirstTestArray)
                        .Select(i => randNum.Next(0, 100))
                        .ToArray();

                    int lenOfSecondTestArray = randNum.Next(1, 100);
                    int[] test2 = Enumerable
                        .Repeat(0, lenOfSecondTestArray)
                        .Select(i => randNum.Next(0, 100))
                        .ToArray();

                    Array.Sort(test1);
                    Array.Sort(test2);
                    var trialValue = ArrayCombineAndSort(test1, test2);

                    var expectedValue = new int[test1.Length + test2.Length];
                    test1.CopyTo(expectedValue, 0);
                    test2.CopyTo(expectedValue, test1.Length);
                    Array.Sort(expectedValue);

                    for (int i = 0; i < trialValue.Length; i++)
                    {
                        if (expectedValue[i] != trialValue[i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        static void Main(string[] args)
        {
            var resultOfValidation = IsValidArrayCombineAndSort(10000);
            Console.WriteLine($"Is valid method?! {resultOfValidation}");
            Console.ReadKey();
        }
    }
}
