// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
//using System.Collections.Generic;

//int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int times = int.Parse(Console.ReadLine());
//var results = new List<string>();
//for( int s = 0; s < times; s++)
//{
//    int[] actives = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//    if (actives[0] == 0)//on
//    {
//        input[1] = input[1] | 1 << actives[1];
//    }
//    else if (actives[0] == 1)//off
//    {
//        input[1] = input[1] & ~(1 << actives[1]);
//    }
//    else if (actives[0] == 2)//check
//    {
//        int result = input[1] & 1 << actives[1];
//        if (result == 1)
//        {
//            results.Add("on");
//        }
//        else if (result == 0)
//        {
//            results.Add("off");
//        }
//    }
//}
// foreach( string a in results)
//    {
//        Console.WriteLine(a);
//    }

//int[] actives = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//Console.WriteLine(actives[0] ^ actives[1]);

//int[] actives = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//Console.WriteLine(actives[0] ^ 1<<actives[1]);

//int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int times = int.Parse(Console.ReadLine());
//var results = new List<string>();
//for (int s = 0; s < times; s++)
//{
//    int[] actives = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//    if (actives[0] == 0)//switch
//    {
//        input[1] = input[1] ^ 1 << actives[1];
//    }
//    else if (actives[0] == 1)//check
//    {
//        int result = input[1] & 1 << actives[1];
//        if (result == 1)
//        {
//            results.Add("on");
//        }
//        else if (result == 0)
//        {
//            results.Add("off");
//        }
//    }
//}
//foreach (string a in results)
//{
//    Console.WriteLine(a);
//}

//int times = int.Parse(Console.ReadLine());

//int[] actives = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int result = 0;
//for (int s = 0; s < times; s++)
//{
//    result += 1 << actives[s];
//}
//Console.Write(result);

//int[] actives = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int result = actives[0] & (1 << actives[1]);
//if (result == 0)
//{
//    Console.WriteLine("no");
//}
//else if (result >0)
//{
//    Console.WriteLine("yes");
//}

//int input = int.Parse(Console.ReadLine());
//string str2 = Convert.ToString(input, 2);
//char[] chars = str2.ToCharArray();
//string results ="";
//int count = 0;
//for( int s = 0; s < chars.Length; s++)
//{
//    int result = input & 1 << s;
//    if ( result > 0)
//    {
//        results += s.ToString() + " ";
//        count++;
//    }
//}
//Console.WriteLine(count);
//Console.WriteLine(results.TrimEnd());

int[] actives = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int result = actives[0] & actives[1];
if ( result == 0)
{
    Console.WriteLine("no");
}
else
{
    Console.WriteLine("Yes");
}