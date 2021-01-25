using System;
using System.Collections.Generic;
using System.Text;

namespace ActiveUserAppCoreDAO.Context
{
    public class UserDBContext: DbContext
    {
        public UserDBContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}
