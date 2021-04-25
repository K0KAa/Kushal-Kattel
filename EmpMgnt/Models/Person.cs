
using System.Collections.Generic;

public class Person
{
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'm';
    public double Salary { get; set; }

    public static List<Person> GetEmployees()
    {
        Person ep1 = new Person() { FirstName = "Bishnu", SurName = "Rawal", Address = "Solu", Salary = 23423.4 };
        Person ep2 = new Person() { FirstName = "Bishnu", SurName = "Rawal", Address = "Solu", Salary = 23423.4 };
        Person ep3 = new Person() { FirstName = "Bishnu", SurName = "Rawal", Address = "Solu", Salary = 23423.4 };
        Person ep4 = new Person() { FirstName = "Bishnu", SurName = "Rawal", Address = "Solu", Salary = 23423.4 };
        List<Person> employees = new List<Person> { ep1, ep2, ep3, ep4 };
        return (employees);

    }

};
