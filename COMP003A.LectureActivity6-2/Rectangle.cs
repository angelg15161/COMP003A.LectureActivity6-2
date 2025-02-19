namespace COMP003A.LectureActivity6_2;

/// <summary>
/// Represents a rectangle with a specific area calculation. 
/// </summary>
class Rectangle : Shape
{
    // Auto-implemented properties for the length and width of a rectangle. 
    public double Length { get; set; }
    public double Width { get; set; }

    /// <summary>
    /// Constructor for the rectangle class. 
    /// </summary>
    /// <param name="length"></param>
    /// <param name="width"></param>
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    /// <summary>
    /// Displays the area of a rectangle. 
    /// </summary>
    public override void DisplayArea()
    {
        Console.WriteLine($"Rectangle Area: {Length * Width}");
    }
}