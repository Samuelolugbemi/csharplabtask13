using System;

namespace AverageArray
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            Numbers AverageArrayNumbers = () =>
            {
                int[] num = { 10, 20, 30, 40, 50, 60, 70 };
                int sum = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    sum += num[i];                    
                };
                int result = sum / num.Length;
                Console.WriteLine(result);
            };            
            AverageArrayNumbers();
        }
    }
}
