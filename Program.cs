using System;
using static System.Console;

namespace ProgrammingAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program evaluates the are of a triangle
            and determines if a triangle can be formed or not*/
            double triangleArea;
            double a, b, c, s;

            // asking for the length of 3 lines of a triangle
            Write("Enter first line length: ");
            a = Convert.ToInt32(ReadLine());
            Write("Enter second line length: ");
            b = Convert.ToInt32(ReadLine());
            Write("Enter third line length: ");
            c = Convert.ToInt32(ReadLine());
            //multiply a, b, c then devide by 2 to get semi-perimeter
            s = (a + b + c) / 2;
            //calculating formula shown to find area of a triangle
            triangleArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            if (a + b > c & b + c > a & c + a > b)

            {
                //prints answer correctily to the nearest hundreth decimal
                WriteLine("\n The area of the triangle is: {0:N2}", triangleArea);

            }

            else
                //print if rules aren't followed in previous if() statement
                WriteLine("\n Lines cannot form a triangle.");

        }
    }
}

