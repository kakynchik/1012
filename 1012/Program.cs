namespace _1012;
using Entitie;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var a = new Matrix(2, 2, new double[,]
        {
            { 1, 2 },
            { 3, 4 }
        });

        var b = new Matrix(2, 2, new double[,]
        {
            { 5, 6 },
            { 7, 8 }
        });

        var c = a + b;

        Console.WriteLine(c[0, 0]);
    }
}
