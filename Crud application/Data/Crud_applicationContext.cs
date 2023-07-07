using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud_application.Model;

namespace Crud_application.Data
{
    public class Crud_applicationContext : DbContext
    {
        public Crud_applicationContext (DbContextOptions<Crud_applicationContext> options)
            : base(options)
        {
        }

        public DbSet<Crud_application.Model.User> User { get; set; } = default!;
    }
}
