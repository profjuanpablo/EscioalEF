using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppSchool.Models;

namespace AppSchool.Data
{
    public class AppSchoolContext : DbContext
    {
        public AppSchoolContext (DbContextOptions<AppSchoolContext> options)
            : base(options)
        {
        }

        public DbSet<AppSchool.Models.Grade> Grade { get; set; } = default!;

        public DbSet<AppSchool.Models.Student> Student { get; set; }
    }
}
