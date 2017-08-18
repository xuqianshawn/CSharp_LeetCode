using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class ChocolateSum
{
    static void Main(string[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
        int numberOfCases = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= numberOfCases; i++)
        {
            int numOfPeople = Int32.Parse(Console.ReadLine());
            int[] numberOfChoco = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine(getNum(numberOfChoco));
        }
    }
    static int getNum(int[] numberOfChoco)
    {
        Array.Sort(numberOfChoco);

        int sum = int.MaxValue;

        for (int b = 0; b < 3; b++)
        {
            int current_sum = 0;
            for (int i = 0; i < numberOfChoco.Length; i++)
            {
                int delta = numberOfChoco[i] - numberOfChoco[0] + b;
                current_sum += (int)delta / 5 + delta % 5 / 2 + delta % 5 % 2 / 1;
            }
            sum = Math.Min(current_sum, sum);
        }

        return sum;
    }
}

