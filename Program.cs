using System;
using System.Collections.Generic;

namespace Generic1
{
    class example
    {
        public static void details<t>(t[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr ={11,2,3,55,66};
            string[] name = {"hrishi","rahit","rehan" };
            char[] code = { 'A', 'b', 'C' };
            example.details(name);
            example.details(arr);
            example.details(code);
        }
    }
}
