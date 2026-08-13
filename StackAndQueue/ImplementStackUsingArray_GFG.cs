using System;
namespace StackAndQueue
{
    class myStack
    {
        int[] arr;
        int i = 0;
        int arraySize;
        public myStack(int n)
        {
            // Define Data Structures
            arr = new int[n];
            arraySize = n;
        }

        public bool isEmpty()
        {
            // check if the stack is empty
            if (i == 0) return true;
            return false;
        }

        public bool isFull()
        {
            // check if the stack is full
            if (i == arraySize) return true;
            return false;
        }

        public void push(int x)
        {
            // Inserts x at the top of the stack
            arr[i] = x;
            i++;
        }

        public void pop()
        {
            // Removes an element from the top of the stack
            if (i == 0) return;
            arr[i - 1] = -1;
            i--;
        }

        public int peek()
        {
            // Returns the top element of the stack
            if (i == 0) return -1;
            return arr[i - 1];
        }
    }
}

