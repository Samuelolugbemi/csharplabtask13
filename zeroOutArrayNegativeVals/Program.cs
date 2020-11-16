using System;

namespace zeroOutArrayNegativeVals
{
     public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            Numbers zeroOutArrayNegativeVals = () => {
                int[] num = { -3, -2, -2, 0, 1, 2, 3 };
                int sum = 0;
                for (int i = 0; i < num.Length; i++) {
                    sum += num[i];
                    Console.WriteLine(num[i]);

                }

            };
            
            zeroOutArrayNegativeVals();
        }
    }
}
