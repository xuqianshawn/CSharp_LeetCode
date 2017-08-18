using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
   static long[,] temp = new long[100,2500]; //number of coins, sum
    static long getWays(long sum, long[] c,int m)
    {
        if (sum ==0)
        {

            return 1;

        }
        else if (sum < 0 || m<=0)
        {
            return 0;
        }
        if (temp[m,sum] != 0)
        {
            return temp[m,sum];
        }
        else
        {
            temp[m,sum]= getWays(sum, c, m - 1) + getWays(sum - c[m - 1], c, m);
        }
        //if (c.Contains(sum))
        //{
        //    return 1;
        //}
        return temp[m,sum];
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int sum = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
      
        long[] c = Array.ConvertAll(c_temp, Int64.Parse);
        // Print the number of ways of making change for 'n' units using coins having the values given by 'c'
        long ways = getWays(sum, c,m);
        Console.WriteLine(ways);
       // Console.ReadLine();
    }
}
