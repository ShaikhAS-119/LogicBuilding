using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Enhancement
{
    internal class DeleteElementArray
    {
        public static void Delete()
        {
            int[] arr = new int[7];
            arr[0] = 2;
            arr[1] = 3;
            arr[2] = 4;
            arr[3] = 5;

            Print(arr);
            Console.WriteLine();
            
            Console.WriteLine("Enter the value: ");
            int val = Convert.ToInt32(Console.ReadLine());

            //shifting element
            int item = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == val)
                {
                    item = i;
                }                
            }

            for (int i = item; i < arr.Length-1 ; i++)
            {
                arr[i] = arr[i+1];
            }

            Print(arr);
        }
        public static void Print(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(" " + n[i]);
            }

        }
    }
}
