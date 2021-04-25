using System.Collections.Generic;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public char Gender { get; set; } = 'm';
    public string Address { get; set; }
    public double Salary { get; set; }

    public static List<Person> GetEmployee()
    {
        Person ep1 = new Person() { FirstName="Kushal", LastName ="Kattel", Gender='m', Address="Solukhumbu", Salary=2345.5 };
        Person ep2 = new Person() { FirstName = "Kushal", LastName = "Kattel", Gender = 'm', Address = "Solukhumbu", Salary = 2345.5 };
        List<Person> employees = new List<Person> { ep1, ep2 };
        return(employees);
    }
}