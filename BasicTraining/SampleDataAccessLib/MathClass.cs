using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataAccessLib
{
    /// <summary>
    /// This class contains the APIs for performing simple Arithematic Operations required for BasicTraining Application
    /// </summary>
    public class MathClass
    {
        public static double AddFunc(double v1, double v2) => v1 + v2;
        public static double SubFunc(double v1, double v2) => v1 - v2;
        public static double MulFunc(double v1, double v2) => v1 * v2;
        public static double DivFunc(double v1, double v2) => v1 / v2;
    }
}
