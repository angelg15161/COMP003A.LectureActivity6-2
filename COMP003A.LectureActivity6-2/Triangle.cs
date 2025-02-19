namespace COMP003A.LectureActivity6_2;

/// <summary>
/// Represents a triangle with a specific area calculation. 
/// </summary>
class Triangle : Shape 
{
    // Auto-implemented properties for the length and height of a triangle. 
    public double BaseLength { get; set; }
    public double Height { get; set; }

    /// <summary>
    /// Constructor for the triangle class. 
    /// </summary>
    /// <param name="baseLength"></param>
    /// <param name="height"></param>
    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    /// <summary>
    /// Displays the area of a triangle. 
    /// </summary>
    public override void DisplayArea()
    {
        Console.WriteLine($"Triangle Area: {BaseLength * Height * 0.5}");
    }
}