using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatedArray
{
    /***Given a sorted array of n integers that has been rotated an unknown number of times, 
    write code to find an element in the array.
    You may assume that the array was originally sorted in increasing order.***/

    class Program
    {
        public static int RotatedArray(int[] arr,int x)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                //checking if middle element is equal to the element x
                if (arr[mid] == x)
                    return mid;
                //checking the left half if they are sorted
                if (arr[start] < arr[mid])
                {
                    if (arr[start] <= x && x < arr[mid])
                    {
                        end = mid - 1;
                    }
                    else start = mid + 1;
                }
                else if (arr[start] > arr[mid])
                {
                    if (arr[mid] < x && x <= arr[end])
                    {
                        start = mid + 1;
                    }
                    else end = mid - 1;
                }
                else start++;

            }

            return -1;
            
        }
        
        static void Main(string[] args)
        {
            //int[] arr = {5,4,3,2,1};
            //int[] arr = { 4, 5, 6, 1, 2, 3 };
            int[] arr = { 14, 15, 16, 21, 5, 6,7,8};
            //int key = 5;
            int x = 8;
            //int key = 0;
            
            int count = RotatedArray(arr,x);
            if (count == -1)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element {0} found at index {1}", x, count);

           }
    }
}



// while(start <= end)
//            {
//                if (arr[start] <= arr[end])
//                {
//                    //Console.WriteLine(start);
//                    return start;
//                }

//                int mid = (start + end) / 2;
//int next = mid + 1;

//int prev = mid-1;
//                if (arr[mid] <= arr[next] && arr[mid] <= arr[prev])
//                {
//                    return mid;
//                }
//                else if (arr[mid] <= arr[end])
//                    end = mid - 1;
//                else if (arr[mid] >= arr[start])
//                    start = mid + 1;

//            }