using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceCalc
{
    public class Service1 : IScientificCalculatorService
    {
        // Basic arithmetic operations
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Divide(double n1, double n2)
        {
            if (n2 == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return n1 / n2;
        }

        // Scientific operations
        public double Power(double baseValue, double exponent)
        {
            return Math.Pow(baseValue, exponent);
        }

        public double SquareRoot(double value)
        {
            if (value < 0)
                throw new ArgumentException("Cannot calculate square root of a negative number");
            return Math.Sqrt(value);
        }

        public double Sine(double angleInDegrees)
        {
            return Math.Sin(DegreeToRadian(angleInDegrees));
        }

        public double Cosine(double angleInDegrees)
        {
            return Math.Cos(DegreeToRadian(angleInDegrees));
        }

        public double Tangent(double angleInDegrees)
        {
            return Math.Tan(DegreeToRadian(angleInDegrees));
        }

        public double Logarithm(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Logarithm input must be greater than zero");
            return Math.Log(value);
        }

        public double Exponential(double value)
        {
            return Math.Exp(value);
        }

        public double AbsoluteValue(double value)
        {
            return Math.Abs(value);
        }

        // Helper function to convert degrees to radians
        private double DegreeToRadian(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        // New method to perform multiple operations
        public Dictionary<string, double> PerformMultipleOperations(double value1, double value2)
        {
            var results = new Dictionary<string, double>();

            results["Add"] = Add(value1, value2);
            results["Subtract"] = Subtract(value1, value2);
            results["Multiply"] = Multiply(value1, value2);
            results["Divide"] = Divide(value1, value2);
            results["Power"] = Power(value1, value2);
            results["SquareRoot"] = SquareRoot(value1);
            results["Sine"] = Sine(value1);
            results["Cosine"] = Cosine(value1);
            results["Tangent"] = Tangent(value1);
            results["Logarithm"] = Logarithm(value1);
            results["Exponential"] = Exponential(value1);
            results["AbsoluteValue"] = AbsoluteValue(value1);

            return results;
        }
    }
}
