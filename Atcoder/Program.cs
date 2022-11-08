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

//int[] NA = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int N = NA[0];
//int A = NA[1];
//int[] P = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] Q = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] R = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

//int[,] dp = new int[N, 3];
//dp[0, 0] = P[0];
//dp[0, 1] = Q[0];
//dp[0, 2] = R[0];

//for (int x = 0; x < N; x++)
//{
//    dp[x, 0] = P[x];
//    dp[x, 1] = Q[x];
//    dp[x, 2] = R[x];
//}

//for (int s = 1; s < N; s++)
//{
//    for (int t = 0; t < 3; t++)
//    {
//        int compare = 0;
//        if (t == 0)
//        {
//            compare = Math.Min(dp[s - 1, 1] + Q[s], dp[s - 1, 2] + R[s]);
//            dp[s, t] = Math.Min(dp[s - 1, 0] + P[s] - A, compare);
//        }
//        if (t == 1)
//        {
//            compare = Math.Min(dp[s - 1, 0] + Q[s], dp[s - 1, 2] + R[s]);
//            dp[s, t] = Math.Min(dp[s - 1, 1] + Q[s] - A, compare);
//        }
//        if (t == 2)
//        {
//            compare = Math.Min(dp[s - 1, 0] + Q[s], dp[s - 1, 1] + R[s]);
//            dp[s, t] = Math.Min(dp[s - 1, 2] + R[s] - A, compare);
//        }
//    }
//}

//for (int j = 0; j < N; j++)
//{
//    for (int k = 0; k < 3; k++)
//    {
//        Console.Write(dp[j, k]);
//    }
//    Console.WriteLine(" ");
//}

//int resultCompare = Math.Min(dp[N - 1, 0], dp[N - 1, 1]);
//Console.WriteLine(Math.Min(resultCompare, dp[N - 1, 2]));
//int[] NA = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int N = NA[0];
//int A = NA[1];
//int[] P = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] Q = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] R = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

//int[,] dp = new int[N, 3];
//dp[0, 0] = P[0];
//dp[0, 1] = Q[0];
//dp[0, 2] = R[0];

//for( int x = 0; x < N; x++)
//{
//    dp[x, 0] = P[x];
//    dp[x, 1] = Q[x];
//    dp[x, 2] = R[x];
//}

//for ( int s = 1; s < N; s++)
//{
//    for( int t = 0; t < 3; t++)
//    {
//        int compare = 0;
//        if (t == 0)
//        {
//            compare = Math.Min(dp[s - 1,1] + Q[s], dp[s - 1, 2] + R[s]);
//            dp[s, t] = Math.Min(dp[s - 1, 0] + P[s] - A, compare);
//        }
//        if (t == 1)
//        {
//            compare = Math.Min(dp[s - 1, 0] + Q[s], dp[s - 1, 2] + R[s]);
//            dp[s, t] = Math.Min(dp[s - 1, 1] +Q[s] - A, compare);
//        }
//        if (t == 2)
//        {
//            compare = Math.Min(dp[s - 1, 0] + Q[s], dp[s - 1, 1] + R[s]);
//            dp[s, t] = Math.Min(dp[s - 1, 2] +R[s] - A, compare);
//        }
//    }
//}

//for( int j = 0; j < N; j++)
//{
//    for( int k = 0; k < 3; k++)
//    {
//        Console.Write(dp[j, k]);
//    }
//    Console.WriteLine(" ");
//}

//int resultCompare = Math.Min(dp[N - 1, 0], dp[N - 1, 1]);
//Console.WriteLine(Math.Min(resultCompare, dp[N - 1, 2]));

//int[] NM = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int N = NM[0];
//int M = NM[1];
////////
////Listの中にListの配列
//var List = new List<List<int>>();

//for( int t = 0; t <M; t++)
//{
//    List.Add(new List<int>());
//}
////////
//for ( int s = 0; s<M; s++)
//{
//    int[] AB = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//    int A = AB[0];
//    int B = AB[1];
//    List[A].Add(B);
//}

//foreach( List<int> a in List)
//{
//    var outputs = a.OrderBy(x=>x);
//    foreach( var b in outputs)
//    {
//        Console.Write(b);
//        Console.Write(" ");
//    }
//    Console.WriteLine();
//}

//int[] NM = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int N = NM[0];
//int M = NM[1];

//var inputs = new List<List<int>>();
//for (int a = 0; a < N; a++)
//{
//        inputs.Add(new List<int>());
//}

//for (int b = 0; b < M; b++)
//{
//    int[] AB = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//    inputs[AB[0]].Add(AB[1]);
//    inputs[AB[1]].Add(AB[0]);
//}

//var count = new List<int>();
//var order = 0;
//for (int d = 0; d < N; d++)
//{
//    count.Add(inputs[d].Count);
//}
//var order2 = count.OrderByDescending(x => x);
//var List = new List<int>();
//foreach( int f in order2)
//{
//    List.Add(f);
//}
//var ans = new List<int>();
//for (int e = 0; e < N; e++)
//{
//    if (inputs[e].Count == List[0])
//    {
//        ans.Add(e);
//    }
//}

//foreach (int a in inputs[ans[0]])
//{
//    Console.Write(a);
//    Console.Write("　");
//}

//int[] NMX = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int N = NMX[0];
//int M = NMX[1];
//int X = NMX[2];
//var inputs = new List<List<int>>();
//for( int a = 0; a < M; a++)
//{
//    inputs.Add(new List<int>());
//}
//for (int a = 0; a < M; a++)
//{
//    int[] AB = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//    inputs[AB[0]].Add(AB[1]);
//    inputs[AB[1]].Add(AB[0]);
//}
/////////////////////////
//////////間違い
////////////////////////
//int i = -1;
//if (inputs[X].Count <= 1 || inputs[X].Count == N - 1)
//{
//    Console.WriteLine(0);
//}
//else
//{
//    for (int b = 1; b < inputs[X].Count; b++)
//    {
//        for (int d = 0; d < inputs[b - 1].Count; d++)
//        {
//            for (int e = 0; e < inputs[b].Count; e++)
//                if (inputs[b - 1][d] == inputs[b][e])
//                {
//                    i++;
//                }
//        }
//    }
//    int all = 0;
//    foreach (int f in inputs[X])
//    {
//        all = all + inputs[f].Count;
//    }

//    Console.WriteLine(all - i);
//}

//var ansContent = new List<int>();
//int ans = 0;
//if (inputs[X] != null){
//    foreach( var f in inputs[X])
//    {
//        foreach( var ff in inputs[f])
//        {
//            if(!inputs[X].Contains(ff) && ff != X)
//            {
//                ansContent.Add(ff);
//            }
//        }
//    }
//    ans = ansContent.Count;
//}

//Console.Write(ans);

//int[] NX = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] A = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int N = NX[0];
//int X = NX[1];//int[] NX = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] A = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int N = NX[0];
//int X = NX[1];
//var list = new List<int>();
//list.Add(A[0]);
//for( int s = 1; s < N; s++)
//{
//    if (A[s-1] > A[s])
//    {
//        list.Add(s);
//    }
//}
//for (int i = 1; i < N; i++)
//{
//    A[i] = int.Parse(input[i - 1]);
//}

//int cnt = 0;
//while (X != 0)
//{
//    cnt++;
//    X = A[X];
//}

//Console.WriteLine(cnt);


//string[] NX = Console.ReadLine().Split(' ');
//int N = int.Parse(NX[0]);
//int X = int.Parse(NX[1]);
//int[] A = new int[N + 1];
//A[0] = 0;
//string[] input = Console.ReadLine().Split(' ');
//for (int i = 1; i < N; i++)
//{
//    A[i] = int.Parse(input[i - 1]);
//}

//int cnt = 0;
//while (X != 0)
//{
//    cnt++;
//    Console.Write(X);
//    X = A[X];
//    //Console.WriteLine(A[X]);
//}

//Console.WriteLine(cnt);

int[] NX = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] A = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int N = NX[0];
int X = NX[1];
int[] boxes = new int[N + 1];
boxes[0] = 0;
for( int s = 1; s < N; s++)
{
    boxes[s] = A[s-1];
}
int count = 0;
while( X!=0)
{
    count++;
    X = boxes[X];
}

Console.Write(count);