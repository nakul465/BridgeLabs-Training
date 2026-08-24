using System;
namespace MiniOSProcessScheduler_Review4_Assessment
{
	public class ProcessStack
	{
		Stack<string> callStack;
		public ProcessStack()
		{
			callStack = new Stack<string>();
		}

		protected void AddCall(string f1)
		{
			callStack.Push(f1);
		}

		public void RemoveCall()
		{
			try
			{
				if (callStack.Count <= 0)
				{
					throw new Exception("Call Stack Empty");
				}
                callStack.Pop();
            }
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
            }
		}

		public string currentCall()
		{
            try
            {
                if (callStack.Count <= 0)
                {
                    throw new Exception("Call Stack Empty");
                }
				return callStack.Peek();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				return "";
            }
        }

		public int RecursionDepth()
		{
			return callStack.Count;
		}
	}
}

