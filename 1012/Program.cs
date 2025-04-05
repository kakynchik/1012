namespace _1012;
using Entities;

class Program
{
    static void Main(string[] args)
    {
        Employe emp1 = new Employe("vovchik", 16, "5000");
        Employe emp2 = new Employe("zenya", 18, "5000");

        if (emp1 == emp2)
        {
            Console.WriteLine("Both employees have the same salary.");
        }
        else
        {
            Console.WriteLine("Both employees have different salaries.");
        }

        if (emp1 > emp2)
        {
            Console.WriteLine("vovchik has a higher salary than Jane.");
        }
        else
        {
            Console.WriteLine("zhenia has a higher salary than John.");
        }

        emp1 = emp1 + 500;
        emp2 = emp2 - 500;

        Console.WriteLine($"vovcik's new salary: {emp1.Salary}");
        Console.WriteLine($"zhendsik's new salary: {emp2.Salary}");
    }
}