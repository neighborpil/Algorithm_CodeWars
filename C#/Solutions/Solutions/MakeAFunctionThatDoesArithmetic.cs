using System;

namespace Solutions
{
    public static class MakeAFunctionThatDoesArithmetic
    {
        public static double Arithmetic(double a, double b, string op)
        {
            double result;

            switch (op)
            {
                case "add": result = a + b; break;
                case "subtract": result = a - b; break;
                case "multiply": result = a * b; break;
                case "divide":
                    if (b != 0.0)
                    {
                        result = a / b;
                    }
                    else
                    {
                        result = Double.NaN;
                    }
                    break;
                default:
                    result = Double.NaN; break;
            }

            return result;
        }
    }
}