using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
			    {
                    Console.Write(arr[i] + " ");
			    }
            }
            void SortArray(int[] arr)
            {
                int index = 0;
                int tmp = 0;
                for (int i = 0; i < arr.Length; i++)
			    {
                   index = i;
                   while (index>0 && arr[index-1] > arr[index])
                   {
                        tmp = arr[index-1];
                        arr[index-1] = arr[index];
                        arr[index] = tmp;
                        index--;
                   }
        
			    }
            }
            int[] array = { 2, 3, 1, 5, 6, 1 };
            PrintArray(array);
            SortArray(array);
            Console.WriteLine("\nПосле сортировки:");
            PrintArray(array);
            Console.ReadLine();
        }

    }
}
