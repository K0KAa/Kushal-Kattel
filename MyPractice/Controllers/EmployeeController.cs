using Microsoft.AspNetCore.Mvc;
using System.Linq;
public class EmployeeController : Controller
{


    public ActionResult EmployeeDetail()
    {
        var p1 = Person.GetPerson();
        return View(p1);
    }
    public ActionResult Detail([FromQuery]int id)
    {
        var employees = Person.GetPerson();
        var employee = employees.FirstOrDefault(x => x.Id == id);

        return View(employee);
    }

    public ActionResult Add()
    {
        return View();
    }

[HttpPost]
    public ActionResult<string> Add([FromForm] Person person)
    {
        return "saved";
    }

}