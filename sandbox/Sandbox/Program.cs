using System;

class Program
{
    static void Main(string[] args)
    {
        // double x = 10;
        Circle myCircle = new Circle(10);
        myCircle.DisplayCircleArea();
        Cylinder myCylinder = new Cylinder(10, myCircle);
        double volume = myCylinder.GetVolume();
        Console.WriteLine($"The cylinder volume is: {volume}");
        // Circle myCircle2 = new Circle(20);
        // Console.WriteLine($"The area of the circle is: {myCircle2.GetArea()}");
    }
}