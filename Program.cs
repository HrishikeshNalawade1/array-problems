using System;

namespace array_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int temp;
            Console.WriteLine("Enter size of array");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements",s);
            for (int i = 0; i < s; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < s; i++)
            {
                for (int j = i+1; j < s; j++)
                {
                      if(arr[i]>arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("ascending order");
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
