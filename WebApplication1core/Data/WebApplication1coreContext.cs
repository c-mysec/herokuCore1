using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1core.Data;

namespace WebApplication1core.Models
{
    public class WebApplication1coreContext : DbContext
    {
        public WebApplication1coreContext (DbContextOptions<WebApplication1coreContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1core.Data.Student> Student { get; set; }
    }
}
