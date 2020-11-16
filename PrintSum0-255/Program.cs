using System;

namespace Question2
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            Numbers printSum0to255 = () => { 
             int sum = 0;
             for(int i = 0; i <= 255; i++)
               {
                  Console.Write($"{i} :  {sum += i}");
                  
                }
            };
            printSum0to255();
        }
    }
}

 
 