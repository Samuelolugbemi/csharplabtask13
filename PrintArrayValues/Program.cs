using System;

namespace PrintArrayValues
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            Numbers PrintArrayValueNumbers = () =>
            {
                int[] num = { 10, 20, 30, 40 };
                for (int i = 0; i < num.Length; i++)
                {
                    Console.WriteLine(num[i]);
                }
            };
            PrintArrayValueNumbers();
        }
    }
}
