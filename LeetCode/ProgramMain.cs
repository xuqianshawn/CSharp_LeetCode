using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ProgramMain
    {
        public static void Main(string[] args)
        {
            MyQueue<int> test = new MyQueue<int>();
            test.Enqueue(1);
            test.Enqueue(2);
            test.Enqueue(3);
            test.Enqueue(4);
            test.Enqueue(5);
            test.Dequeue();
            test.Enqueue(6);
            test.Enqueue(7);
            Console.Out.WriteLine(test.Dequeue());
            Console.Out.WriteLine(test.Dequeue());
            Console.Out.WriteLine(test.Dequeue());
            Console.Out.WriteLine(test.Dequeue());
            Console.Out.WriteLine(test.Dequeue());
            Console.Out.WriteLine(test.Dequeue());
        }
    }
}
