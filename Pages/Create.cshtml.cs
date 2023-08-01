using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Task5.DataBaseAccess;
using Task5.Model;

namespace Task5.Pages
{
    public class CreateModel : PageModel
    {
        private readonly DataBaseContext _context;

        [BindProperty]
        public EmployeeModel Employee { get; set; }

        public CreateModel(DataBaseContext context)
        {
            _context = context;
        }
        [BindProperty, DataType(DataType.Date)]
        public DateTime Bdate { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employee.Add(Employee);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}

