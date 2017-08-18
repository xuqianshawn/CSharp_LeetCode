using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace LeetCode
{
      public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
      }
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
            //for (int i = 1; i <= 10; i++)
            //{
            //    Thread t1 = new Thread(new ThreadStart(CountUp));
            //    t1.Name = "t"+i;

            //    t1.Start();
            //}
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);
            node1.next=node2;
            node2.next = node3;
            ListNode nodeAll=MergeTwoLists(node1,node4);
            

            Console.ReadLine();
        }
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }
            ListNode mergedOne= new ListNode(0);
            List<int> allInt = new List<int>();
            while (l1 != null)
            {
                allInt.Add(l1.val);
                l1 = l1.next;
            }
            while (l2 != null)
            {
                allInt.Add(l2.val);
                l2 = l2.next;
            }
            var list = allInt.OrderBy(x=>x).ToList();
            mergedOne.val = list.FirstOrDefault();
            ListNode tracker = mergedOne;
            bool isFirstElement = true;
            foreach (int i in list)
            {
                if (isFirstElement)
                {
                    isFirstElement = false;
                    continue;
                }
                ListNode temp = new ListNode(i);
                tracker.next = temp;
                tracker = tracker.next;
            }
            return mergedOne;
        }

        //public static void CountUp()
        //{
        //    while (Runs < 100)
        //    {
        //        // acquire the mutex
        //        Console.WriteLine(Thread.CurrentThread.Name + " is waiting " + Runs);
        //        semaphore.WaitOne();
        //        int Temp = Runs;
        //        Temp++;
        //        Console.WriteLine(Thread.CurrentThread.Name + " " + Temp);
        //        Thread.Sleep(800);
        //        Runs = Temp;
        //        // release the mutex
        //        semaphore.Release();
        //    }
        //}
        //public static String[] FindTopNGram(String s, int ngram, int topCount)
        //{
        //    string[] words = s.Split(' ');
        //   
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
        //        
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
