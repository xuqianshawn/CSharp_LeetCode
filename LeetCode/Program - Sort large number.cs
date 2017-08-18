using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    //static public long Partition(Double[] numbers, long left, long right)
    //{
    //    Double pivot = numbers[left];
    //    while (true)
    //    {
    //        while (numbers[left] < pivot)
    //            left++;

    //        while (numbers[right] > pivot)
    //            right--;

    //        if (left < right)
    //        {
    //            Double temp = numbers[right];
    //            numbers[right] = numbers[left];
    //            numbers[left] = temp;
    //        }
    //        else
    //        {
    //            return right;
    //        }
    //    }
    //}

    //static public void SortQuick(Double[] arr, long left, long right)
    //{
    //    // For Recusrion  
    //    if (left < right)
    //    {
    //        long pivot = Partition(arr, left, right);

    //        if (pivot > 1)
    //            SortQuick(arr, left, pivot - 1);

    //        if (pivot + 1 < right)
    //            SortQuick(arr, pivot + 1, right);
    //    }
    //}

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<String> listInput = new List<string>();
        for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
        {
            listInput.Add(((Console.ReadLine())));
        }
        // your code goes here
       
        listInput= listInput.OrderBy(x=>x.Length).ThenBy(x=>x).ToList();
        listInput.ForEach(x=>Console.WriteLine(x));
        Console.ReadLine();
    }
}
