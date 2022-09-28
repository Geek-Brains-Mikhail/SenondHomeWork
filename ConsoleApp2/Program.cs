using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void FillArray(int[] arr,Random randomNumbe)
            {
               
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = randomNumbe.Next(10, 31);
                }

            }
            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            void SumElementFirstAndSecondArray(int[] array1, int[] array2, int[] array3)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array3[i] = array1[i] + array2[i];
                }
            }
            int[] LastSearch(int[] array, int[] temporaryArr)
            {
                int min = array[0];
                int max = array[0];
                int arithmeticMean = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max) max = array[i];
                    if (array[i] < min) min = array[i];
                    arithmeticMean += array[i];
                }
                temporaryArr[0] = arithmeticMean;
                temporaryArr[1] = min;
                temporaryArr[2] = max;
                return temporaryArr;
            }
            int[] firstArray = new int[5];
            int[] secondArray = new int[5];
            int[] thirdArray = new int[5];
            int[] temporaryArrya = new int[3];
            Random rand = new Random();
            FillArray(firstArray,rand);
            PrintArray(firstArray);
            Console.WriteLine();

            FillArray(secondArray,rand);
            PrintArray(secondArray);
            Console.WriteLine();
            SumElementFirstAndSecondArray(firstArray, secondArray, thirdArray);
            PrintArray(thirdArray) ;
            LastSearch(thirdArray, temporaryArrya);
            Console.WriteLine() ;     
            Console.WriteLine("Среднее арифметическое чисел = " + (double)temporaryArrya[0]/thirdArray.Length);
            Console.WriteLine("Минимальное значение массива = " + temporaryArrya[1]);
            Console.WriteLine("Максимальное значение массива = " + temporaryArrya[2]);
            Console.ReadLine();
        }
    }
}
