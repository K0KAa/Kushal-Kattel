using System;
using NameCollection;

public class MyMain
{
    static void Main()
    {
        //Collections collections = new Collections();
        //collections.LearnLists();
        //collections.LearnDictionary();
        Square square = new Square(22.4);
        var x = square.GetArea();
        var y = square.GetCircumference();
        var rectangle = new Rectangle(3.4,34.4);
        rectangle.PrintResults();

        Square square1 = new Square(24.4);
        Square square2 = new Square(223.4);
        square.PrintResults();


    }
}