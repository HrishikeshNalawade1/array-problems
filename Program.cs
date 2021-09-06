using System;

namespace Delete_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Console.WriteLine("Enter size of element");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Print elemnts");
            for (int i = 0; i < s; i++)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine("enter element you want to delete");
            int del = Convert.ToInt32(Console.ReadLine());
            for (int i = del-1; i <s; i++)
            {
                array[i] = array[i + 1];
            }
            s--;
            Console.WriteLine("After deletion");
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
