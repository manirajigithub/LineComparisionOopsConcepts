using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UC3_CompareTwoLines
{
    double len2;
    int X1, X2, Y1, Y2;
    int P1, P2, Q1, Q2;
    public void checkequal()
    {

        Console.WriteLine("Enter value for  coordinate x1 y1 x2 y2");
        X1 = Convert.ToInt32(Console.ReadLine());
        X2 = Convert.ToInt32(Console.ReadLine());
        Y1 = Convert.ToInt32(Console.ReadLine());
        Y2 = Convert.ToInt32(Console.ReadLine());

        double LineLength = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        double len = Math.Round(LineLength, 2);

        Console.WriteLine("Length of Line1 is: " + len);

        Console.WriteLine("Enter value for  coordinate P1 P2 Q1 Q2");
        P1 = Convert.ToInt32(Console.ReadLine());
        P2 = Convert.ToInt32(Console.ReadLine());
        Q1 = Convert.ToInt32(Console.ReadLine());
        Q2 = Convert.ToInt32(Console.ReadLine());

        double LineLength1 = Math.Sqrt(Math.Pow((P2 - P1), 2) + Math.Pow((Q2 - Q1), 2));
        double len1 = Math.Round(LineLength1, 2);


        Console.WriteLine("Length of Line2 is: " + len1);

        if (len.Equals(len1))
        {
            Console.WriteLine("Value of both the lines are equal");
        }
        else
        {
            Console.WriteLine("Value of both the lines are not equal");
        }
    }


}

