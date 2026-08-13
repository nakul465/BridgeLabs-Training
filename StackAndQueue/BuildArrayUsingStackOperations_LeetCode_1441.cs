using System;
namespace StackAndQueue
{
	public class BuildArrayUsingStackOperations_LeetCode_1441
	{
        public IList<string> BuildArray(int[] target, int n)
        {
            string s1 = "Push";
            string s2 = "Pop";
            List<string> res = new List<string>();
            for (int i = 1, j = 0; j < target.Length; j++, i++)
            {
                while (i != target[j])
                {
                    res.Add(s1);
                    res.Add(s2);
                    i++;
                }
                res.Add(s1);
            }
            return res;
        }
    }
}

