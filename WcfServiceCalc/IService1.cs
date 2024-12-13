using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServiceCalc
{
    [ServiceContract]
    public interface IScientificCalculatorService
    {
        // Basic arithmetic operations
        [OperationContract]
        double Add(double n1, double n2);

        [OperationContract]
        double Subtract(double n1, double n2);

        [OperationContract]
        double Multiply(double n1, double n2);

        [OperationContract]
        double Divide(double n1, double n2);

        // Scientific operations
        [OperationContract]
        double Power(double baseValue, double exponent);

        [OperationContract]
        double SquareRoot(double value);

        [OperationContract]
        double Sine(double angleInDegrees);

        [OperationContract]
        double Cosine(double angleInDegrees);

        [OperationContract]
        double Tangent(double angleInDegrees);

        [OperationContract]
        double Logarithm(double value);

        [OperationContract]
        double Exponential(double value);

        [OperationContract]
        double AbsoluteValue(double value);

        // New operation to perform multiple calculations
        [OperationContract]
        Dictionary<string, double> PerformMultipleOperations(double value1, double value2);
    }
}
