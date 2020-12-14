using System;

namespace _04_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x = new Triangle("X");
            Triangle y = new Triangle("Y");

            x.readValueOfSides();
            y.readValueOfSides();

            x.calculateArea().printArea();
            y.calculateArea().printArea();

        }
    }
}
