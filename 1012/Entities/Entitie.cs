namespace _1012.Entities;

public class Employe
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Salary { get; set; }

    public Employe()
    {
        Name = "Unknown";
        Age = 0;
        Salary = "Unknown";
    }

    public Employe(string name, int age, string salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public static Employe operator +(Employe emp, double amount)
    {
        double salary = double.Parse(emp.Salary);
        salary += amount;
        emp.Salary = salary.ToString();
        return emp;
    }

    public static Employe operator -(Employe emp, double amount)
    {
        double salary = double.Parse(emp.Salary);
        salary -= amount;
        emp.Salary = salary.ToString();
        return emp;
    }

    public static bool operator ==(Employe emp1, Employe emp2)
    {
        return emp1.Salary == emp2.Salary;
    }

    public static bool operator !=(Employe emp1, Employe emp2)
    {
        return emp1.Salary != emp2.Salary;
    }

    public static bool operator <(Employe emp1, Employe emp2)
    {
        double salary1 = double.Parse(emp1.Salary);
        double salary2 = double.Parse(emp2.Salary);
        return salary1 < salary2;
    }

    public static bool operator >(Employe emp1, Employe emp2)
    {
        double salary1 = double.Parse(emp1.Salary);
        double salary2 = double.Parse(emp2.Salary);
        return salary1 > salary2;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Employe emp = (Employe) obj;
        return Name == emp.Name && Age == emp.Age && Salary == emp.Salary;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
    }
}