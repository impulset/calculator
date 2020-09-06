using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.Write("Enter your expression: ");
            string input = Console.ReadLine();
            string inputReplace = input.Replace(" ", "")
                                       .Replace(".", "");
            string[] mathArray = Regex.Split(inputReplace, "[0-9]{1,}");
            string[] intArray = input.Split('+', '-', '*', '/');
            float[] floatArray = Array.ConvertAll(intArray, float.Parse);
            int countArray = floatArray.Count();
            int xe = 1;
            int x = 0;
            int x1 = 0;
            float z = floatArray[x];

            while (x1 < countArray - 1)
            {
                if (mathArray[xe] == "-")
                {
                    xe += 1;
                    x1 += 1;
                    z -= floatArray[x1];
                }
                else if (mathArray[xe] == "+")
                {
                    xe += 1;
                    x1 += 1;
                    z += floatArray[x1];
                }
                else if (mathArray[xe] == "*")
                {
                    xe += 1;
                    x1 += 1;
                    z *= floatArray[x1];
                }
                else if (mathArray[xe] == "/")
                {
                    xe += 1;
                    x1 += 1;
                    z /= floatArray[x1];
                }
            }
            Console.WriteLine("Result: " + z);

        }
    }
}
