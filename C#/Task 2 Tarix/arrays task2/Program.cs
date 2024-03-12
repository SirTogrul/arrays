using System;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace arrays_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            string[] words = { "mahsun", "efqan", "rehim" };
            int i = Convert.ToInt32(Console.ReadLine());
             if(i>=0&&i<words.Length)
            {
                Console.WriteLine(words[i]);
             
            }  string word = words[i];
            for(int j= word.Length-1; j >= 0; j--)
            {
                Console.Write(word[j]);
            }
        }
    }
}