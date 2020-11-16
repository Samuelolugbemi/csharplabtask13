using System;
using System.Collections.Generic;

namespace Question4
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            
            Numbers returnOddArray1to255 = () => { 
               
            List<int> oddArray = new List<int>();
           for (int i = 1; i <= 255; i++) 
           {
              if (i % 2 == 1)
              {
                oddArray.Add(i);
              }
            }
             foreach (var item in oddArray)
            {
                 Console.WriteLine(item);
            }

         };
         returnOddArray1to255();   
           
        }
    }
}
