using System;

namespace Maxi_min
{
    class Program2
    {
        static void Main(string[] args)
        {
            int[] array ={10, 5, 20, 30, 60, 1};
            int max,min;
            max = array[0];
            min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                 if(array[i]>max)
                {
                    max=array[i];
                }
                 if(array[i]<min)
                {
                     min = array[i];
                }
            }                  
                    Console.WriteLine("Max value is:"+max);
                    Console.WriteLine("Min value is:"+min);
        }
    }
}
