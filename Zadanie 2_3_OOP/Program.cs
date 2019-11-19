using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle
{
    double a;
    double b;
    double c;
    public double Length_A
    {
        get { return a; }
        set { a = value; }
    }

    public double Length_B
    {
        get { return b; }
        set { b = value; }
    }

    public double Length_C
    {
        get { return c; }
        set { c = value; }
    }
    public bool Existence
    {
        get { if ( (a + b) > c && (a + c) > b && (b + c) > a) return true; else return false; }
     }

    public double this[int index]
    {
        get
        {
            if (index == 0)
                return (Math.Acos((Math.Pow(b, 2)+ Math.Pow(c, 2)- Math.Pow(a, 2))/(2* b * c))  *180/Math.PI );
            if (index == 1)
                return (Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) * 180 / Math.PI);
            if (index == 2)
                return (Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)) * 180 / Math.PI);
            Console.WriteLine("Ошибка {0},index");
            return -1;
        }
    }

    public void Write() { Console.WriteLine("Сторони треугольника равны a={0} и b={1} и c={2}", a, b, c); }
    public double Perimetr() { return (a + b + c); }
    public double Area() { double p = (a + b + c) / 2; return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); }

}


class Program
{
    static void Main()
    {
        Triangle ABC = new Triangle();
        ABC.Length_A = 3;
        ABC.Length_B = 4;
        ABC.Length_C = 5;
        double Perimetr, Area;

        Perimetr = ABC.Perimetr();
        Area = ABC.Area();
        Console.WriteLine("Данные по треугольнику");
        Console.WriteLine("Сторони треугольника равны: A ={0} и B = {1} и C = {2}", ABC.Length_A, ABC.Length_B, ABC.Length_C);
        Console.WriteLine("Периметр равняется - " + Perimetr);
        Console.WriteLine("Площадь равняется - " + Area);

        if (ABC.Existence)
            Console.WriteLine("Треугольник из заданными длинами существует");
        else
            Console.WriteLine("Треугольник из заданными длинами не существует");

        Console.WriteLine("Угол напротив стороны A равен {0}, напротив стороны B равен {1}, напротив стороны C равен {2}", ABC[0], ABC[1], ABC[2]);
    }
      
}