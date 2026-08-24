using System;
namespace MiniOSProcessScheduler_Review4_Assessment
{
	public class Process : ProcessStack
	{
		public int pid;
		public int timeSlice;
		public int remainingBurstTime;
		public int burstTime;
		public string name;
		public bool isCompleted;
		public Process(int pid,int timeSlice,int burstTime,string name)
		{
			this.pid = pid;
			this.timeSlice = timeSlice;
			this.name = name;
			this.burstTime = burstTime;
            remainingBurstTime = burstTime;
			isCompleted = false;
        }

		public Process() { }

        public void FunctionA()
        {
            AddCall("FunctionA()");
            FunctionB();
            Console.WriteLine($"Recursion Depth : {RecursionDepth()}  {currentCall()}");
            RemoveCall();
        }
        public void FunctionB()
        {
            AddCall("FunctionB()");
            FunctionC();
            Console.WriteLine($"Recursion Depth : {RecursionDepth()}  {currentCall()}");
            RemoveCall();
        }
        public void FunctionC()
        {
            AddCall("FunctionC()");
            FunctionD();
            Console.WriteLine($"Recursion Depth : {RecursionDepth()}  {currentCall()}");
            RemoveCall();

        }
        public void FunctionD()
        {
            AddCall("FunctionD()");
            Console.WriteLine($"Recursion Depth : {RecursionDepth()}  {currentCall()}");
            RemoveCall();
        }
    }

	public class ProcessScheduler : ProcessList
	{
		Queue<Process> readyQueue;
		public ProcessScheduler()
		{
            readyQueue = new Queue<Process>();
        }
		public void Execute()
		{
			int totalNoOfProcesses = lookUp.Count;
			while (true)
			{
                Node temp = head;
				int countOfCompletedProcesses=0;
				while (temp != null)
				{
					if (temp.process.remainingBurstTime <= 0)
					{
						if (temp.process.isCompleted == false)
						{
                            AddProcessLog(temp.process);
							temp.process.isCompleted = true;
                        }
                        countOfCompletedProcesses++;
					}
					else
					{
                        temp.process.remainingBurstTime -= temp.process.timeSlice;
                        if (temp.process.remainingBurstTime < 0) temp.process.remainingBurstTime = 0;
                        readyQueue.Enqueue(temp.process);
                    }
                    temp = temp.next;
				}
				if (countOfCompletedProcesses == totalNoOfProcesses) break;
            }
		}

		public static void SortProcesses(Process[] arr)
		{
            MergeSort(arr, 0, arr.Length - 1);
		}

		static void MergeSort(Process[] arr,int left,int right)
		{
			if (left >= right) return;
			int mid = (left + right) / 2;

			MergeSort(arr,left, mid);
            MergeSort(arr, mid+1, right);

			Merge(arr, left,mid, right);

        }
		static void Merge(Process[] arr, int left,int mid, int right)
		{
            int i = left;
            int j = mid + 1;

            Process[] temp = new Process[right - left + 1];
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i].burstTime <= arr[j].burstTime)
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }

            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            for (int x = 0; x < temp.Length; x++)
            {
                arr[left + x] = temp[x];
            }
        }



        public static void SortProcessesByPID(Process[] arr)
        {
            MergeSortOnPID(arr, 0, arr.Length - 1);
        }

        static void MergeSortOnPID(Process[] arr, int left, int right)
        {
            if (left >= right) return;
            int mid = (left + right) / 2;

            MergeSortOnPID(arr, left, mid);
            MergeSortOnPID(arr, mid + 1, right);

            MergeOnPID(arr, left, mid, right);

        }

        static void MergeOnPID(Process[] arr, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;

            Process[] temp = new Process[right - left + 1];
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i].pid <= arr[j].pid)
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }

            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            for (int x = 0; x < temp.Length; x++)
            {
                arr[left + x] = temp[x];
            }
        }

        public static Process BinarySearchOnPID(Process[] arr,int pid)
        {
            int left = 0;
            int right = arr.Length-1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid].pid == pid)
                {
                    return arr[mid];
                }else if(arr[mid].pid > pid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            Console.WriteLine("Process Not Found");
            return null;

        }


        public void DisplayReadyQueue()
        {
            foreach(Process p in readyQueue)
            {
                Console.Write($"{p.name}->");
            }
        }
    }
}

