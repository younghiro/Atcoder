//// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

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

//int[] NX = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] A = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int N = NX[0];
//int X = NX[1];
//int[] boxes = new int[N + 1];
//boxes[0] = 0;
//for( int s = 1; s < N; s++)
//{
//    boxes[s] = A[s-1];
//}
//int count = 0;
//while( X!=0)
//{
//    count++;
//    X = boxes[X];
//}

//Console.Write(count);

//int[] NX= Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int[] A = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

//int N = NX[0];
//int X = NX[1];

//var List = new List<List<int>>();
//for ( int a = 0; a < N+1; a++)
//{
//    List.Add(new List<int>());
//}

//List[0].Add(0);

//for( int s = 1; s < N; s++)
//{
//    List[A[s]].Add(s);
//}
//int count = 0;

//recallfunction( 0
//void recallfunction( List<int> x , int y){
//    count++;
//    if (List[y].Count == 0)
//    {
//        return ;
//    }
//    foreach (int t in List[x])
//    recallfunction( );
//}

//int[] NMX = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int N = NMX[0];
//int M = NMX[1];
//int X = NMX[2];
//var List= new List<List<int>>();

//for (int s = 0; s < N; s++){
//    List.Add(new List<int>());
//}

//for (int t = 0; t < M; t++)
//{
//    int[] AB = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//    List[AB[0]].Add(AB[1]);
//}

//I can be placed before V (5) and X (10) to make 4 and 9. 
//X can be placed before L (50) and C(100) to make 40 and 90. 
//C can be placed before D (500) and M(1000) to make 400 and 900.

//Symbol Value
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000

//Solution solution = new Solution();

//int output = solution.RomanToInt(Console.ReadLine());
//Console.WriteLine(output.ToString());

//public class Solution
//{
//    public int RomanToInt(string s)
//    {
//        int answer = 0;
//        int length = s.Length +1;
//        //データ型[] 配列名 = new データ型[要素数];
//        string[] numbers = new string[15];
//        //Console.WriteLine(numbers.Length);

//        numbers = s.Select(x => x.ToString()).ToArray();
//        //Console.WriteLine(numbers.Length);
//        Array.Resize(ref numbers, length);
//        //Console.WriteLine(numbers.Length);
//        //foreach (string i in numbers)
//        //{
//        //    Console.WriteLine(i);
//        //}
//        //Console.WriteLine(length);
//        //Console.ReadLine();

//        for (int q = 0; q < length; q++)
//        {
//            if (numbers[q] == "I")
//            {
//                if (numbers[q + 1] == "V")
//                {
//                    answer += 4;
//                    q++;
//                    continue;
//                }
//                else if (numbers[q + 1] == "X")
//                {
//                    answer += 9;
//                    q++;
//                    continue;
//                }
//                else
//                {
//                    answer += 1;
//                }

//            }
//            if (numbers[q] == "X")
//            {
//                if (numbers[q + 1] == "L")
//                {
//                    answer += 40;
//                    q++;
//                    continue;
//                }
//                else if (numbers[q + 1] == "C")
//                {
//                    answer += 90;
//                    q++;
//                    continue;
//                }
//                else
//                {
//                    answer += 10;
//                }
//            }

//            if (numbers[q] == "C")
//            {
//                if (numbers[q + 1] == "D")
//                {
//                    answer += 400;
//                    q++;
//                    continue;
//                }
//                else if (numbers[q + 1] == "M")
//                {
//                    answer += 900;
//                    q++;
//                    continue;
//                }
//                else
//                {
//                    answer += 100;
//                }
//            }

//            if (numbers[q] == "V") { answer += 5; }
//            if (numbers[q] == "L") { answer += 50; }
//            if (numbers[q] == "D") { answer += 500; }
//            if (numbers[q] == "M") { answer += 1000; }
//        }
//        return answer;
//    }
//}

//Solution solution = new Solution();
//int[] nums = new int[3];
//nums[0] = 3;
//nums[0] = 2;
//nums[0] = 4;

//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        //データ型[] 配列名 = new データ型[要素数];
//        int[] answer = new int[2];
//        for( int s = 0; s < nums.Length; s++) {
//            for(int t = 1; t < nums.Length -1; t++)
//            {
//                if (nums[s] + nums[t] == target)
//                {
//                    answer[0] = s;
//                    answer[1] = t;
//                }
//            }
//        }
//        return answer;
//    }
//}

//var List= new List<List<int>>();

////var List= new List<List<int>>();

//for (int s = 0; s < N; s++){
//    List.Add(new List<int>());
//}

//for (int t = 0; t < M; t++)
//{
//    int[] AB = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//    List[AB[0]].Add(AB[1]);
//}


//for (int t = 0; t < M; t++)
//{
//    int[] AB = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//    List[AB[0]].Add(AB[1]);
//}
//''flower, "flow", "flight"


//string[] strs = new string[3] { "flower", "flow", "flight" };
////Solution s = new Solution();

//string prefix = strs[0];
//for (int s = 1; s < strs.Length; s++)
//{
//    while (strs[s].IndexOf(prefix) != 0)
//    {
//        prefix = prefix.Substring(0, prefix.Length-1);
//    }
//}

//Console.Write(prefix);

//Dictionary<int, int> hashtable = new Dictionary<int, int>();
//int target;
//for( int s = 0; s < nums.Lenght; s++)
//{
//    int compliment = target - nums[s];

//    if (hashtable.ContainsKey(compliment))
//    {
//        new int(hashtable[compliment], i);// return index
//    }
//    else
//    {
//        hashtable[nums[s]] = i;
//    }
//}
//string input = " ";
//input = Console.ReadLine();

//int b = input.Length;
//int c = b - 1;
////var array = new char[b];

////List<int> i = new List<int>();

////foreach( char a in input) {

////}
//bool check = false;
//string[] splitArray = input.Select(x => x.ToString()).ToArray();

//if(splitArray[0] == "-") {
//    check = false;
//}
//Console.WriteLine(b.ToString());
//for( int s = 0; s< b; s++)
//{
//    if (splitArray[s] == splitArray[c-s])
//    {
//        check = true;
//    }
//    else { check = false; }
//}

//Console.WriteLine( check);

//while (check)
//{
//    check = true;
//}

//////////////////////////////
///アルゴ式
/////////////////////////////

//var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();

////int[] A = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

////var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
///

//var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
//Console.WriteLine(nm[0] >> nm[1]);

//using System;
//using System.Linq;
//using System.Collections.Generic;

//using System;
//using System.Net.NetworkInformation;

//2using Linq;
//3using Collections.Generic;
//4
//5class Program
//{
//6  static void Main(string[] args)
//    {
//        7    int input[] = Console.ReadLine().Split().Select(int.Parse).ToArray;
//        8    Console.WriteLine(input[0] << input[1]);
//        9  }
//10}

//using System;
//using Linq;
//using Collections.Generic;

//int input = int.Parse(Console.ReadLine());
//Console.WriteLine(input << 1);

//int a = int.Parse(Console.ReadLine());

//Console.WriteLine( 1<< a);

//2 つの整数 A, i が与えられます。
//A と 2 
//i
//  の論理積 (AND) を求めるプログラムを作成してください。

//int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

//Console.WriteLine(input[0] & 1 << input[1]);


//最初、N 個のスイッチは整数値 S で表される状態となっています。
// この状態に対して、Q 回のクエリが与えられます。
// それぞれのクエリに答えてください。

//int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int input = int.Parse(Console.ReadLine());

//for( int s = 0; s < input; s++)
//{
//    int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    if (query[0] == 0)
//    {

//    }
//    else
//    {

//    }
//}

//Console.WriteLine(13 & 1 << 1);

//string input = Console.ReadLine();
//int comparative = int.Parse(input);
//int n = int.Parse(input);
//int r = 0;
//int rev = 0; //revは指定された整数の逆を格納

//while (n > 0)
//{
//    r = n % 10; //inputの最後の桁をrに格納      
//    rev = rev * 10 + r;　//rev=65, r=4の時、654

//    n = n / 10; //nから最後の一桁を削除
//}

//if (comparative == rev)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}
//Solution solution = new Solution();
//Console.WriteLine(solution.IsPalindrome(121));

//public class Solution
//{
//    public bool IsPalindrome(int x)
//    {
//        int n = x;
//        int rev = 0;
//        while (n > 0)
//        {
//            int r = n % 10;
//            rev = rev * 10 + r;
//            n = n / 10;
//        }

//        if (x == rev)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}

//'(', ')', '{', '}', '[' and ']'

//文字列を一文字ずつに分け配列に入れる
//string[] splitArray = text.Select(x => x.ToString()).ToArray();

//Solution solution = new Solution();
//Console.WriteLine(solution.IsValid("{[]}"));

//public class Solution
//{
//    public bool IsValid(string s)
//    {
//        bool result = true;
//        string[] inputs = s.Select(x => x.ToString()).ToArray();
//        for( int t = 0; t < s.Length; t = t+2)
//        {
//            if (inputs[t] == "(" & inputs[t + 1] == ")"){
//                continue;
//            }else if(inputs[t] == "[" & inputs[t + 1] == "]")
//            {
//                continue;
//            }
//            else if (inputs[t] == "{" & inputs[t + 1] == "}")
//            {
//                continue;
//            }
//            else  { result = false; }
//        }

//        for (int p = 0; p < s.Length; p ++)
//        {
//            Console.WriteLine(p);
//            Console.WriteLine(s.Length - p - 1);
//            if (inputs[p] == inputs[s.Length - p - 1])
//            {
//                result = true;
//            }
//        }
//            return result;
//    }
//}

//Solution solution = new Solution();
//Console.WriteLine(solution.IsValid("(("));

//public class Solution
//{
//    public bool IsValid(string s)
//    {
//        Stack<char> stack = new Stack<char>();
//        List<char> opnings = new List<char>
//        {
//            '(','{','['
//        };

//        //'(', ')', '{', '}', '[' and ']',

//        var map = new Dictionary<char, char>
//        {
//            {'(',')'},
//            {'{', '}'},
//            {'[', ']'}
//        };

//        foreach(char t in s)
//        {
//            if (opnings.Contains(t))
//            {
//                stack.Push(t);
//            }
//            else
//            {
//                if (stack.Count == 0) return false;
//                char judge = stack.Pop();
//                if( t != map[judge])
//                {
//                    return false;
//                }
//            }
//        }

//        if (stack.Count > 0) { return false; }else {
//            return true;
//            }
//                }
//}

//Solution solution = new Solution();
//Console.WriteLine(solution.ClimbStairs(4));

//public class Solution
//{
//    public int ClimbStairs(int n)
//    {
//        int[] dp = new int[n + 1];
//        dp[0] = 1;
//        dp[1] = 1;

//        if (n == 1) return 1;
//        for( int s = 2; s <= n; s++)
//        {
//            dp[s] = dp[s - 1] + dp[s - 2];
//            Console.WriteLine(dp[s]);
//        }
//        return dp[n];
//    }
//}


//'(', ')', '{', '}', '[' and ']'

//Solution solution = new Solution();
//Console.WriteLine(solution.IsValid("()"));

//public class Solution
//{
//    public bool IsValid(string s)
//    {
//        Stack<char> input = new Stack<char>();
//        List<char> openings = new List<char>
//        {
//            '(','{','['
//        };

//        Dictionary<char, char> map = new Dictionary<char, char>
//        {
//            {'(', ')'},
//            {'{', '}'},
//            {'[', ']'}
//        };

//        foreach( char a in s)
//        {
//            if( openings.Contains(a) )
//            {
//                input.Push(a);
//            }else 
//            {
//                if (input.Count == 0) return false;
//                char judge = input.Pop();
//                if( a != map[judge])  return false;


//            }
//        }
//            //foreach (char t in s)
//            //        {
//            //            if (opnings.Contains(t))
//            //            {
//            //                stack.Push(t);
//            //            }
//            //            else
//            //            {
//            //                if (stack.Count == 0) return false;
//            //                char judge = stack.Pop();
//            //                if( t != map[judge])
//            //                {
//            //                    return false;
//            //                }
//            //            }
//            //        }

//            //        if (stack.Count > 0) { return false; }else {
//            //            return true;
//            return true;
//    }
//}

//var List = new List<List<int>>();
//List.Add(new List<int>());
//int N = int.Parse(Console.ReadLine());
//for (int s = 0; s < N; s++)
//{
//    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//    if (input[0] == 1)
//    {
//        List[s][0] = input[1];
//        List[s][1] = input[2];

//        for (int q = 0; q < List.Count; q++)
//        {
//            for (int p = 0; p < List.Count; p++)
//            {
//                if (List[q][0] < List[p][0] && List[q][1] < List[p][1])
//                {
//                    List[q][0] = 0;
//                }
//            }
//        }
//    }

//    if (input[0] == 2)
//    {
//        int answer = 0;
//        List[s].Add(0);
//        List[s].Add(0);
//        foreach (var a in List)
//        {
//            if (a[0] != 0)
//            {
//                answer++;
//            }
//        }

//        Console.WriteLine(answer);
//    }
//}