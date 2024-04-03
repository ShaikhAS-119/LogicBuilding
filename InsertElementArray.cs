using System;

namespace logic_enhancement
{
    internal class insertelementarray
    {
        public static void Insert()
        {
            int[] arr = new int[7];
            arr[0] = 2;
            arr[1] = 3;
            arr[2] = 4;
            arr[3] = 5;
            
            Print(arr);
            Console.WriteLine();
            //Note: array has fix size , if element is already filled the new
            //      value will overwrite
            Console.WriteLine("Enter the new value want to insert: ");
            int val = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the position between 1 to {arr.Length-1}: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            if (pos >= arr.Length || pos == 0)
            {
                throw new IndexOutOfRangeException();
            }

            //shifting
            for ( int i = arr.Length-1; i>pos-1; i--)
            {
                arr[i] = arr[i-1];
            }
            arr[pos-1] = val;
           
            Console.WriteLine();
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
