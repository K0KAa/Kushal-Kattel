using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class EmployeeController: Controller
{
    public ActionResult Index()
    {
        var employees = Person.GetEmployee();
        return View(employees);
    }
    public ActionResult Detail(string firstName)
    {
        var employees =Person.GetEmployee();
        var employee = employees.Where(x => x.FirstName==firstName).First();
        return View(employee);
    }
}