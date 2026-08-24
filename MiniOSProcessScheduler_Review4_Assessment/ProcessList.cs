using System;
namespace MiniOSProcessScheduler_Review4_Assessment
{
	public class ProcessList
	{
        public class Node
        {
            public Node prev;
            public Node next;
            public Process process;
            public Node(Process process)
            {
                this.process = process;
            }
            public Node() { }
        }

        public Dictionary<int, Process> lookUp;

        public Node head;
        public Node tail;

        Node logHead;
        Node logTail;

        public void AddProcessLog(Process p1)
        {
            if (logHead == null)
            {
                logHead = new Node(p1);
                logTail = logHead;
            }
            else
            {
                logTail.next = new Node(p1);
                logTail = logTail.next;
            }
        }

        public void DisplayLog()
        {
            Node temp = logHead;
            if (temp == null)
            {
                Console.WriteLine("Process log list is empty.");
                return;
            }
            while (temp!=null && temp.next != null)
            {
                Console.Write($"{temp.process.name}->");
                temp = temp.next;
            }
            Console.WriteLine($"{temp.process.name}");
        }


        public void AddProcess(Process p1)
        {
            lookUp[p1.pid] = p1;
            if (head == null)
            {
                head = new Node(p1);
                tail = head;
            }
            else
            {
                tail.next = new Node(p1);
                tail.next.prev = tail;
                tail = tail.next;
            }
        }

        public void ForwardTraversal()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Process list is empty.");
                return;
            }
            while (temp!=null && temp.next != null)
            {
                Console.Write($"{temp.process.name}⇄");
                temp = temp.next;
            }
            Console.WriteLine($"{temp.process.name}");
        }

        public void BackwardTraversal()
        {
            Node temp = tail;
            if (temp == null)
            {
                Console.WriteLine("Process list is empty.");
                return;
            }
            while (temp.prev != null)
            {
                Console.Write($"{temp.process.name}⇄");
                temp = temp.prev;
            }
            Console.WriteLine($"{temp.process.name}");
        }



        public ProcessList()
        {
            lookUp = new Dictionary<int, Process>();
        }

        public Process? FindProcess(int pid)
        {
            try
            {
                Process res = lookUp[pid];
                return res;
            }
            catch
            {
                Console.WriteLine($"the process with {pid} doesn't exist.");
                return null;
            }
        }
    }
}

