using ServiceReference1;
using System;
using System.Collections.Generic;

namespace WcfClientCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the client object for the scientific calculator service
            ScientificCalculatorServiceClient client = new ScientificCalculatorServiceClient();

            // Input from console
            Console.Write("Enter value 1: ");
            double value1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value 2: ");
            double value2 = Convert.ToDouble(Console.ReadLine());

            List<int> choices = new List<int>(); // To store multiple choices

            bool continueChoosing = true;

            while (continueChoosing)
            {
                // Display operation choices
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Power");
                Console.WriteLine("6. SquareRoot");
                Console.WriteLine("7. Sine");
                Console.WriteLine("8. Cosine");
                Console.WriteLine("9. Tangent");
                Console.WriteLine("10. Logarithm");
                Console.WriteLine("11. Exponential");
                Console.WriteLine("12. Absolute Value");
                Console.WriteLine("13. Print all results");
                Console.WriteLine("0. Exit");

                // Get user's choice
                Console.Write("Enter your choice (1-13, 0 to exit): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    continueChoosing = false;  // Exit the loop
                }
                else
                {
                    if (choice >= 1 && choice <= 13)
                    {
                        choices.Add(choice); // Add the selected choice to the list
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                }
            }

            // Perform selected operations
            foreach (var choice in choices)
            {
                double result = 0;
                switch (choice)
                {
                    case 1:
                        result = client.Add(value1, value2);
                        Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);
                        break;

                    case 2:
                        result = client.Subtract(value1, value2);
                        Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);
                        break;

                    case 3:
                        result = client.Multiply(value1, value2);
                        Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);
                        break;

                    case 4:
                        result = client.Divide(value1, value2);
                        Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);
                        break;

                    case 5:
                        result = client.Power(value1, value2);
                        Console.WriteLine("Power({0}, {1}) = {2}", value1, value2, result);
                        break;

                    case 6:
                        result = client.SquareRoot(value1);
                        Console.WriteLine("SquareRoot({0}) = {1}", value1, result);
                        break;

                    case 7:
                        result = client.Sine(value1);
                        Console.WriteLine("Sine({0}) = {1}", value1, result);
                        break;

                    case 8:
                        result = client.Cosine(value1);
                        Console.WriteLine("Cosine({0}) = {1}", value1, result);
                        break;

                    case 9:
                        result = client.Tangent(value1);
                        Console.WriteLine("Tangent({0}) = {1}", value1, result);
                        break;

                    case 10:
                        result = client.Logarithm(value1);
                        Console.WriteLine("Logarithm({0}) = {1}", value1, result);
                        break;

                    case 11:
                        result = client.Exponential(value1);
                        Console.WriteLine("Exponential({0}) = {1}", value1, result);
                        break;

                    case 12:
                        result = client.AbsoluteValue(value1);
                        Console.WriteLine("AbsoluteValue({0}) = {1}", value1, result);
                        break;

                    case 13:
                        // Print results for all operations
                        Console.WriteLine("\nPerforming all operations with the given values...\n");

                        Console.WriteLine("Add({0},{1}) = {2}", value1, value2, client.Add(value1, value2));
                        Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, client.Subtract(value1, value2));
                        Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, client.Multiply(value1, value2));
                        Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, client.Divide(value1, value2));
                        Console.WriteLine("Power({0},{1}) = {2}", value1, value2, client.Power(value1, value2));
                        Console.WriteLine("SquareRoot({0}) = {1}", value1, client.SquareRoot(value1));
                        Console.WriteLine("Sine({0}) = {1}", value1, client.Sine(value1));
                        Console.WriteLine("Cosine({0}) = {1}", value1, client.Cosine(value1));
                        Console.WriteLine("Tangent({0}) = {1}", value1, client.Tangent(value1));
                        Console.WriteLine("Logarithm({0}) = {1}", value1, client.Logarithm(value1));
                        Console.WriteLine("Exponential({0}) = {1}", value1, client.Exponential(value1));
                        Console.WriteLine("AbsoluteValue({0}) = {1}", value1, client.AbsoluteValue(value1));
                        break;
                }
            }

            // Prompt the user to press enter to close
            Console.WriteLine("\nPress <ENTER> to terminate client.");
            Console.ReadLine();

            // Closing the client releases all communication resources.
            client.Close();
        }
    }
}
