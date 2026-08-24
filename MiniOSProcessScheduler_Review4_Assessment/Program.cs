using MiniOSProcessScheduler_Review4_Assessment;

Process p1 = new Process(1, 12, 3, "P1");
Process p2 = new Process(2, 12, 4, "P2");
Process p3 = new Process(3, 12, 5, "P3");
Process p4 = new Process(4, 12, 6, "P4");
Process p5 = new Process(5, 12, 7, "P5");

p1.FunctionA();
Console.WriteLine();
p1.currentCall();
Console.WriteLine();
ProcessScheduler processScheduler = new ProcessScheduler();

Process[] arr = { p5,p2,p1,p4,p3};

processScheduler.AddProcess(p5);
processScheduler.AddProcess(p2);
processScheduler.AddProcess(p1);
processScheduler.AddProcess(p4);
processScheduler.AddProcess(p3);


processScheduler.ForwardTraversal();
processScheduler.BackwardTraversal();
Console.WriteLine();

ProcessScheduler.SortProcesses(arr);

foreach(Process p in arr)
{
    Console.Write($"{p.name}" + " ");
}
Console.WriteLine();
Console.WriteLine();
Process res = ProcessScheduler.BinarySearchOnPID(arr, 3);

Console.WriteLine($"PID : {res.pid} , Name : {res.name}");

Process? res2 = processScheduler.FindProcess(2);

if (res2 != null)
{
    Console.WriteLine($"PID : {res2.pid} , Name : {res2.name}");
}

Process? res3 = processScheduler.FindProcess(20);

processScheduler.Execute();
Console.WriteLine();

processScheduler.DisplayLog();
Console.WriteLine();

processScheduler.DisplayReadyQueue();