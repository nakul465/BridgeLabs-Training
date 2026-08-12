using System;
namespace LinkedListPractice
{
    public class Process
    {
        public int processId;
        public int burstTime;
        public int remainingTime;
        public int priority;
        public int completionTime;
        public Process next;

        public Process(int processId, int burstTime, int priority)
        {
            this.processId = processId;
            this.burstTime = burstTime;
            this.remainingTime = burstTime;
            this.priority = priority;
            this.completionTime = 0;
            this.next = null;
        }
    }

    public class RoundRobinScheduler
    {
        private Process tail;
        private int totalProcesses;

        public void AddProcess(Process newProcess)
        {
            if (tail == null)
            {
                tail = newProcess;
                newProcess.next = newProcess;
            }
            else
            {
                newProcess.next = tail.next;
                tail.next = newProcess;
                tail = newProcess;
            }

            totalProcesses++;
        }

        public void RemoveProcess(int processId)
        {
            if (tail == null)
                return;

            Process current = tail.next;
            Process previous = tail;

            do
            {
                if (current.processId == processId)
                {
                    if (current == tail && current.next == tail)
                    {
                        tail = null;
                    }
                    else
                    {
                        previous.next = current.next;

                        if (current == tail)
                            tail = previous;
                    }

                    totalProcesses--;
                    return;
                }

                previous = current;
                current = current.next;

            } while (current != tail.next);
        }

        public void DisplayProcesses()
        {
            if (tail == null)
            {
                Console.WriteLine("No processes remaining.");
                return;
            }

            Process current = tail.next;

            do
            {
                Console.WriteLine(
                    $"PID: {current.processId}, " +
                    $"Burst: {current.burstTime}, " +
                    $"Remaining: {current.remainingTime}, " +
                    $"Priority: {current.priority}"
                );

                current = current.next;

            } while (current != tail.next);
        }

        public void Schedule(int quantum)
        {
            if (tail == null)
                return;

            int currentTime = 0;

            while (tail != null)
            {
                Process current = tail.next;

                do
                {
                    Process nextProcess = current.next;

                    int executionTime = Math.Min(quantum, current.remainingTime);

                    current.remainingTime -= executionTime;
                    currentTime += executionTime;

                    if (current.remainingTime == 0)
                    {
                        current.completionTime = currentTime;
                        RemoveProcess(current.processId);
                    }

                    current = nextProcess;

                    if (tail == null)
                        break;

                } while (current != tail.next);

                Console.WriteLine("\nProcesses after round:");
                DisplayProcesses();
            }
        }

        public void DisplayAverageTimes(List<Process> processes)
        {
            double totalWaitingTime = 0;
            double totalTurnaroundTime = 0;

            foreach (Process process in processes)
            {
                int turnaroundTime = process.completionTime;
                int waitingTime = turnaroundTime - process.burstTime;

                totalTurnaroundTime += turnaroundTime;
                totalWaitingTime += waitingTime;

                Console.WriteLine(
                    $"PID: {process.processId}, " +
                    $"Waiting Time: {waitingTime}, " +
                    $"Turnaround Time: {turnaroundTime}"
                );
            }

            Console.WriteLine(
                $"\nAverage Waiting Time: {totalWaitingTime / processes.Count}"
            );

            Console.WriteLine(
                $"Average Turnaround Time: {totalTurnaroundTime / processes.Count}"
            );
        }
    }
}

