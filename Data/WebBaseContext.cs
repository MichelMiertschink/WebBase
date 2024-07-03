using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebBase.Models;

namespace WebBase.Data
{
    public class WebBaseContext : DbContext
    {
        public WebBaseContext (DbContextOptions<WebBaseContext> options)
            : base(options)
        {
        }

        public DbSet<WebBase.Models.Pais> Pais { get; set; } = default!;
    }
}
