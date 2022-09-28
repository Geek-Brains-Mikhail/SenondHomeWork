using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void FillArray(int[] arr)
            {
                Random random = new Random();   
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(10, 31);
                }

            }
            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            int[] Search(int[]arr,int num)
            {
                int[] newArr = new int[0];
                int score = 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == num)
                    {
                        Array.Resize(ref newArr, score);
                        newArr[score-1] =i;
                        score++;
                    }
                }             
                return newArr;
            }


            int[] array = new int[25];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            Console.Write("Введите число K: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] newAraay = Search(array, number);
            Console.Write("Позиции вхождения числа k в массиве: ");
            PrintArray(newAraay);
            Console.ReadLine();
        }
    }
}
