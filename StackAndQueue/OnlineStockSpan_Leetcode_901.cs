using System;
namespace StackAndQueue
{
    public class StockSpanner
    {
        Stack<int> st1;
        Stack<int> st2;
        public StockSpanner()
        {
            st1 = new Stack<int>();
            st2 = new Stack<int>();
        }

        public int Next(int price)
        {
            int res = 1;
            while (st1.Count != 0)
            {
                int a = st1.Peek();
                if (a <= price)
                {
                    st2.Push(st1.Pop());
                    res++;
                }
                else
                {
                    break;
                }
            }
            while (st2.Count != 0)
            {
                st1.Push(st2.Pop());
            }
            st1.Push(price);
            return res;
        }
    }
}

