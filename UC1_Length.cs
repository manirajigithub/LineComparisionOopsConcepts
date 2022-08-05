using System.Threading.Tasks;

public class UC1_Length
{

    int X1, X2, Y1, Y2;
    double Length;
    public void Lengthcal()
    {
        Console.WriteLine("Enter value for  coordinate x1 y1 x2 y2");
        X1 = Convert.ToInt32(Console.ReadLine());
        X2 = Convert.ToInt32(Console.ReadLine());
        Y1 = Convert.ToInt32(Console.ReadLine());
        Y2 = Convert.ToInt32(Console.ReadLine());
        Length = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        double len = Math.Round(Length, 2);
        Console.Write("Calculate The Length Of Line");
    }

}
