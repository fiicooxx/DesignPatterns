using Factory;

ShapeFactory shapeFactory = new ShapeFactory();

var circle = shapeFactory.CreateShape(ShapeType.Circle);
circle.Render();

var triangle = shapeFactory.CreateShape(ShapeType.Triangle);
triangle.Render();

var square = shapeFactory.CreateShape(ShapeType.Square);
square.Render();


