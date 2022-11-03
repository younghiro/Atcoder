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

//int[] nm = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] A = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] B = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int n = nm[0];
//int m = nm[0];
//int[,] dp = new int[n+1,m+1];
//for (int o = 0; o < dp.GetLength(0); o++)
//{
//    for (int p = 0; p < dp.GetLength(1); p++)
//    {
//        dp[o,p ] = -1;
//    }
//}
//for (int o = 0; o < dp.GetLength(0); o++)
//{
//    for (int p = 0; p < dp.GetLength(1); p++)
//    {
//        Console.Write("{0} ", dp[o, p]);
//    }
//    Console.WriteLine(" ");
//}
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

//int[] NM = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] A = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] B = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

//int N = NM[0];
//int M = NM[1];
//int[,] dp = new int[N, M];

//for( int s = 0; s<N; s++)
//{
//    for (int t = 0; t < N; t++) {
//        dp[s, t] = -1;
//    }
//}

int[] NA= Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int N = NA[0];
int A = NA[1];
int[] P = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] Q = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] R = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[,] dp = new int[N, 3];
dp[0, 0] = P[0];
dp[0, 1] = Q[0];
dp[0, 2] = R[0];

for( int x = 0; x < N; x++)
{
    dp[x, 0] = P[x];
    dp[x, 1] = Q[x];
    dp[x, 2] = R[x];
}

for ( int s = 1; s < N; s++)
{
    for( int t = 0; t < 3; t++)
    {
        int compare = 0;
        if (t == 0)
        {
            compare = Math.Min(dp[s - 1,1] + Q[s], dp[s - 1, 2] + R[s]);
            dp[s, t] = Math.Min(dp[s - 1, 0] + P[s] - A, compare);
        }
        if (t == 1)
        {
            compare = Math.Min(dp[s - 1, 0] + Q[s], dp[s - 1, 2] + R[s]);
            dp[s, t] = Math.Min(dp[s - 1, 1] +Q[s] - A, compare);
        }
        if (t == 2)
        {
            compare = Math.Min(dp[s - 1, 0] + Q[s], dp[s - 1, 1] + R[s]);
            dp[s, t] = Math.Min(dp[s - 1, 2] +R[s] - A, compare);
        }
    }
}

for( int j = 0; j < N; j++)
{
    for( int k = 0; k < 3; k++)
    {
        Console.Write(dp[j, k]);
    }
    Console.WriteLine(" ");
}

int resultCompare = Math.Min(dp[N - 1, 0], dp[N - 1, 1]);
Console.WriteLine(Math.Min(resultCompare, dp[N - 1, 2]));