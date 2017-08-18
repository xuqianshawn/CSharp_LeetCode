using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Symmetric
{
    protected static bool checkBalance(string input)
    {
        int length = input.Length;
        Stack<Char> s = new Stack<char>();
        //for (int i = 0; i < length / 2; i++)
        //{
        //    if (input[i]=='{' && input[length-1-i]!='}')
        //        return false;
        //    if (input[i] == '[' && input[length - 1 - i] != ']')
        //        return false;
        //    if (input[i] == '(' && input[length - 1 - i] != ')')
        //        return false;
        //}
        foreach (Char c in input)
        {
            if (c == '{')
            {
                s.Push('}');
            }
            else if (c == '[')
            {
                s.Push(']');
            }
            else if (c == '(')
            {
                s.Push(')');
            }
            else
            {
                if (s.Count == 0 || c != s.Peek())
                {
                    return false;
                }
                else
                {
                    s.Pop();
                }
            }
        }
        return s.Count==0;
    }
    static void Main(String[] args)
    {
        //    string[] tokens_n = Console.ReadLine().Split(' ');
        //    int n = Convert.ToInt32(tokens_n[0]); //number
        //    int k = Convert.ToInt32(tokens_n[1]);  //rotating point
        //    string[] a_temp = Console.ReadLine().Split(' ');
        //    int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        //    int[] result = new int[n];
        //    int index = k-1;//Array.IndexOf(a, k);
        //    int temp = 0;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        temp = index + i;
        //        if (temp >= n)
        //        {
        //            temp = temp - (n);
        //        }
        //        result[i-1] = a[temp];
        //    }
        //    for (int j = 0; j < n; j++)
        //    {
        //        if(j==n-1)
        //        Console.Write(result[j]);
        //        else
        //        Console.Write(result[j] + " ");
        //    }
        //    Console.ReadLine();


        //int t = Convert.ToInt32(Console.ReadLine());
        //for (int a0 = 0; a0 < t; a0++)
        //{   
        //    string expression = Console.ReadLine();
        //    if (checkBalance(expression))
        //    {
        //        Console.WriteLine("YES");
        //    }
        //    else
        //    {
        //        Console.WriteLine("NO");
        //    }
        //}

        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int counter = 0;
        Dictionary<char, int> Dicstore = new Dictionary<char, int>();
        foreach (char x in a)
        {
            if (Dicstore.ContainsKey(x))
            {
                int valuea = Dicstore[x];
                Dicstore[x]=++valuea;               
            }
            else
                Dicstore.Add(x, 1);
        }
        foreach (char y in b)
        {
            if (Dicstore.ContainsKey(y))
            {
                int valueb = Dicstore[y];
                Dicstore[y] = --valueb;
            }
            else
                Dicstore.Add(y, -1);
        }
        foreach (var pair in Dicstore)
        {
            counter = counter + Math.Abs(pair.Value);
        }
        Console.WriteLine(counter);
      //  Console.ReadLine();
    }
}
