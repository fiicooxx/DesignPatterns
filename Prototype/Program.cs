using Prototype;

Circle circle1 = new Circle()
{
    Radius = 5,
    X = 1,
    Y = 2,
    Border = new Border()
    {
        Color = "Red",
        Size = "2px"
    }
};

Circle circle2 = (Circle)circle1.Clone();

bool refEquals = ReferenceEquals(circle1, circle2);
Console.WriteLine("ReferenceEquals: " + refEquals);

bool borderReferenceEquals = ReferenceEquals(circle1.Border, circle2.Border);
Console.WriteLine("BorderReferenceEquals: " + borderReferenceEquals);