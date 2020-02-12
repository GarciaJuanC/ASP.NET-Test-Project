using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Social_Media.Models
{
    public class Account
    {

        public string email { get; set; }
        public string password { get; set; }

        
    }

    public class AccountDBContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }

}