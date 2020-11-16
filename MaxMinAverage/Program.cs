using System;

namespace MaxMinAverage
{
     public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
           
            int max = 0;
            int min = 0;
            int sum = 0;
            int[] num = { 10, 20, 30, 40, 50, 60, 70 };
            Numbers MaxMinAverageNumbers = () => { 
                for (int i = 0; i < num.Length; i++)
                {
                    if(num[i] > max)
                    {
                        max = num[i];
                    }

                    if(num[i]<min)
                    {
                       min = num[i];
                    }
                    for (int j = 0; j < num.Length; j++)
                   {
                      sum += num[j];                    
                   }
                   int result = sum / num.Length;
                  Console.WriteLine(result);
                }
               
            };
            MaxMinAverageNumbers();
            Console.Write("Maximum element is : {0}\n", max);
            Console.Write("Minimum element is : {0}\n\n", min);
            
        }
    }
}
