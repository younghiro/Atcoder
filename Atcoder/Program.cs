// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

int[] c = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int times = int.Parse(Console.ReadLine());
string[] result = new string[times];
for( int a =0; a < times; a++)
{    int[] b = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    if (b[0] == 0)
    {
        c[1] = c[1] | (1 << b[1]);
    }
    else
    {
        int check = c[1] & (1 << b[1]);
        if (check == 1)
        {
            result[a] = "on";
        }else if(check == 0)
        {
            result[a] = "off";
        }
           
    }
}

foreach ( string a in result)
{
    Console.WriteLine(a);
}