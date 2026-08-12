using System;
namespace LinkedListPractice
{
	public class Tasks
	{
		public int id;
		public string name;
		public int priority;
		public int dueDate;
		public Tasks next;
		public Tasks(int id,string name,int priority,int dueDate)
		{
			this.id = id;
			this.name = name;
			this.priority = priority;
			this.dueDate = dueDate;
		}

		public static Tasks AddAtStartOrEnd(Tasks head,Tasks newTask)
		{
			if (head.next == head)
			{
				head.next = newTask;
				newTask.next = head;
				return newTask;
			}
			Tasks temp = head;
			while (temp.next != head)
			{
				temp = temp.next;
			}
			temp.next = newTask;
			newTask.next = head;
			return newTask;
		}

		public static void DisplayAllTaskDetails(Tasks head)
		{
			Tasks temp = head;
			Console.WriteLine($"TaskName : {head.name}\nTaskId : {head.id}\nPriority : {head.priority}\nDueDate : {head.dueDate}\n");
			temp = temp.next;
			while (temp != head)
			{
                Console.WriteLine($"TaskName : {temp.name}\nTaskId : {temp.id}\nPriority : {temp.priority}\nDueDate : {temp.dueDate}\n");
				temp = temp.next;
            }
		}

		public static void DisplayDetails(Tasks t1)
		{
            Console.WriteLine($"TaskName : {t1.name}\nTaskId : {t1.id}\nPriority : {t1.priority}\nDueDate : {t1.dueDate}\n");
        }

		public static Tasks AddAtPos(Tasks head,Tasks newTask,int pos)
		{
            Tasks temp = head;
            int i = 1;
			while (i < pos - 1)
			{
				temp = temp.next;
				i++;
			}
			newTask.next = temp.next;
			temp.next = newTask;
			return head;
		}

		public static Tasks RemveTaskByID(Tasks head,int id)
		{
			Tasks temp = head;
			while (temp.next.id != id)
			{
				temp = temp.next;
			}
			temp.next = temp.next.next;
			if (head.id == id) return head.next;
			return head;
		}

		public static Tasks SearchTasksByPriority(Tasks head, int priority)
		{
            Tasks temp = head;
			while (temp.priority != priority)
			{
				temp = temp.next;
			}
			return temp;

        }
	}
}

