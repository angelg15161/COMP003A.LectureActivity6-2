/*
    Author: Angel Gomez
    Course: COMP-003A
    Faculty: Jonathan Cruz
    Purpose: C# application that demonstrates polymorphism using method overloading and method overriding within a geometric shapes context.
*/ 
namespace COMP003A.LectureActivity6_2;

class Program
{
    static void Main(string[] args)
    {
        // Demonstrate Method overloading 
        ShapeCalculator calculator = new ShapeCalculator();
        Console.WriteLine($"Circle Area: {calculator.CalculateArea(5)}");
        Console.WriteLine($"Rectangle Area: {calculator.CalculateArea(5, 10)}");
        Console.WriteLine($"Triangle Area: {calculator.CalculateArea(5, 10, true)}");
        
        // Demonstrating method overriding 
        // Creating a base class reference to a derived class object for polymorphism 
        Shape myCircle = new Circle(7);
        Shape myRectangle = new Rectangle(4, 8); 
        Shape myTriangle = new Triangle(2, 2);
        
        // Calling the DisplayArea method for the circle, rectangle, and triangle objects. 
        myCircle.DisplayArea();
        myRectangle.DisplayArea();
        myTriangle.DisplayArea();
    }
}