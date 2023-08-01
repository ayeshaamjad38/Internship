using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Task5.DataBaseAccess;
using Task5.Model;

namespace Task5.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly DataBaseContext _context;

        [BindProperty]
        public EmployeeModel Employee { get; set; }

        public DeleteModel(DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(string ssn)
        {
            Employee = _context.Employee.Find(ssn);
            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            var employeeToDelete = _context.Employee.Find(Employee.ssn);
            if (employeeToDelete == null)
            {
                return NotFound();
            }

            _context.Employee.Remove(employeeToDelete);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}

