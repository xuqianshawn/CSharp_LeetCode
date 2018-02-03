using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MyQueue<T>
    {
        private Stack<T> _stack1=new Stack<T>();
        private Stack<T> _stack2=new Stack<T>();
        public void Enqueue(T input)
        {
            _stack1.Push(input);
        }
        public T Dequeue()
        {
            while (_stack1.Count>0)
            {
                _stack2.Push(_stack1.Pop());
            }
            //return the oldest item
            var temp = _stack2.Pop();

            while (_stack2.Count()>0)
            {
                _stack1.Push(_stack2.Pop());
            }
            return temp;
        }
    }
}
