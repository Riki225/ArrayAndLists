using System;

namespace arraystask1
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] names = new string[5];

        names[0] = "John Doe";
        names[1] = "Jane Doe";
        names[2] = "Gabriel Doe";
        names[3] = "Jonathan Doe";
        names[4] = "Nathan Doe";

        foreach(string n in names)
        Console.WriteLine(n);
    }
    }
}