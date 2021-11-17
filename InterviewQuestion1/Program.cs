using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 3, 7, 9, 0 };
            int target = 11;
            Console.WriteLine("Question: Given an array of integers, return the indices of the two numbers that add up to a given target.");
            int[] answeer = twoSum(arr, target);
            if ( answeer == null) {
                Console.WriteLine("Sorry return is null, Press any key to terminate.");
                Console.ReadKey();
                return; 
            }
            Array.ForEach(answeer, Console.WriteLine);

            Console.ReadKey();
        }

        // BRUTE FORCE SOLUTION
         static int[] twoSum(int[] arr, int target)
        {
            
            for (int i = 0 ; i < arr.Length; i++)
            { 
                int numToFind = target - arr[i];
                for (int j= i+1 ; j < arr.Length; j++)
                {
                    if (numToFind == arr[j])
                    {
                        return new int[] { i, j};
                    }
                }
            }
            return null;
        }
    }
}
