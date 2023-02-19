using System;
using System.Collections.Generic;
using System.Linq;

namespace HCLInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            //("Hello World!");
            Console.WriteLine(convertFirstLetterInUpperCase("hi test team helo"));
            Test();
        }
        public static string convertFirstLetterInUpperCase(string input)
        {
            List<string> Data = new List<string>();
            string returnData = string.Empty;
            Data=input.Split(' ').ToList();

            foreach (var item in Data)
            {
                var convertinArray = Data.ToArray();
                
                int i = 0;
                foreach (var item1 in convertinArray)
                {
                    if (i == 0)
                    {
                        returnData += item1.ToUpper().ToString();
                    }
                    else { 
                    returnData += item1;
                    }
                    i++;
                }
                returnData += ' ' + returnData;
            }
            return returnData;
        }
        static int firstzeroindex(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        static int firstZero(int[] arr, int low, int high)
        {
            if (high >= low)
            {
                // Check if mid element is first 0
                int mid = low + (high - low) / 2;
                if ((mid == 0 || arr[mid - 1] == 1) &&
                                     arr[mid] == 0)
                    return mid;

                if (arr[mid] == 1) // If mid element is not 0
                    return firstZero(arr, (mid + 1), high);

                else // If mid element is 0, but not first 0
                    return firstZero(arr, low, (mid - 1));
            }
            return -1;
        }

        // A wrapper over recursive function firstZero()
        static int countZeroes(int[] arr, int n)
        {
            // Find index of first zero in given array
            int first = firstZero(arr, 0, n - 1);

            // If 0 is not present at all, return 0
            if (first == -1)
                return 0;

            return (n - first);
        }
        public static void Test()
        {
            //// Declare the array of two elements.
            //int[][] arr = new int[2][];

            //// Initialize the elements.
            //arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            //arr[1] = new int[4] { 2, 4, 6, 8 };

            //// Display the array elements.
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    System.Console.Write("Element({0}): ", i);
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
            //    }
            //    System.Console.WriteLine();
            //}
            int[] arr = { -8,-7,-7,-3,1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 ,3,4,5,7,0,9};
            int n = arr.Length;
            int x = firstzeroindex(arr, n);
            //if (x == -1)
            //{
            //    Console.WriteLine("Count of zero is 0");
            //}
            //else
            //{
            //    Console.Write("count of zero is ");
            //    Console.WriteLine(n - x);
            //}
           
            Console.Write("Count of zeroes is " +
                           countZeroes(arr, n));
            System.Console.WriteLine();

        }

    }
  
}
