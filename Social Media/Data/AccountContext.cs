using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Social_Media.Models;

namespace Social_Media.Data
{
    public class AccountContext: DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) 
            : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }
    }
}