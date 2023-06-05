using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonRaphson
{
    internal class Program
    {
        static float Function(float x)
        {
            return (float)(Math.Pow(2, x) - (5 * x) + 2);
        }

        static float Derivative(float x)
        {
            return (float)(Math.Log(2) * Math.Pow(2, x) - 5);
        }

        static void Main(string[] args)
        {
            float ApproximateValue = 2;
            float error = 1;
            float epsilon = 0.01f;
            int NumberOfIterations = 0;

            while (error > epsilon)
            {
                NumberOfIterations++;

                float f = Function(ApproximateValue);
                float f_derivative = Derivative(ApproximateValue);
                float new_ApproximateValue = ApproximateValue - (f / f_derivative);

                error = Math.Abs(new_ApproximateValue - ApproximateValue);
                ApproximateValue = new_ApproximateValue;
            }

            Console.WriteLine("Approximate Value is : " + ApproximateValue + " with " + NumberOfIterations + " Iterations.");
        }
    }
}
