// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;

//int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int times = int.Parse(Console.ReadLine());
//var results = new List<string>();
//for (int s = 0; s < times; s++)
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
//foreach (string a in results)
//{
//    Console.WriteLine(a);
//}

//int[] actives = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//Console.WriteLine(actives[0] ^ actives[1]);

//int[] actives = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//Console.WriteLine(actives[0] ^ 1 << actives[1]);

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
//else if (result > 0)
//{
//    Console.WriteLine("yes");
//}

//int input = int.Parse(Console.ReadLine());
//string str2 = Convert.ToString(input, 2);
//char[] chars = str2.ToCharArray();
//string results = "";
//int count = 0;
//for (int s = 0; s < chars.Length; s++)
//{
//    int result = input & 1 << s;
//    if (result > 0)
//    {
//        results += s.ToString() + " ";
//        count++;
//    }
//}
//Console.WriteLine(count);
//Console.WriteLine(results.TrimEnd());

//int[] actives = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int result = actives[0] & actives[1];
//if ( result == 0)
//{
//    Console.WriteLine("no");
//}
//else
//{
//    Console.WriteLine("Yes");
//}

////ビット演算１章から７章
///

//int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int[] outputs = new int[inputs[0]];
//outputs[0] = inputs[1];
//outputs[1] = inputs[2];

//for (int a = 2; a < inputs[0]; a++)
//{
//    outputs[a] = (outputs[a - 1] + outputs[a - 2]) % 100;
//}
//Console.WriteLine(outputs[inputs[0]-1]);

//int f = int.Parse(Console.ReadLine());
//int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int[] result = new int[f];
//result[0] = inputs[0];
//result[1] = inputs[1];
//for ( int s = 2; s < f; s++)
//{
//    result[s] = Math.Min(result[s - 1] + inputs[s], result[s-2] + inputs[s] * 2);
//}
//Console.WriteLine(result[f - 1]);

//int f = int.Parse(Console.ReadLine());
//int[] result = new int[f+1];
//result[0] = 1;
//result[1] = 1;
//for (int s = 2; s <= f; s++)
//{
//    result[s] = result[s - 2] + result[s - 1];
//}
//Console.WriteLine(result[f]);

//int f = int.Parse(Console.ReadLine());
//int[] result = new int[f+1];

//result[1] = 1;
//result[2] = 2;
//result[3] = 4;
//for (int s = 4; s <= f; s++)
//{
//    result[s] = result[s - 3] +  result[s - 2] + result[s - 1];
//}
//Console.WriteLine(result[f]);

//正解
//result[0] = 1;
//for (int s = 1; s <= f; s++)
//{

//        result[s] += result[s - 1];

//    if (1 < s)
//    {
//        result[s] += result[s - 2];
//    }
//    if (2 < s)
//    {
//        result[s] += result[s - 3];
//    }
//}
//Console.WriteLine(result[f]);

//int[] inputs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int n = inputs[0];
//int m = inputs[1];
//int[] titles = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] results = new int[n + 1];
//results[0] = 1;
//for ( int a = 1; a < n; a++)
//{
//    for(int b = 1; b <= m; b++)
//    {
//        if (a - b >= 0)
//        {
//            results[a] = Math.Min(results[a], results[a - b]+ titles[a] * j);
//        }
//    }
//}
//Console.WriteLine(results[n+1]);

//int[] nm = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] inputs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[,] array = new int[nm[0], nm[1]];
////Console.WriteLine(array[0, 0]);
//for( int s =0; s<nm[1]; s++)
//{
//    for(int t = 0; t < nm[0]+1; t++)
//    {
//        if (inputs[s] * t <= nm[0])
//        {
//            array[s, inputs[t] * t] = inputs[t] * t;
//        }
//        if (s > 0 & array[s - 1, inputs[t] * t] + inputs[s] * t <= nm[0])
//        {
//            array[s, array[s - 1, inputs[t] * t] + inputs[s] * t] = inputs[t] * t + inputs[s] * t;
//        } ;
//    }
//}

//for (int s = 0; s < nm[1]; s++)
//{
//    if(array[s, nm[0]] == nm[0])
//    {
//        Console.WriteLine("Yes");

//    }
//    else
//    {
//        Console.WriteLine("No");
//    }
//}

////int times = int.Parse(Console.ReadLine());
//int a = int.Parse(Console.ReadLine());
//int[] inputs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

//int[,] array = new int[a, a];
//for( int s=0; s < a; s++)
//{
//    array[0, s] = inputs[s];
//}

////for (int s = 0; s < a; s++)
////{
////    for(int t = 0; t < a; t++)
////    {
////        Console.Write(array[s, t]+" ");
////    }
////    Console.WriteLine(" ");
////}

//for (int s = 1; s < a; s++)
//{
//    for (int t = 0; t < a; t++)
//    {
//        int one = 0;
//        one += array[s - 1, t];
//        if (t - 1 >= 0)
//        {
//        one += array[s - 1, t-1];
//        }
//        if(t+1<= a - 1)
//        {
//        one += array[s - 1, t+1];
//        }
//        array[s, t] = one%100;
//    }
//}
//Console.WriteLine(array[a-1, a-1]);

int a = int.Parse(Console.ReadLine());
int[, ] work = new int[a,3];
for(int i =0; i < a-1; i++)
{
    int[] inputs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    work[i, 0] = inputs[0];
    work[i, 1] = inputs[1];
    work[i, 2] = inputs[2];
}
for (int i = 0; i < a - 1; i++)//行
{
    for(int j=1; j<3; j++)//列
    {
        if (i==0){
            int f = Math.Max(work[0,0], work[0,1]);
            work[i, j] = Math.Max(work[0, 2], f);
        }
        work[i,0] = Math.Max(work[i - 1,1], work[i - 1,2]) ;
        work[i,1] = Math.Max(work[i - 1,0], work[i - 1,2]) ;
        work[i,2] = Math.Max(work[i - 1,0], work[i - 1,1]);
    }

    if (i == a)
    {
        int k = Math.Max(work[i, 0], work[i, 1]);
        Console.WriteLine(Math.Max(work[i, 2], k));
    }
}

