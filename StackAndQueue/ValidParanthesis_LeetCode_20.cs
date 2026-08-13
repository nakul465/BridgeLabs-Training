using System;
namespace StackAndQueue
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length == 0) return true;
            if (s.Length % 2 != 0) return false;
            Stack<char> st = new Stack<char>();
            foreach (char ch in s)
            {
                if (st.Count == 0)
                {
                    if (ch == ')' || ch == ']' || ch == '}') return false;
                    st.Push(ch);
                }
                else
                {
                    if (ch == '(' || ch == '[' || ch == '{')
                    {
                        st.Push(ch);
                        continue;
                    }
                    else if (ch == ')' && st.Peek() != '(') return false;
                    else if (ch == ']' && st.Peek() != '[') return false;
                    else if (ch == '}' && st.Peek() != '{') return false;
                    st.Pop();
                }
            }
            if (st.Count == 0) return true;
            return false;
        }
    }
}

