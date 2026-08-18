using EmployeePortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.Controllers;

public class AccountController : Controller
{
    private readonly ApplicationDbContext _context;

    public AccountController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        var employee = _context.Employees
            .FirstOrDefault(e =>
                e.Username == model.Username &&
                e.Password == model.Password);

        if (employee != null)
        {
            return Content($"Welcome {employee.FirstName}! Login successful.");
        }

        ViewBag.Error = "Invalid username or password.";
        return View(model);
    }
}