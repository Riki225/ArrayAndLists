using System;
using System.Collections.Generic;

namespace liststask1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> NumList = new List<int>();
            
            NumList.Add(3);
            NumList.Add(2);
            NumList.Add(4);
            NumList.Add(7);
            NumList.Add(5);
            foreach(int num in NumList)
            Console.WriteLine(num);
            
            Console.WriteLine("Enter a Number:");
            int getNum = int.Parse(Console.ReadLine());

            if (NumList.Contains(getNum)) {
                Console.WriteLine(getNum + "  exists in the list");
                Console.WriteLine("2 instances of the item has been entered");
            }
            else{
                Console.WriteLine("Done!"); 
            }
               
        }

    }

}
