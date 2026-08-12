using System;
namespace LinkedListPractice
{
	public class Student
	{
		public string name;
		public int roll;
		public int age;
		public char grade;
        public Student next;

		public Student(string name,int roll,int age,char grade)
		{
			this.name = name;
			this.roll = roll;
			this.age = age;
			this.grade = grade;
		}

		public static Student AddAtStart(Student head, Student newstudent)
		{
			newstudent.next = head;
			return newstudent;
		}

        public static Student AddAtEnd(Student head, Student newstudent)
        {
			Student temp = head;
			while (temp.next != null)
			{
				temp = temp.next;
			}
            temp.next = newstudent;
			return head;
        }

        public void DisplayDetails()
		{
			Console.WriteLine($"Name : {name}\nage : {age}\nroll : {roll}\ngrade : {grade}\n");
        }
		
		public static Student AddAtPos(Student head, Student newstudent, int pos)
		{
			if (pos == 1) return AddAtStart(head,newstudent);
			int i = 1;
			Student temp = head;
			while(temp.next!=null && i < pos - 1)
			{
				temp = temp.next;
				i++;
			}
			if (temp.next == null)
			{
				temp.next = newstudent;
			}
			else
			{
				Student temp2 = temp.next;
				temp.next = newstudent;
				newstudent.next = temp2;
			}
			return head;
		}

		public static Student DeleteByRoll(Student head,int roll)
		{
			Student temp = head;
			if (head.roll == roll)
			{
				if (head.next == null) return null;
				Student temp2 = head.next;
				head.next = null;
				return temp2;
			}
			Student prev = null;
			while(temp.roll!=roll && temp.next != null)
			{
				prev = temp;
				temp = temp.next;
			}
			if (temp.roll == roll)
			{
                prev.next = temp.next;
                return head;
            }
			return head;
		}

		public static Student FindByRoll(Student head,int roll)
		{
			Student temp = head;
			while (temp!=null && temp.roll != roll)
			{
				temp = temp.next;
			}
			if (temp == null)
			{
				Console.WriteLine("Student with such roll number doesn't exist");
				return head;
			}
			return temp;
		}

		public static void DisplayAllStudentsDetails(Student head)
		{
            while (head != null)
            {
                head.DisplayDetails();
                head = head.next;
            }
        }
		public static void ChangeGrade(Student head,int roll,char grade)
		{
			Student temp = head;
			while (temp.next != null)
			{
				if (temp.roll == roll)
				{
					temp.grade = grade;
					break;
				}
                temp = temp.next;
			}
		}
	}
}

