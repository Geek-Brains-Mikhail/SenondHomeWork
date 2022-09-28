using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
            int SeacrhMaxOddElement(int[] arr)
            {
                int number = arr[0];
                int index = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i]%2!=0)
                    {
                        if (number < arr[i])
                        {
                            number = arr[i];
                            index = i;
                        }

                    }
                }
                return index;
            }
            void ShiftElementinArrayleft(int[] arr,int index)
            {
                int temporary1 = arr[0];
                int temporary2 = arr[0];
                for (int j = 0; j < 3; j++)
			    {
                    for (int i =arr.Length-1;i>=0; i--)
    			    {        
                        if(i==arr.Length-1)
                        {
                            temporary2 = arr[i];
                            arr[i] = arr[0];
                        }
                        else if(i!=index && i!=arr.Length-1)
                        {
                           temporary1 = arr[i];
                           arr[i] = temporary2;
                           temporary2 = temporary1;
                        }
                    }
			    }
                                                                    
         
            }
            void ShiftElementinArrayRight(int[] arr,int index)
            {
                int temporary1 = arr[0];
                int temporary2 = arr[0];

                for (int i =0;i<arr.Length; i++)
    			{        
                    if(i==0)
                    {
                        temporary2 = arr[i];
                        arr[i] = arr[arr.Length-1];
                    }
                    else if(i!=index && i !=0)
                    {
                        temporary1 = arr[i];
                        arr[i] = temporary2;
                        temporary2 = temporary1;
                    }
                }

                                                                    
         
            }
            int[] array = {1,2,5,3,4};
            PrintArray(array);
            Console.WriteLine("\nСдвиг влево");
            ShiftElementinArrayleft(array,SeacrhMaxOddElement(array));
            PrintArray(array);
            ShiftElementinArrayRight(array, SeacrhMaxOddElement(array));
            Console.WriteLine("\nСдвиг вправо   ");
            PrintArray(array);
            
            Console.ReadLine();
           
        }
    }
}
