using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Task5.DataBaseAccess;
using Task5.Model;

namespace Task5.Pages
{
    public class EditModel : PageModel
    {

        private readonly DataBaseContext _context;

        public EditModel(DataBaseContext context)
        {
            _context = context;
        }
        [BindProperty, DataType(DataType.Date)]
        public DateTime Bdate { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ssn { get; set; }

        [BindProperty]
        public EmployeeModel Employee { get; set; }

        public IActionResult OnGet()
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
            if (!ModelState.IsValid)
            {
                return RedirectToPage("Index");
            }

            _context.Attach(Employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            TempData["AlertScript"] = "Swal.fire('Success!', 'Employee Updated Successfully', 'success');";

            return RedirectToPage("Index");
        }
    }
}

