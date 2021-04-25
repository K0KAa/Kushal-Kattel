using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id { get; set; }
    [Required(ErrorMessage="First Name is needed.")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    public char? Gender { get; set; } = 'M';

    public double? Salary { get; set; }
    public static List<Person> GetPerson()
    {
        Person ep1 = new Person { Id = 1, FirstName = "Kushal", LastName = "Kattel", Gender = 'M', Salary = 295000.0 };
        Person ep2 = new Person { Id = 2, FirstName = "Prashant", LastName = "Shrestha", Gender = 'M', Salary = 230743.44 };
        Person ep3 = new Person { Id = 3, FirstName = "Rupesh", LastName = "Chaulagain", Gender = 'M', Salary = 3432.54 };
        Person ep4 = new Person { Id = 4, FirstName = "Anjana", LastName = "Ghimire", Gender = 'F', Salary = 10000.0 };
        List<Person> employees = new List<Person> { ep1, ep2, ep3, ep4 };
        return (employees);

    }

}
