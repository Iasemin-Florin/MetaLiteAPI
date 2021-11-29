using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MetaLiteApi.contexts
{
    public class UsersDbContext : DbContext, IUsersDbContext
    {
        public DbSet<Users> Users { get; set; }

        public UsersDbContext(DbContextOptions<UsersDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
