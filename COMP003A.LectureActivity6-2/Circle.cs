namespace COMP003A.LectureActivity6_2;

/// <summary>
/// Represents a circle with a specific area calculation. 
/// </summary>
class Circle : Shape 
{
    //Auto-implemented property for the radius of a circle. 
    public double Radius { get; set; }

    /// <summary>
    /// Constructor for the circle class. 
    /// </summary>
    /// <param name="radius"></param>
    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// Displays the area of a circle. 
    /// </summary>
    public override void DisplayArea()
    {
        Console.WriteLine($"Circle Area: {Math.PI * Radius * Radius}");
    }
}