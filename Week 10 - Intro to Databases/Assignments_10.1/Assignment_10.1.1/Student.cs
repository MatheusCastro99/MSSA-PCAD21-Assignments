using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10._1._1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }

        public override string ToString()
        {
            string toString = $"ID: {Id}\n" +
                $"Name: {Name}\n" +
                $"Age: {Age}\n" +
                $"Major: {Major}";

            return toString;
        }
    }
}
