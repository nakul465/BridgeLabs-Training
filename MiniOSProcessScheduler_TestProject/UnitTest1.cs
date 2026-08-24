namespace MiniOSProcessScheduler_TestProject;
using MiniOSProcessScheduler_Review4_Assessment;
public class Tests
{
    Process p1;
    Process p2;
    Process p3;
    Process p4;
    Process p5;
    Process[] arr1;
    Process[] arr2;
    ProcessScheduler processScheduler;
    [SetUp]
    public void Setup()
    {
        p1 = new Process(1, 12, 3, "P1");
        p2 = new Process(2, 13, 4, "P2");
        p3 = new Process(3, 14, 5, "P3");
        p4 = new Process(4, 15, 6, "P4");
        p5 = new Process(5, 16, 7, "P5");
        arr1 = new Process[] { p5, p2, p1, p4, p3 };
        arr2 = new Process[] { p4, p1, p3, p2, p5 };
        processScheduler = new ProcessScheduler();
        processScheduler.AddProcess(p5);
        processScheduler.AddProcess(p2);
        processScheduler.AddProcess(p1);
        processScheduler.AddProcess(p4);
        processScheduler.AddProcess(p3);
    }

    [Test]
    public void MethodToCheckForwardLinks()
    {
        Assert.That(processScheduler.head.process.pid, Is.EqualTo(5));
        Assert.That(processScheduler.head.next.process.pid, Is.EqualTo(2));
        Assert.That(processScheduler.head.next.next.process.pid, Is.EqualTo(1));
        Assert.That(processScheduler.tail.process.pid, Is.EqualTo(3));
    }

    [Test]
    public void MethodToCheckCallStackOperations()
    {
        Process p = new Process(10, 3, 8, "TestProcess");

        p.FunctionA();

        Assert.That(p.RecursionDepth(), Is.EqualTo(0));
    }

    [Test]
    public void MethodToCheckBackwardLinks()
    {
        Assert.That(processScheduler.tail.process.pid, Is.EqualTo(3));
        Assert.That(processScheduler.tail.prev.process.pid, Is.EqualTo(4));
        Assert.That(processScheduler.tail.prev.prev.process.pid, Is.EqualTo(1));
        Assert.That(processScheduler.head.process.pid, Is.EqualTo(5));
    }

    [Test]
    public void MethodToCheckTheMergeSortFunctionality()
    {
        ProcessScheduler.SortProcesses(arr1);
        bool isSorted = true;
        for(int i = 0; i < arr1.Length-1; i++)
        {
            if (arr1[i].burstTime > arr1[i + 1].burstTime)
            {
                isSorted = false;
            }
        }
        Assert.That(isSorted, Is.True);
    }

    [Test]
    public void MethodToCheckTheMergeSortFunctionality2()
    {
        ProcessScheduler.SortProcesses(arr2);
        bool isSorted = true;
        for (int i = 0; i < arr2.Length - 1; i++)
        {
            if (arr2[i].burstTime > arr2[i + 1].burstTime)
            {
                isSorted = false;
            }
        }
        Assert.That(isSorted, Is.True);
    }

    [TestCase(3)]
    [TestCase(4)]
    [TestCase(5)]
    public void MethodToCheckBinarySearchFunctionality(int pid)
    {
        ProcessScheduler.SortProcessesByPID(arr1);
        Process p=ProcessScheduler.BinarySearchOnPID(arr1, pid);
        Assert.That(p.pid, Is.EqualTo(pid));
    }

    [Test]
    public void BinarySearchInvalidPID()
    {
        ProcessScheduler.SortProcessesByPID(arr1);

        Process? result =ProcessScheduler.BinarySearchOnPID(arr1, 100);

        Assert.That(result, Is.Null);
    }

    [TestCase(3)]
    [TestCase(40)]
    [TestCase(5)]
    public void MethodToCheckSearchFunctionalityThroughHashMap(int pid)
    {
        Process? res2 = processScheduler.FindProcess(pid);
        if (res2 != null)
        {
            Assert.That(res2.pid, Is.EqualTo(pid));
        }
        else
        {
            Assert.That(res2, Is.EqualTo(null));
        }
        
    }

    [Test]
    public void MethodToCheckAddInProcessSchedulerFunctionality()
    {
        Process p = new Process(6, 17, 8, "P6");
        processScheduler.AddProcess(p);
        Assert.That(processScheduler.tail.process.pid, Is.EqualTo(6));
    }

    [Test]
    public void MethodToCheckAddInProcessSchedulerFunctionality2()
    {
        Process p = new Process(7, 17, 8, "P7");
        processScheduler.AddProcess(p);
        Assert.That(processScheduler.tail.process.pid, Is.EqualTo(7));
    }

    [Test]
    public void CheckDoublyLinkedList()
    {
        Assert.That(processScheduler.head.process.pid, Is.EqualTo(5));
        Assert.That(processScheduler.head.next.process.pid, Is.EqualTo(2));
        Assert.That(processScheduler.tail.process.pid, Is.EqualTo(3));
        Assert.That(processScheduler.tail.prev.process.pid, Is.EqualTo(4));
    }

    [Test]
    public void MethodToCheckExpectedBurstOrder()
    {
        ProcessScheduler.SortProcesses(arr1);

        Assert.That(arr1[0].burstTime, Is.EqualTo(3));
        Assert.That(arr1[1].burstTime, Is.EqualTo(4));
        Assert.That(arr1[2].burstTime, Is.EqualTo(5));
        Assert.That(arr1[3].burstTime, Is.EqualTo(6));
        Assert.That(arr1[4].burstTime, Is.EqualTo(7));
    }

    [Test]
    public void MethodToCheckProcessCompletion()
    {
        ProcessScheduler scheduler = new ProcessScheduler();

        Process p = new Process(1, 3, 3, "P1");

        scheduler.AddProcess(p);

        scheduler.Execute();

        Assert.That(p.isCompleted, Is.True);
        Assert.That(p.remainingBurstTime, Is.EqualTo(0));
    }

    [Test]
    public void MethodToCheckRoundRobinScheduling()
    {
        ProcessScheduler scheduler = new ProcessScheduler();

        Process p1 = new Process(1, 3, 7, "P1");
        Process p2 = new Process(2, 3, 5, "P2");
        Process p3 = new Process(3, 3, 4, "P3");

        scheduler.AddProcess(p1);
        scheduler.AddProcess(p2);
        scheduler.AddProcess(p3);

        scheduler.Execute();

        Assert.That(p1.isCompleted, Is.True);
        Assert.That(p2.isCompleted, Is.True);
        Assert.That(p3.isCompleted, Is.True);

        Assert.That(p1.remainingBurstTime, Is.EqualTo(0));
        Assert.That(p2.remainingBurstTime, Is.EqualTo(0));
        Assert.That(p3.remainingBurstTime, Is.EqualTo(0));
    }
}
