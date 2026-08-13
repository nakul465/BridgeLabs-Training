using System;
namespace StackAndQueue
{
    public class MyQueue
    {
        Stack<int> st1;
        Stack<int> st2;
        public MyQueue()
        {
            st1 = new Stack<int>();
            st2 = new Stack<int>();
        }

        public void Push(int x)
        {
            st1.Push(x);
        }

        public int Pop()
        {
            while (st1.Count != 0)
            {
                st2.Push(st1.Pop());
            }
            int a = st2.Pop();
            while (st2.Count != 0)
            {
                st1.Push(st2.Pop());
            }
            return a;
        }

        public int Peek()
        {
            while (st1.Count != 0)
            {
                st2.Push(st1.Pop());
            }
            int a = st2.Peek();
            while (st2.Count != 0)
            {
                st1.Push(st2.Pop());
            }
            return a;
        }

        public bool Empty()
        {
            if (st1.Count == 0) return true;
            return false;
        }
    }
}

