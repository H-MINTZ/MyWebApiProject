using Microsoft.AspNetCore.Mvc;
using MyWebApiProject.Data;
using MyWebApiProject.Models;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly AppDbContext _context;

    public EmployeesController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
public IActionResult Get()
{
    var employees = _context.Employees.ToList();
    return Ok(employees);
}
    [HttpPost]
public IActionResult Post(Employee employee)
{
    _context.Employees.Add(employee);
    _context.SaveChanges();

    return Ok(employee);
}
}