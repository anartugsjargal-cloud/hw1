using System;

namespace hw1
{
    internal static class ProgramHelpers
    {
        static double Calculate(double x) => 2 * Math.Cos(1.0 / (x * x + 2))
                   / (x * x * x + 1);
    }
}