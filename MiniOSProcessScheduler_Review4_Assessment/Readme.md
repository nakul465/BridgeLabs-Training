Overview: In this Problem Statement i was suppose to design a mini OS Process Scheduler to show how an operating system manages CPU processes
using Round robin Scheduling algorithm where each process gets a fixed amount of CPU time called a time slice. If a process does not finish
within its time slice, it goes back into the ready queue and waits for its next turn.

To solve this Problem I:
1.  Made a process class that contains feilds pid,timeSlice,remainingBurstTime,burstTime,name,public bool isCompleted and it have 4 functions
FunctionA,B,C,D to Demostarte Recursion CallStack and extends class ProcessStack,which contains functions to add,retrieve current ,remove top
function call to Callstack.
2.  Now we have a ProcessScheduler class which extends ProcessList, ProcessList contains all the functions to create and manage the doubly linked
list storing the Processes and a singly linked list storing the completed logs and it also has methods to iterate and display both the lists
it also has a dictionary that stores pid assosiated with processes for easy retrival in O(1) time.
3.  ProcessScheduler has a readyQueue that stores the order in which the proccess were executed like if i added 3 process p1->p2->p3 and p1
finished its execution in first TimeSlice/TimeQuamtum and other two finish in second cycle then ready queue will store p1->p2->p3->p2->p3
4.  ProcessScheduler has a Execute function that basically executes all the Processess According to Round Robin Scheduling and we also have
merge sort implemented in two ways in one we sort by pid and in other we sort by burst times and we also have binaru search implemented
to searcg by PID.

Complexity Analysis:
1. Dictionary :
    get() -> O(1)
    add() -> O(1)

2. DoublyLinkedList :
    Add() -> O(1) as we are storing tail

3. SinglyLinkedList :
    Add() -> O(1) as we are storing tail

4. Merge Sort:
    time  -> O(NlogN)
    space -> O(N)

5. Binary Search:
    time  -> O(logN)
    space -> O(1)

6. Queue:
    Enqueue() -> O(1)
    Dequeue() -> O(1)

7. Stack:
    Push() -> O(1)
    Pop()  -> O(1)