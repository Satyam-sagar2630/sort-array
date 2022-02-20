using System;
namespace app
{
    class Program
    {
        static void Main(string[]arg)
        {
            int[] num = { 1, 2, 5, 3, 1, };
            Array.Sort(num);
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}