namespace _1012;
using Entitie;

class Program
{
    static void Main(string[] args)
    {
        City city1 = new City { CountryCount = 10 };
        City city2 = new City { CountryCount = 20 };

        City city3 = city1 + city2;
        City city4 = city1 - city2;
        City city5 = city1 == city2;
        City city6 = city1 != city2;

        Console.WriteLine(city3.CountryCount);
        Console.WriteLine(city4.CountryCount);
        Console.WriteLine(city5.CountryCount);
        Console.WriteLine(city6.CountryCount);
    }
}