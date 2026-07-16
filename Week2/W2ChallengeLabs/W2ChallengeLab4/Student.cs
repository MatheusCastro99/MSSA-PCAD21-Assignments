using System;
using System.Collections.Generic;
using System.Text;

namespace W2ChallengeLab4
{
    public class Student
    {
        public int RollNum { get; set; }
        public string Name { get; set; }
        private int TotalMarks { get; set; }
        private double Percentage { get; set; }
        private string Division { get; set; } = "";
        private Dictionary<string, int> SubjectEnrolled { get; set; }

        public Student(int rollNum, string name)
        {
            RollNum = rollNum;
            Name = name;
            SubjectEnrolled = new Dictionary<string, int>();

            Console.WriteLine($"We welcome {Name} to our school!");
            Console.WriteLine();
        }

        public void AddGrade (string subject, int grade)
        {
            SubjectEnrolled[subject] = grade;

            Console.WriteLine($"{Name}, {subject}: {grade}\nAdded Successfully!");
            Console.WriteLine();
        }

        private void SetTotalMarks()
        {
            foreach (KeyValuePair<string, int> grade in SubjectEnrolled)
            {
                TotalMarks += grade.Value;
            }

            Console.WriteLine($"Total Marks: {TotalMarks}");
        }

        private void SetPercentage() 
        {
            if (SubjectEnrolled.Count > 0)
            {
                Percentage = TotalMarks / SubjectEnrolled.Count;
            }
    
            Console.WriteLine($"Average: {Percentage:F2}");
        }

        private void SetDivision ()
        {
            Division = (int)Math.Round(Percentage) switch
            {
                (>= 80) => "First",
                (<80 and >= 60) => "Second",
                (<60) => "Failing"
            };

            Console.WriteLine($"Division: {Division}");
        }

        public void DisplayGrades() 
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("\nGrades: ");

            foreach (KeyValuePair<string, int> entry in SubjectEnrolled)
            {
                string subjectName = entry.Key;
                int grade = entry.Value;

                Console.WriteLine($"{subjectName}: {grade}");
            }

            SetTotalMarks();
            SetPercentage();
            SetDivision();

            Console.WriteLine("\n////////////////////////////////////////////\n");
        }
    }
}
