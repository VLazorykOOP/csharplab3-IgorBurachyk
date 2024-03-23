using System;
using System.Collections.Generic;

// Базовий клас: Працівник
public class Employee : IComparable<Employee>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Salary { get; set; }

    // Конструктор
    public Employee(string name, string surname, double salary)
    {
        Name = name;
        Surname = surname;
        Salary = salary;
    }

    // Метод для виведення інформації про працівника
    public void Show()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Salary: {Salary}");
    }

    // Реалізація методу CompareTo для сортування за заробітною платою
    public int CompareTo(Employee other)
    {
        if (other == null)
            return 1;

        return Salary.CompareTo(other.Salary);
    }
}

// Похідний клас: Робітник
public class Worker : Employee
{
    public string Position { get; set; }

    // Конструктор
    public Worker(string name, string surname, double salary, string position)
        : base(name, surname, salary)
    {
        Position = position;
    }
}

// Похідний клас: Кадри
public class HR : Employee
{
    public string Department { get; set; }

    // Конструктор
    public HR(string name, string surname, double salary, string department)
        : base(name, surname, salary)
    {
        Department = department;
    }
}

// Похідний клас: Інженер
public class Engineer : Employee
{
    public string Specialization { get; set; }

    // Конструктор
    public Engineer(string name, string surname, double salary, string specialization)
        : base(name, surname, salary)
    {
        Specialization = specialization;
    }
}

// Похідний клас: Адміністрація
public class Administration : Employee
{
    public string Position { get; set; }

    // Конструктор
    public Administration(string name, string surname, double salary, string position)
        : base(name, surname, salary)
    {
        Position = position;
    }
}

class SecondTask
{
    static void Main(string[] args)
    {
        // Створення масиву базового класу Employee
        Employee[] employees = new Employee[]
        {
            new Worker("Igor", "Burachyk", 3000, "Factory worker"),
            new HR("Ivan", "Ivanenko", 2500, "Human Resources"),
            new Engineer("Stepan", "Rudnychenko", 4000, "Software engineer"),
            new Administration("Lisa", "Rotar", 3500, "Manager")
        };

        // Сортування масиву за заробітною платою
        Array.Sort(employees);

        // Виведення впорядкованого масиву
        Console.WriteLine("Sorted employees by salary:");
        foreach (var emp in employees)
        {
            emp.Show();
        }
    }
}
