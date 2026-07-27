using System;
namespace Methods
{
	public class l2prob7
	{
        public void CheckStudentVotes()
        {
            int[] ages = new int[10];

            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine("Invalid age. Student cannot vote.");
                }
                else if (ages[i] >= 18)
                {
                    Console.WriteLine("Student can vote.");
                }
                else
                {
                    Console.WriteLine("Student cannot vote.");
                }
            }
        }
    }
}

