using System;
namespace StackAndQueue
{
    public class MinStack
    {
        Stack<int> ogStack;
        Stack<int> minStack;
        public MinStack()
        {
            ogStack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int value)
        {
            if (ogStack.Count == 0)
            {
                minStack.Push(value);
            }
            else
            {
                if (minStack.Peek() < value)
                {
                    minStack.Push(minStack.Peek());
                }
                else
                {
                    minStack.Push(value);
                }
            }
            ogStack.Push(value);
        }

        public void Pop()
        {
            minStack.Pop();
            ogStack.Pop();
        }

        public int Top()
        {
            return ogStack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
    }
}

