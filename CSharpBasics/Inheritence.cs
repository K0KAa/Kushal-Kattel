using System;
public abstract class Shape
{
    
    public abstract double GetArea();
    
    public abstract double GetCircumference();

    public virtual void PrintResults()
    {
        var x = this.GetArea();
        var y = this.GetCircumference();
        Console.WriteLine($"The Area is {x} and the Circumference is {y}");
    }
    
}


public class Rectangle: Shape{

    
    public double Length { get; set; }
    public double Breath { get; set ;}

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breath = breadth;
    }
    public override double GetArea() => Length*Breath;
    public override double GetCircumference() => 2*(Length*Breath);
    public override void PrintResults()
    {
        Console.WriteLine($"Printing result of rectangle of [{Length}]*[{Breath}] is {this.GetArea()}");
    }
}

public class Square : Rectangle
{
    public Square(double side) :base(side,side)
    {
        
        
        base.Length = side;
        base.Breath = side;
    }
    public override void PrintResults()
    {
        Console.WriteLine($"Printing result of square of [{Length}]*[{Breath}] is {this.GetArea()}");
    }
}

public class Circle : Shape
{
    public double Radius {get; set;}

    public override double GetArea()=> Math.PI*Radius*Radius;

    public override double GetCircumference() =>2*Math.PI*Radius;

}