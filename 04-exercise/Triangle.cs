using System;

public class Triangle
{
    public string name;
    public double A, B, C, area;

    public Triangle(string name)
    {
        this.name = name;
    }

    public void readValueOfSides()
    {
        Console.WriteLine("Type the sides of the " + name + " triangle: ");
        this.A = double.Parse(Console.ReadLine());
        this.B = double.Parse(Console.ReadLine());
        this.C = double.Parse(Console.ReadLine());
    }

    public Triangle calculateArea()
    {
        double p = (A + B + C) / 2.0;
        this.area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        return this;
    }
    public void printArea()
    {
        Console.WriteLine("The area of ​​triangle " + name + " is: " + area);
    }


}