using System;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace arrays_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, 3, -5, -7 };
            int[] nums2=new int[nums.Length];
        for(int i=0;i<nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                  nums2[nums.Length - 1 - i] = Math.Abs(nums[i]);
                }
                
                else
                {
                    nums2[i] = nums[i];
                }
            }for (int i = 0; i < nums2.Length; i++)
            {
                Console.WriteLine(nums2[i]);
            }
            
        }
        
        
    }
}