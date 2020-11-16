using System;

namespace PrintOdd
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            Numbers PrintOdd1to255 = () => { 
            for (int i=1; i<=255; i++)
           {
                if (i % 2 == 1)
              {
                 Console.WriteLine(i);
              }
             
           }
           };
           PrintOdd1to255();
        }
    }
}
