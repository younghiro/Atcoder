//// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;

//int[] inputs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int n = inputs[0];
//int m = inputs[1];
//bool[,] dp = new bool[n, m];
//dp[0, 0] = true; 
////Console.WriteLine(dp[0, 0]);

//int[] a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

//for( int i = 0; i < n-1; i++)
//{
//    for (int t = 0; t < m; t++)
//    {
//        if (!dp[i, t]) continue;
//        dp[i+1, t] = true;
//        if( t + a[i] < m)
//        {
//            dp[i + 1, t + a[i]] = true;
//        }
//    }
//}

//int[] nm = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] w = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int n = nm[0];
//int m = nm[1];

//bool[,] dp = new bool[n+1, m+1];
//dp[0, 0] = true;

//for( int i = 0; i < n; i++)
//{
//    for( int j = 0; j <= m; j++)
//    {
//        if (!dp[i, j]) continue;
//        dp[i + 1, j] = true;
//        if( j + w[i] <= m)
//        {
//            dp[i+1, j+w[i]] = true;
//        }
//    }
//}

////for (int i = 0; i < n; n++)
////{
////    for (int j = 0; j < m; j++)
////    {
////        Console.Write("{0} ",dp[i, j] );
////        Console.WriteLine(" ");
////    }
////}

//if (dp[n, m] == true)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

int[] nm = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] A = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] B = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int n = nm[0];
int m = nm[0];
int[,] dp = new int[n+1,m+1];
for (int o = 0; o < dp.GetLength(0); o++)
{
    for (int p = 0; p < dp.GetLength(1); p++)
    {
        dp[o,p ] = -1;
    }
}
for (int o = 0; o < dp.GetLength(0); o++)
{
    for (int p = 0; p < dp.GetLength(1); p++)
    {
        Console.Write("{0} ", dp[o, p]);
    }
    Console.WriteLine(" ");
}
//dp[0, 0] = 0;
//for ( int i=0; i < n; i++)
//{
//    for(int t = 0; t < m; t++)
//    {
//        if (!dp[i, j])
//        {

//        }
//    }
//}