// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] c = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int output1 = c[0] | c[1];
        int output2 = c[0] & c[1];
        Console.WriteLine(output1);
        Console.WriteLine(output2);

    }
}
