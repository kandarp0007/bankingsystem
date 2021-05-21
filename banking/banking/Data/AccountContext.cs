using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banking.Data
{
    public class AccountContext : IdentityDbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        {

        }

        public DbSet<Account> Account { get; set; }


        public DbSet<Transaction> AllTransaction { get; set; }
    }
}
