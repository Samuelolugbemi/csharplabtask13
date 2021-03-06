﻿using System;

namespace Question5
{
    public delegate void Numbers(int[] num);
    class Program
    {
        static void Main(string[] args)
        {
              Numbers squareArray = (num) =>
            {
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = (int)(Math.Pow(num[i], 2));
                }
                foreach (var item in num)
                {
                    Console.Write(item + ",");
                }
            };
            int[] arr= {12,13,2,5,7};
            squareArray(arr);
        }
    }
}
