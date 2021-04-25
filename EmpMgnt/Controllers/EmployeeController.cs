using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        //object initializer syntax 
       
        var employees = Person.GetEmployees();
        
        return View(employees);
    }
    public ActionResult Detail(string firstName)
    {
        var employees = Person.GetEmployees();
        var employee = employees.FirstOrDefault( x=> x.FirstName == firstName);
        return View(employee);
    }
}

