using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace LeetCode
{
    class Program
    {
        private static int Runs = 0;
        static Semaphore semaphore = new Semaphore(2,2);
        static void Main(string[] args)
        {
            //string input = "the dog likes to walk and the dog also likes to chase the mail man";
            
            //string[] output = FindTopNGram(input, 2, 2);
            //Console.Write(string.Join("|", output));
            //CountUp();
            for (int i = 1; i <= 10; i++)
            {
                Thread t1 = new Thread(new ThreadStart(CountUp));
                t1.Name = "t"+i;

                t1.Start();
            }
            Console.ReadLine();
        }
        public static void CountUp()
        {
            while (Runs < 100)
            {
                // acquire the mutex
                Console.WriteLine(Thread.CurrentThread.Name + " is waiting " + Runs);
                semaphore.WaitOne();
                int Temp = Runs;
                Temp++;
                Console.WriteLine(Thread.CurrentThread.Name + " " + Temp);
                Thread.Sleep(800);
                Runs = Temp;
                // release the mutex
                semaphore.Release();
            }
        }
        //public static String[] FindTopNGram(String s, int ngram, int topCount)
        //{
        //    string[] words = s.Split(' ');
        //    List<string> ngrames = new List<string>();
        //    //for k words, there are k-n+1 ngrams
        //    Dictionary<string, int> dictionary = new Dictionary<string, int>();
        //    string ngramTemp = "";
        //    for (int i = 0; i <words.Length-ngram+1; i++)
        //    { 
        //        for(int n=0;n<ngram;n++)
        //        {
        //            if (n == 0)
        //                ngramTemp = words[i];
        //            else
        //                ngramTemp=ngramTemp+" "+words[i+n];
        //        }
        //        ngrames.Add(ngramTemp);
        //        if (dictionary.ContainsKey(ngramTemp)) //hash has that value
        //        {
        //            int counter = dictionary[ngramTemp];
        //            dictionary.Remove(ngramTemp);
        //            dictionary.Add(ngramTemp, ++counter);
        //        }
        //        else
        //        {
        //            dictionary.Add(ngramTemp, 1);
        //        }
        //        ngramTemp = "";
        //    }
        //   // var selectedTop = from each in dictionary orderby each.Value descending select each.Key;
        //    return dictionary.OrderByDescending(x => x.Value).Take(topCount).Select(x=>x.Key).ToArray();
        //}
    }
}
