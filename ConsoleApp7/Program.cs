using System;

class Point
{
    public int X { get; set; } //координата X
    public int Y { get; set; } //координата Y

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
//Метод Point используется для задания координат точки.


class Circle
{
    private Point Center { get; set; } //центр окружности
    public int Radius { get; set; } //радиус

    public Circle(Point center, int radius)
    {
        Center = center;
        Radius = radius;
    }

    public bool IsInside(Point point)
    {
        return (point.X - Center.X) * (point.X - Center.X) + (point.Y - Center.Y) * (point.Y - Center.Y) <= Radius * Radius;
    }

    public void ChangeRadius(int radius)
    {
        Radius = radius;
    }
}
//Методы класса Circle позволяют определять принадлежность точки к окружности и изменять радиус окружности.


class Program
{
    static void Main(string[] args)
    {
        Point center = new Point(0, 0);
        int radius = 5;

        Circle circle = new Circle(center, radius);

        Console.WriteLine("Введите новый радиус окружности: ");
        int newRadius = int.Parse(Console.ReadLine());
        circle.ChangeRadius(newRadius);

        Console.WriteLine("Введите координаты точки: ");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Point point = new Point(x, y);

        if (circle.IsInside(point))
        {
            Console.WriteLine("Точка находится внутри окружности.");
        }
        else
        {
            Console.WriteLine("Точка находится за пределами окружности.");
        }

        Console.ReadLine();
    }
}