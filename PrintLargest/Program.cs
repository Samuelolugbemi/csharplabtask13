
using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func< int[], int> largestNumber = (num) => { 
                int max = num[0];
                for (int i = 0; i < num.Length; i++)
                {
                    if(num[i] > max)
                    {
                        max = num[i];
                    }
                }
                return max;
            };
            int[] arr = {1, 2, 3, 4, 5, 6};
            Console.WriteLine(largestNumber(arr));
        }
    }
}
