using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UC4_EqualityOfPointsAndLines
{
    
    public void CheckingEqualityOfPointsAndLines()
    {
        Console.WriteLine("Enter x1 and y1 Coordinates");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("x1:" + x1);
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("y1:" + y1);

        Console.WriteLine("Enter x2 and y2 Coordinates");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("x2:" + x2);
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("y2:" + y2);

        Console.WriteLine("Enter x3 and y3 Coordinates");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("x3:" + x3);
        double y3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("y3:" + y3);

        Console.WriteLine("Enter x4 and y4 Coordinates");
        double x4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("x4:" + x4);
        double y4 = Convert.ToDouble(Console.ReadLine());


        if (x1 == y1 || x2 == y2 || x3 == y3 || x4 == y4)
        {
            Console.WriteLine("Points Are Equal");
        }
        else
        {
            Console.WriteLine("Points Are Not Equal");
        }

        var Length1 = Math.Sqrt((Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2)));
        var Length2 = Math.Sqrt((Math.Pow(x3 - y3, 2) + Math.Pow(x4 - y4, 2)));


        if (Length1 == Length2)

        {
            Console.WriteLine("Two Lines Are Equal");
        }
        else
        {
            Console.WriteLine("Two Lines Are Not Equal");
        }

    }
}

    