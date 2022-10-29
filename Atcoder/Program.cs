//// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;



//int a = int.Parse(Console.ReadLine());
//int[, ] work = new int[a,3];
//for(int i =0; i < a-1; i++)
//{
//    int[] inputs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//    work[i, 0] = inputs[0];
//    work[i, 1] = inputs[1];
//    work[i, 2] = inputs[2];
//}
//for (int i = 0; i < a - 1; i++)//行
//{
//    for(int j=1; j<3; j++)//列
//    {
//        if (i==0){
//            int f = Math.Max(work[0,0], work[0,1]);
//            work[i, ] = Math.Max(work[0, 2], f);
//        }
//        work[i,0] = Math.Max(work[i - 1,1], work[i - 1,2]) ;
//        work[i,1] = Math.Max(work[i - 1,0], work[i - 1,2]) ;
//        work[i,2] = Math.Max(work[i - 1,0], work[i - 1,1]);
//    }

//    if (i == a)
//    {
//        int k = Math.Max(work[i, 0], work[i, 1]);
//        Console.WriteLine(Math.Max(work[i, 2], k));
//    }
//}

//int a = int.Parse(Console.ReadLine());
//int[,] dp = new int[a, a];
//dp[0, 0] = 1;

//for (int s = 0; s < a; a++)
//{
//    for (int t = 0; t < a; t++)
//    {
//        if( s -1 >= 0)
//        {
//            dp[s, t] += dp[s-1, t];
//        }
//        if ( t-1 >= 0)
//        {
//            dp[s, t] += dp[s, t - 1];
//        }
//    }
//}
//Console.WriteLine(dp[a-1,a-1]);

//using System;

//int a = int.Parse(Console.ReadLine());
//int[,] inputs = new int[a, a];
//var line = new string[a];
//for (int s = 0; s < a; a++)
//{
//    line[s] = Console.ReadLine();
//    for (int t = 0; t < a; t++)
//    {
//        Console.Write(line[t]);
//        Console.WriteLine(" ");
//    }
//}
//for (int s = 0; s < a; a++)
//{
//    for (int t = 0; t < a; t++)
//    {
//        Console.Write(inputs[s, t]);
//        Console.WriteLine(" ");
//    }
//}

//int n = int.Parse(Console.ReadLine());
//var s = new string[n];
//for (int i = 0; i < n; i++)
//{
//    s[i] = Console.ReadLine();
//}
////for (int i = 0; i < n; i++)
////{
////    for (int j = 0; j < n; j++)
////    {
////        Console.Write(s[i][j]);
////    }
////    Console.WriteLine(" ");
////}

//var a = new int[n, n];
//a[0, 0] = 1;
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        if (j < n - 1 && s[i][j + 1] == '.') a[i, j + 1] += a[i, j];
//        if (i < n - 1 && s[i + 1][j] == '.') a[i + 1, j] += a[i, j];
//    }
//}
//Console.WriteLine(a[n - 1, n - 1]);

//int n = int.Parse(Console.ReadLine());
//int[,] input = new int[n, n];
//for( int s = 0; s < n; s++)
//{
//    int[] a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//    for (int t = 0; t < n; t++)
//    {
//        input[s, t] = a[t];
//    }
//}

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        if(i == 0　& j == 0)
//        {
//            input[i, j] = input[0, 0];
//        }
//        else if (i ==0)
//        {
//            input[ i , j ] += input[i, j -1];
//        }else if (j ==0)
//        {
//            input[ i, j ] += input[i-1, j];
//        }
//        else
//        {
//        input[i, j] += Math.Max(input[i, j - 1], input[i - 1, j]);
//        }    
//    }
//}

//Console.WriteLine(input[n-1, n-1]);

int a = int.Parse(Console.ReadLine());
int[,] graph = new int[a, a];
for(int s = 0; s < a; s++) {
    int[] inputs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    for( int t = 0; t < a; t++)
    {
        graph[s, t] = inputs[t];
    }
}
for( int s = 0; s<a; s++)
{
    for( int t = a-1; t >=0 ; t--)
    {
        if( s==0 & t == a-1)
        {
            graph[s, t] = graph[ 0, a-1];
        }else if( s==0)
        {
            graph[s, t] += graph[s, t + 1];
        }else if( t == a - 1)
        {
            graph[s, t] += graph[s - 1, t];
        }
        else
        {
            graph[s, t] += Math.Min(graph[s, t + 1], graph[s - 1, t]);
        }
    }
}

Console.WriteLine(graph[a-1, 0]);