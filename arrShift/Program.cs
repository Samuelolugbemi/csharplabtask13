
using System;

namespace arrShift
{

     public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            Numbers arrShiftValues = () => {
            int[] num = { 1, 2, 3, 4, 5 };
                for (int i = 0; i < num.Length; i++) {
                  num[ num.Length - 1] = 0;
                 Console.WriteLine(num);
                }
                 
               };
               arrShiftValues();
               
           
        }

     
    }
}
