using System;
using System.Collections.Generic;

namespace liststask3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
    string senttence2;
    List<string> sentences = new List<string>();
    Console.WriteLine("Enter some words, when done entering" +
                        " words, enter 'space' by itself:");
    senttence2 = Console.ReadLine();
    while (senttence2 != "stop")
    {
        sentences.Add(senttence2);
        senttence2 = Console.ReadLine();
    }
    sentences.Reverse();
    foreach(string s in sentences)
        Console.WriteLine(s);
    
            }
        }
    }
}