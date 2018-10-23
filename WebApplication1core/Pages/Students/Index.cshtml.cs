using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1core.Data;
using WebApplication1core.Models;

namespace WebApplication1core.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1core.Models.WebApplication1coreContext _context;

        public IndexModel(WebApplication1core.Models.WebApplication1coreContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
