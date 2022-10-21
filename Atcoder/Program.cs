// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        //A と 2 iの論理積(AND) を求めるプログラムを作成してください。

        int[] c = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        int output = c[0] & 1 << c[1];

        Console.WriteLine(output);
    }
}
