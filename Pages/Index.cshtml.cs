using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Task5.DataBaseAccess;
using Task5.Model;

namespace Task5.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DataBaseContext _context;

        public IndexModel(DataBaseContext context)
        {
            _context = context;
        }

        public IList<EmployeeModel> Employees { get; set; }

        public void OnGet()
        {
            Employees = _context.Employee.ToList();
        }
    }
    }