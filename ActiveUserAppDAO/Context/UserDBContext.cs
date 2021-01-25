using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using ActiveUserAppDATA;

namespace ActiveUserAppDAO.Context
{

    public class UserDBContext : DbContext
    {
        public UserDBContext() : base("DefaultConnection") 
        {
            Database.SetInitializer<UserDBContext>(null);
        }
        public DbSet<User> User { get; set; }
    }
}
