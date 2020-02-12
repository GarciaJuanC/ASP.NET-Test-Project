using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Social_Media.Models
{
    public class User: Account
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public char middleInitial { get; set; }
        public string userName { get; set; }

    }

    public class UserDBContext : DbContext
    {
        public DbSet<User> Accounts { get; set; }
    }
}