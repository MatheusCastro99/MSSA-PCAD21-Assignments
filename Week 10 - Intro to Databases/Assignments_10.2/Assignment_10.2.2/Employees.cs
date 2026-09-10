using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10._2._2
{
    public class Employees
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

        public Employees(string name, int salary, int age)
        {
            Name = name;
            Salary = salary;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Age: {Age}\n" +
                $"Salary: {Salary}";
        }
    }
}
