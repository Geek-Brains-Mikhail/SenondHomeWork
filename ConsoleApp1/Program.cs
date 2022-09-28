using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void FillArray(int[] arr )
            {
                Random rand = new Random(); ;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(5, 26);
                }
            }
            void PrintArray(int[] arr )
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ") ;
                }
            }
            void Subtraction(int [] arr )
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 10) arr[i] -= 10;
                }
            }
            int[] array = new int[15];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine(" ");
            Subtraction(array);
            PrintArray(array);
            Console.ReadLine();

        }
    }
}
