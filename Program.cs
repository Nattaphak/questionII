using System;

class Program
{
    static void Main(string[] args)
    {
        double a,b,x;

        double.TryParse(Console.ReadLine(), out a);
        double.TryParse(Console.ReadLine(), out b);
        double.TryParse(Console.ReadLine(), out x);

        if(x > a || x < b)
        {
            Console.WriteLine("Flase");
        }
        else
        {
            Console.WriteLine("True");
        }
    }
}