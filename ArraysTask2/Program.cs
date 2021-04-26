using System;

namespace arraystask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
            int sum = 0;

            foreach(int i in numbers)
            sum += i;
            Console.WriteLine(sum);
        }
    }
}
