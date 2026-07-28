using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Assignment4._1._2
{
    public class MyMath : ICalculator
    {
        //List<double> valuesList = new();

        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b) 
        {
            return a - b;
        }
        public double Div(double a, double b) 
        {
            if(b== 0)
            {
                MessageBox.Show("Cannot Divide by 0");
                return 0;
            }

            return a / b;
        }
        public double Mult(double a, double b) 
        {
            return (a * b);
        }
    }
}
