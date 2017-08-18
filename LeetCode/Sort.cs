using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

class Sort
{

    static void Main(String[] args)
    {
        //string[] tokens_n = Console.ReadLine().Split(' ');
        //int n = Convert.ToInt32(tokens_n[0]);
        //int k = Convert.ToInt32(tokens_n[1]);
        //string[] x_temp = Console.ReadLine().Split(' ');
        //int[] x = Array.ConvertAll(x_temp, Int32.Parse);
        //Console.WriteLine();
        //Console.ReadLine();
        int[] test = { 15,9, 8, 0,7, 6, 5, 4, 3, 2, 1 };
        InsertionSort(test);
        Console.Read();
    }
    /*
 * Complete the function below.
 */
    static string findNumber(int[] arr, int k)
    {

        if (arr.Contains(k))
        {
            return"YES";
        }
        else
        {
            return "NO";
        }
    }
    static int[] oddNumbers(int l, int r)
    {
        List<int> returnL = new List<int>();
        for (int i = l; i < r; i++)
        {
            if (i % 2 != 0)
            {
                returnL.Add(i);
            }
        }
        return (returnL.ToArray());
    }
    public static void swap(int[] input, int i, int j)
    {
        int temp = input[i];
        input[i] = input[j];
        input[j] = temp;
    }
    public static void InsertionSort(int[] intArray)
    {
        Console.WriteLine("==========Integer Array Input===============");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine(intArray[i]);
        }

        int temp = 0;
        int j = 0;
        //  9 8 7 6
        // 1st temp=8; j=0; 
        // 9 9 7 6 j=-1;
        //8 9 7 6

        //2nd i=2 j=1 temp=7  intArry[1]is9>7
        //8 9 9 6 j=0 intArry[0]is8>7
        //8 8 9 6 j=-1
        //7 8 9 6

        //3rd i=3 temp=6 j=2 intArry[2]is9>6
        //7 8 9 9 j=1
        //7 8 8 9 j=0
        //7 7 8 9 j=-1
        //6 7 8 9
        for (int i = 1; i < intArray.Length; i++)
        {
            temp = intArray[i];
            j = i - 1;
            while (j >= 0 && intArray[j] > temp)
            {
                intArray[j + 1] = intArray[j];
                j--;

            }
            intArray[j + 1] = temp;
        }

        Console.WriteLine("==========Integer Array OutPut===============");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine(intArray[i]);
        }
    }
    //static int getCountries(string str, int p)
    //{
    //    string html = string.Empty;
    //    string url = @"http://restcountries.eu/rest/v1/name/" + str;

    //    System.Net.HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
    //    request.AutomaticDecompression = DecompressionMethods.GZip;

    //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
    //    using (Stream stream = response.GetResponseStream())
    //    using (StreamReader reader = new StreamReader(stream))
    //    {
    //        html = reader.ReadToEnd();
    //    }
    //    var objects = JArray.Parse(html);
    //    foreach (JObject root in objects)
    //    {
    //        foreach (KeyValuePair<String, JToken> app in root)
    //        {
    //            Console.WriteLine(app.Value);

    //        }
    //    }
    //    return 0;
    //}
}
