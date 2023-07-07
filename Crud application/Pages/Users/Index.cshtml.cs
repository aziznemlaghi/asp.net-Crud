using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud_application.Data;
using Crud_application.Model;

namespace Crud_application.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Crud_application.Data.Crud_applicationContext _context;

        public IndexModel(Crud_application.Data.Crud_applicationContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
